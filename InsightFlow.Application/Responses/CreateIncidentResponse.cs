namespace InsightFlow.Application.Responses
{
    public record CreateIncidentResponse(
        Guid IncidentId,
        string Status
    );
}