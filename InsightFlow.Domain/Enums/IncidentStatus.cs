using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsightFlow.Domain
{
    public enum IncidentStatus
    {
        New = 0,
        InProgress = 1,
        Resolved = 2,
        Rejected = 3
    }
}