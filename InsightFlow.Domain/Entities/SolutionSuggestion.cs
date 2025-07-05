namespace InsightFlow.Domain
{
    public class SolutionSuggestion(Guid incidentId, string content)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string? Content { get; private set; } = content;
        public bool Approved { get; private set; } = false;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public Guid IncidentId { get; private set; } = incidentId;
    }
}