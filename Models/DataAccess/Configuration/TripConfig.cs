using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models.DataAccess.Configuration
{
    public class TripConfig : IEntityTypeConfiguration<Trip>
    {

        public void Configure(EntityTypeBuilder<Trip> entity)
        {
            entity.HasOne(t => t.Destination)
                  .WithMany(d => d.Trips)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(t => t.Accommodation)
                  .WithMany(a => a.Trips)
                  .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
