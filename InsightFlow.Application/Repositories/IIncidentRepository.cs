using InsightFlow.Domain;

namespace InsightFlow.Application.Repositories
{
    public interface IIncidentRepository
    {
        Task AddAsync(Incident incident, CancellationToken cancellationToken);
        Task<IEnumerable<Incident>> GetAllAsync(CancellationToken cancellationToken);
    }
}