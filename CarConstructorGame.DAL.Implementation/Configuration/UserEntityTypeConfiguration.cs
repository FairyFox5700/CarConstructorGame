using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using static CarConstructorGame.Common.Enums;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var converter = new ValueConverter<GameRating, string>(
            v => v.ToString(),
            v => (GameRating)Enum.Parse(typeof(GameRating), v));

            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserId");


            builder.Property(m => m.MoneySum)
                 .HasColumnType("money").IsRequired(); 

            builder.Property(m => m.UserName)
                .HasMaxLength(50).IsRequired();
            builder.HasIndex(u => u.UserName)
            .IsUnique();


            builder.Property(m => m.GameRating)
                .HasConversion(converter);
            builder.OwnsOne(m => m.Age).Property(a => a.Value).HasDefaultValue(10);


            builder.ToTable("Users");
        }
    }
}
