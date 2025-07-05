using InsightFlow.Application.Repositories;
using InsightFlow.Application.Services;
using InsightFlow.Infrastructure.Context;
using InsightFlow.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InsightFlow.Infrastructure.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInsightFlowDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            // Add application repositories
            services.AddScoped<IIncidentRepository, IncidentRepository>();
            services.AddScoped<ISolutionSuggestionRepository, SolutionSuggestionRepository>();

            // Add application services
            services.AddScoped<IOpenAISuggestionService, OpenAISuggestionService>();

            services.AddDbContext<InsightFlowDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}