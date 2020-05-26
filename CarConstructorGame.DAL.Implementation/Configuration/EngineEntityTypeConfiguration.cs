using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class EngineEntityTypeConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            builder.Property(m => m.HorceForce);
            builder.Property(m => m.CubicCapability);
        }
    }
}
