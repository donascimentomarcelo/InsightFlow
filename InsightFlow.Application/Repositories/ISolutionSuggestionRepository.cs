using InsightFlow.Domain;

namespace InsightFlow.Application.Repositories
{
    public interface ISolutionSuggestionRepository
    {
        Task<SolutionSuggestion> AddAsync(SolutionSuggestion solutionSuggestion, CancellationToken cancellationToken);
    }
}