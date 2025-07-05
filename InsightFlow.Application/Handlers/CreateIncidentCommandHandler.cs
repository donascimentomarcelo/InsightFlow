using FluentValidation;
using InsightFlow.Application.commands;
using InsightFlow.Application.Responses;
using InsightFlow.Application.Repositories;
using MediatR;
using AutoMapper;
using InsightFlow.Domain;
using InsightFlow.Application.Events;

namespace InsightFlow.Application.Handlers
{
    public class CreateIncidentCommandHandler : IRequestHandler<CreateIncidentCommand, CreateIncidentResponse>
    {
        private readonly IIncidentRepository _repository;
        private readonly IValidator<CreateIncidentCommand> _validator;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CreateIncidentCommandHandler(
            IIncidentRepository repository,
            IValidator<CreateIncidentCommand> validator,
            IMapper mapper,
            IMediator mediator)
        {
            _repository = repository;
            _validator = validator;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CreateIncidentResponse> Handle(CreateIncidentCommand command, CancellationToken cancellationToken)
        {
            var validation = await _validator.ValidateAsync(command, cancellationToken);
            if (!validation.IsValid)
            {
                throw new ValidationException(validation.Errors);
            }
            var incident = _mapper.Map<Incident>(command);
            var newIncident = await _repository.AddAsync(incident, cancellationToken);
            await PublishIncident(newIncident, cancellationToken);
            return new CreateIncidentResponse(Guid.NewGuid(), "Created");
        }

        private async Task PublishIncident(Incident newIncident, CancellationToken cancellationToken)
        {
            await _mediator.Publish(new IncidentEvent { Incident = newIncident }, cancellationToken);
        }
    }
}