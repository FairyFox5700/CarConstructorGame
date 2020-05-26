using CarConstructorGame.DAL.Implementation.Configuration;
using CarConstructorGame.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Text;

namespace CarConstructorGame.DAL.Implementation.Core
{
    public class CarGameContext : DbContext
    {
        public CarGameContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<RimsComplect> RimsComplects { get; set; }
        public DbSet<Accamulator> Accamulators { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //{
            //    modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            //    modelBuilder.ApplyConfiguration(new AccamulatorEntityTypeConfiguration());
            //    modelBuilder.ApplyConfiguration(new CarEntityTypeConfiguration());
            //    modelBuilder.ApplyConfiguration(new DetailEntityTypeConfiguration());
            //    modelBuilder.ApplyConfiguration(new EngineEntityTypeConfiguration());
            //    modelBuilder.ApplyConfiguration(new RimsComplectEntityTypeConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
    
    public class CarGameContextDesignFactory : IDesignTimeDbContextFactory<CarGameContext>
    {
        private const string ConnectionStringName = "SqlConnection";
        public CarGameContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();
            var connectionString = configuration.GetConnectionString(ConnectionStringName);
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string '{ConnectionStringName}' is null or empty.", nameof(connectionString));
            }
            var optionsBuilder = new DbContextOptionsBuilder<CarGameContext>()
                .UseSqlServer(connectionString);
            return new CarGameContext(optionsBuilder.Options);
        }
    }
}