using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Domain;
using Microsoft.EntityFrameworkCore;

namespace InsightFlow.Infrastructure.Context
{
    public class InsightFlowDbContext : DbContext
    {
        public InsightFlowDbContext(DbContextOptions<InsightFlowDbContext> options) : base(options)
        { }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InsightFlowDbContext).Assembly);
        }
        
    }
}