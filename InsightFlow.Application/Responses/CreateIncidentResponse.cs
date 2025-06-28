using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Application.Responses
{
    public record CreateIncidentResponse(
        Guid IncidentId,
        string Status,
        string? SuggestedSolution
    );
}