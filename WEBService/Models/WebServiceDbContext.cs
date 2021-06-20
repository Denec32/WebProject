using Microsoft.EntityFrameworkCore;
using System;
using WEBService.Data;

namespace WEBService.Models
{
    public class WebServiceDBContext : DbContext
    {
        public WebServiceDBContext()
        {

        }

        public DbSet<CurrentTransformer> CurrentTransformers { get; set; }
        public DbSet<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }
        public DbSet<ElectricityMeter> ElectricityMeters { get; set; }
        public DbSet<MeteringDevice> MeteringDevices { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PointOfUse> PointsOfUse { get; set; }
        public DbSet<PotentialTransformer> PotentialTransformers { get; set; }
        public DbSet<Subsidiary> Subsidiaries { get; set; }
        public DbSet<SupplyEndpoint> SupplyEndpoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres; Password=25647;Port=5432;Database=PowerSupplyCompany");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddData();
        }
    }
}
