using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Domain;

namespace InsightFlow.Application.Repositories
{
    public interface IIncidentRepository
    {
        Task AddAsync(Incident incident, CancellationToken cancellationToken);
    }
}