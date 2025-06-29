namespace InsightFlow.Application.Services
{
    public class OpenAISuggestionService : IOpenAISuggestionService
    {
        public Task<string> GenerateSuggestionAsync(string incidentDescription, CancellationToken cancellationToken)
        {
            return Task.FromResult("IA mock");
        }
    }
}