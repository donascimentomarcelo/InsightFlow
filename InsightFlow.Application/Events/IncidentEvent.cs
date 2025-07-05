using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Domain;
using MediatR;

namespace InsightFlow.Application.Events
{
    public class IncidentEvent :  INotification
    {
        public Incident Incident { get; set; }
    }
}