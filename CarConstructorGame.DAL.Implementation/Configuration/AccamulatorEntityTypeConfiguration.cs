using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class AccamulatorEntityTypeConfiguration : IEntityTypeConfiguration<Accamulator>
    {
        public void Configure(EntityTypeBuilder<Accamulator> builder)
        {
            builder.Property(m => m.HoursOfWork);
            builder.Property(m => m.Power);
        }
    }
}
