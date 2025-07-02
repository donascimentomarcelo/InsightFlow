using AutoMapper;
using InsightFlow.Application.Queries;
using InsightFlow.Application.Repositories;
using InsightFlow.Application.Responses;
using MediatR;

namespace InsightFlow.Application.Handlers
{
    public class GetIncidentQueryHandler(
        IIncidentRepository repository,
        IMapper mapper) : IRequestHandler<GetIncidentsQuery, IEnumerable<IncidentResponse>>
    {
        private readonly IIncidentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public async Task<IEnumerable<IncidentResponse>> Handle(GetIncidentsQuery query, CancellationToken cancellationToken)
        {
            var result = await _repository.GetAllAsync(cancellationToken);
            return _mapper.Map<IEnumerable<IncidentResponse>>(result);
        }
    }
}