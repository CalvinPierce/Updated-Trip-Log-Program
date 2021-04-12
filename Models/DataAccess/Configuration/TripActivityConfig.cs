using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models.DataAccess.Configuration
{
    public class TripActivityConfig : IEntityTypeConfiguration<TripActivity>
    {

        public void Configure(EntityTypeBuilder<TripActivity> entity)
        {
            entity.HasKey(ta => new { ta.TripId, ta.ActivityId });

            entity.HasOne(ta => ta.Trip)
                .WithMany(t => t.TripActivities)
                .HasForeignKey(ta => ta.TripId);

            entity.HasOne(ta => ta.Activity)
                .WithMany(t => t.TripActivities)
                .HasForeignKey(ta => ta.ActivityId);
        }
    }
}
