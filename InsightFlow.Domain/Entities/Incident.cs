namespace InsightFlow.Domain
{
    public class Incident
    {
        public Guid Id { get; private set; }
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public IncidentStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private readonly List<SolutionSuggestion> _suggestions = new();


        public Incident(string title, string description)
        {
            Title = title;
            Description = description;
            MarkAsNew();
            SetCreatedAt(DateTime.UtcNow);
        }
        public Incident(Guid Id, string title, string description)
        {
            this.Id = Id;
            Title = title;
            Description = description;
        }

        public IReadOnlyCollection<SolutionSuggestion> Suggestions => _suggestions.AsReadOnly();

        public void MarkAsNew()
        {
            Status = IncidentStatus.New;
        }

        public void SetCreatedAt(DateTime date)
        {
            CreatedAt = date;
        }

        public IReadOnlyCollection<SolutionSuggestion> GetSuggestions()
        {
            return _suggestions.AsReadOnly();
        }
    }
}