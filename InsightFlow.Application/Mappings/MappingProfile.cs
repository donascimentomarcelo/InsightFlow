using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InsightFlow.Application.commands;
using InsightFlow.Application.Responses;
using InsightFlow.Domain;

namespace InsightFlow.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateIncidentCommand, Incident>()
                .AfterMap((src, dest) =>
                {
                    dest.MarkAsNew();
                    dest.SetCreatedAt(DateTime.UtcNow);
                });

            CreateMap<Incident, IncidentResponse>();
        }
    }
}