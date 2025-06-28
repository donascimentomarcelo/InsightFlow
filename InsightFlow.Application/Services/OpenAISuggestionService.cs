using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Application.Services
{
    public class OpenAISuggestionService : IOpenAISuggestionService
    {
        public Task<string> GenerateSuggestionAsync(string incidentDescription, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}