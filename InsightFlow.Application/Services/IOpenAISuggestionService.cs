using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Application.Services
{
    public interface IOpenAISuggestionService
    {
        Task<string> GenerateSuggestionAsync(string incidentDescription, CancellationToken cancellationToken);
    }
}