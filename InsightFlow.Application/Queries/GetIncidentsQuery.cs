using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Application.Responses;
using MediatR;

namespace InsightFlow.Application.Queries
{
    public class GetIncidentsQuery : IRequest<IEnumerable<IncidentResponse>>
    {
        
    }
}