using InsightFlow.Domain;
using MediatR;

namespace InsightFlow.Application.Events
{
    public class IncidentEvent :  INotification
    {
        public Incident Incident { get; set; }
    }
}