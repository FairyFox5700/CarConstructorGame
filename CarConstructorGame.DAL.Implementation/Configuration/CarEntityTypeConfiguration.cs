using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarConstructorGame.DAL.Implementation.Configuration
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("CarId");
            builder.Property(m => m.Distance);
            builder.Property(m => m.IsMoving)
                .HasDefaultValue(false);
            builder.HasOne(m => m.User)
                .WithMany(m => m.Cars)
                .OnDelete(DeleteBehavior.Cascade)
                 .HasForeignKey(m => m.UserId)
                    .IsRequired();
            builder.Property(m => m.TotalCost)
                .HasColumnType("money");
            builder.ToTable("Cars");
        }
    }
}
