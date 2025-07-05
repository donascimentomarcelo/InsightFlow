using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Application.Repositories;
using InsightFlow.Domain;
using InsightFlow.Infrastructure.Context;

namespace InsightFlow.Infrastructure.Repositories
{
    public class SolutionSuggestionRepository(InsightFlowDbContext context) : ISolutionSuggestionRepository
    {
        private readonly InsightFlowDbContext _context = context;

        public async Task<SolutionSuggestion> AddAsync(SolutionSuggestion solutionSuggestion, CancellationToken cancellationToken)
        {
            var result = await _context.SolutionSuggestion.AddAsync(solutionSuggestion, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return result.Entity;
        }
    }
}