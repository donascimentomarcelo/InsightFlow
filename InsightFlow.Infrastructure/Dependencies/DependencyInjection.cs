using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Application.Repositories;
using InsightFlow.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InsightFlow.Infrastructure.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInsightFlowDependencies(this IServiceCollection services)
        {
            // Add application repositories
            services.AddScoped<IIncidentRepository, IncidentRepository>();

            // Add application services
            services.AddScoped<IOpenAISuggestionService, OpenAISuggestionService>();

            return services;
        }
    }
}