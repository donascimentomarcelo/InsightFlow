using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Application.Responses;
using MediatR;

namespace InsightFlow.Application.commands
{
    public record CreateIncidentCommand(
        string Title,
        string Description
    ) : IRequest<CreateIncidentResponse>;
}