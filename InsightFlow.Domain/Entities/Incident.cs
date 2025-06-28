using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Domain
{
    public class Incident
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public IncidentStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private readonly List<SolutionSuggestion> _suggestions = new();
        public IReadOnlyCollection<SolutionSuggestion> Suggestions => _suggestions.AsReadOnly();
    }
}