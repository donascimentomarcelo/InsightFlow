using FluentValidation;
using InsightFlow.Application.commands;
using InsightFlow.Application.Responses;
using InsightFlow.Application.Services;
using InsightFlow.Application.Repositories;
using MediatR;

namespace InsightFlow.Application.Handlers
{
    public class CreateIncidentCommandHandler : IRequestHandler<CreateIncidentCommand, CreateIncidentResponse>
    {
        private readonly IIncidentRepository _repository;
        private readonly IOpenAISuggestionService _aiService;
        private readonly IValidator<CreateIncidentCommand> _validator;

        public CreateIncidentCommandHandler(
            IIncidentRepository repository,
            IOpenAISuggestionService aiService,
            IValidator<CreateIncidentCommand> validator)
        {
            _repository = repository;
            _aiService = aiService;
            _validator = validator;
        }

        public async Task<CreateIncidentResponse> Handle(CreateIncidentCommand request, CancellationToken cancellationToken)
        {
            var validation = await _validator.ValidateAsync(request, cancellationToken);
            if (!validation.IsValid)
            {
                throw new ValidationException(validation.Errors);
            }
            return new CreateIncidentResponse(Guid.NewGuid(), "Created", await _aiService.GenerateSuggestionAsync(request.Description, cancellationToken));
        }
    }
}