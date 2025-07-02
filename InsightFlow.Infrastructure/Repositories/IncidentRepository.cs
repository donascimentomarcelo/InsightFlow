using InsightFlow.Application.Repositories;
using InsightFlow.Domain;
using InsightFlow.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InsightFlow.Infrastructure.Repositories
{
    public class IncidentRepository : IIncidentRepository
    {
        private readonly InsightFlowDbContext _context;

        public IncidentRepository(InsightFlowDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Incident incident, CancellationToken cancellationToken)
        {
            await _context.Incidents.AddAsync(incident, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<Incident>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _context.Incidents.ToListAsync();
        }
    }
}