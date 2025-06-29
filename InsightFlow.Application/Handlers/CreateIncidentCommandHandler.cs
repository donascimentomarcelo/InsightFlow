using FluentValidation;
using InsightFlow.Application.commands;
using InsightFlow.Application.Responses;
using InsightFlow.Application.Services;
using InsightFlow.Application.Repositories;
using MediatR;
using AutoMapper;
using InsightFlow.Domain;

namespace InsightFlow.Application.Handlers
{
    public class CreateIncidentCommandHandler : IRequestHandler<CreateIncidentCommand, CreateIncidentResponse>
    {
        private readonly IIncidentRepository _repository;
        private readonly IOpenAISuggestionService _aiService;
        private readonly IValidator<CreateIncidentCommand> _validator;
        private readonly IMapper _mapper;

        public CreateIncidentCommandHandler(
            IIncidentRepository repository,
            IOpenAISuggestionService aiService,
            IValidator<CreateIncidentCommand> validator,
            IMapper mapper)
        {
            _repository = repository;
            _aiService = aiService;
            _validator = validator;
            _mapper = mapper;
        }

        public async Task<CreateIncidentResponse> Handle(CreateIncidentCommand command, CancellationToken cancellationToken)
        {
            var validation = await _validator.ValidateAsync(command, cancellationToken);
            if (!validation.IsValid)
            {
                throw new ValidationException(validation.Errors);
            }
            var incident = _mapper.Map<Incident>(command);
            await _repository.AddAsync(incident, cancellationToken);
            return new CreateIncidentResponse(Guid.NewGuid(), "Created", await _aiService.GenerateSuggestionAsync(command.Description, cancellationToken));
        }
    }
}