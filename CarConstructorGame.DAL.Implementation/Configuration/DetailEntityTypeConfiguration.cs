using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using static CarConstructorGame.Common.Enums;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class DetailEntityTypeConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            var converter = new ValueConverter<DetailType, string>(
            v => v.ToString(),
            v => (DetailType)Enum.Parse(typeof(DetailType), v));

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("DetailId");
            builder.HasDiscriminator(m => m.DetailType)
        .HasValue<Engine>(DetailType.Engine)
        .HasValue<Accamulator>(DetailType.Accamulator)
        .HasValue<RimsComplect>(DetailType.RimsComplect);
            builder.Property(m => m.ExpluatationStabilityCoef).IsRequired();
            builder.Property(m => m.IsSuitableForRepairing).
                HasDefaultValue(true);
            builder.Property(m => m.RepairPrice)
                 .HasColumnType("money");
            builder.Property(m => m.BuyPrice)
                 .HasColumnType("money");
            builder.HasOne(m => m.Car)
                 .WithMany(m => m.Details)
                 .OnDelete(DeleteBehavior.Cascade).
                  HasForeignKey(m => m.CarId)
                    .IsRequired();
            builder.ToTable("Details");
        }
    }
}
