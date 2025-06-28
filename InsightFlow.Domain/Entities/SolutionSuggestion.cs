using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Domain
{
    public class SolutionSuggestion
    {
        public Guid Id { get; private set; }
        public string Content { get; private set; }
        public bool Approved { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Guid IncidentId { get; private set; }
    }
}