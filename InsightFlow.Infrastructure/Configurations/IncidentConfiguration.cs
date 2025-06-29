using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightFlow.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsightFlow.Infrastructure.Configurations
{
    public class IncidentConfiguration : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Title).IsRequired().HasMaxLength(100);
            builder.Property(i => i.Description).IsRequired().HasMaxLength(1000);
            builder.Property(i => i.Status).IsRequired();
            builder.HasMany(i => i.Suggestions)
                   .WithOne()
                   .HasForeignKey(s => s.IncidentId);
        }
    }
}