using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class RimsComplectEntityTypeConfiguration : IEntityTypeConfiguration<RimsComplect>
    {
        public void Configure(EntityTypeBuilder<RimsComplect> builder)
        {
            builder.Property(m => m.Count)
                .HasDefaultValue(4);
            builder.Property(m => m.Diameter);
        }
    }
}
