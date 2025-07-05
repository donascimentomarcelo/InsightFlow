using OpenAI.Chat;

namespace InsightFlow.Application.Services
{
    public class OpenAISuggestionService : IOpenAISuggestionService
    {
        public Task<string> GenerateSuggestionAsync(string incidentDescription, CancellationToken cancellationToken)
        {
            // ChatClient client = new(model: "gpt-4o", apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

            // ChatCompletion completion = client.CompleteChat(incidentDescription);

            // Console.WriteLine($"[ASSISTANT]: {completion.Content[0].Text}");

            return Task.FromResult("Simulação de uma mensagem retornada do gpt");
        }
    }
}