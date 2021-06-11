using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBService.Models
{
    public class WebServiceDBContext : DbContext
    {
        public WebServiceDBContext(DbContextOptions<WebServiceDBContext> options):base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<CurrentTransformer> CurrentTransformers { get; set; }
        public DbSet<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }
        public DbSet<ELectricityMeter> ELectricityMeters { get; set; }
        public DbSet<MeteringDevice> MeteringDevices { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PointOfUse> PointsOfUse { get; set; }
        public DbSet<PotentialTransformer> PotentialTransformers { get; set; }
        public DbSet<Subsidiary> Subsidiaries { get; set; }
        public DbSet<SupplyEndpoint> SupplyEndpoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"Server=localhost;User Id = postgres; Password=25647;Port=5432;Database=WebServiceDb");
        }
        
    }
}
