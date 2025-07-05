using InsightFlow.Application.Responses;
using MediatR;

namespace InsightFlow.Application.commands
{
    public record CreateIncidentCommand(
        string Title,
        string Description
    ) : IRequest<CreateIncidentResponse>;
}