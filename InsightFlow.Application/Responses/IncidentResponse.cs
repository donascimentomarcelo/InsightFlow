namespace InsightFlow.Application.Responses
{
    public class IncidentResponse
    {
        public Guid IncidentId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? SuggestedSolution { get; set; }
    }

}