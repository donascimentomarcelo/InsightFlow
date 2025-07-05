using InsightFlow.Application.Events;
using InsightFlow.Application.Repositories;
using InsightFlow.Application.Services;
using InsightFlow.Domain;
using MediatR;

namespace InsightFlow.Application.Handlers
{
    public class GenerateSuggestionOnIncidentCreatedHandler(
        IOpenAISuggestionService aiService,
        ISolutionSuggestionRepository solutionSuggestionRepository) : INotificationHandler<IncidentEvent>
    {
        private readonly IOpenAISuggestionService _aiService = aiService;
        private readonly ISolutionSuggestionRepository _solutionSuggestionRepository = solutionSuggestionRepository;

        public async Task Handle(IncidentEvent notification, CancellationToken cancellationToken)
        {
            var suggestionText = await _aiService.GenerateSuggestionAsync(notification.Incident.Description, cancellationToken);

            var solutionSuggestion = new SolutionSuggestion(notification.Incident.Id, suggestionText);

            await _solutionSuggestionRepository.AddAsync(solutionSuggestion, cancellationToken);
        }
    }
}