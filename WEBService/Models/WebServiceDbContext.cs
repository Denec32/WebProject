using Microsoft.EntityFrameworkCore;
using System;

namespace WEBService.Models
{
    public class WebServiceDBContext : DbContext
    {
        public WebServiceDBContext()
        {
            Database.EnsureDeleted();
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
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres; Password=25647;Port=5432;Database=projectdb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Organization>().HasData(
                new Organization[]
                {
                    new Organization { 
                        OrganizationId = 1, 
                        Name = "Parent", Address = "ул. 8 Марта 35"}
                });

            modelBuilder.Entity<Subsidiary>().HasData(
                new Subsidiary[]
                {
                    new Subsidiary{ 
                        SubsidiaryId = 1, 
                        OrganizationId = 1, 
                        Name = "Child", Address = "ул. Пушкина 12А" 
                    }
                });

            modelBuilder.Entity<PointOfUse>().HasData(
                new PointOfUse[]
                {
                    new PointOfUse{
                        PointOfUseId = 1,
                        SubsidiaryId = 1,
                        Address = "ул. Калинина 12", Name = "Consumer",
                    }
                });
            modelBuilder.Entity<ElectricityMeasuringPoint>().HasData(
                new ElectricityMeasuringPoint[]
                {
                    new ElectricityMeasuringPoint{ 
                        ElectricityMeasuringPointId = 1,
                        Name = "Point 1", PointOfUseId = 1 
                    }
                });
            
            modelBuilder.Entity<ELectricityMeter>().HasData(
                new ELectricityMeter[]
                {
                    new ELectricityMeter{
                        ELectricityMeterId = 1, 
                        ElectricityMeasuringPointId = 1,
                        Number = "12AB", CheckDate = DateTime.Now, MeterType = "V1" 
                    }
                });

            modelBuilder.Entity<CurrentTransformer>().HasData(
                new CurrentTransformer[]
                {
                    new CurrentTransformer{ 
                        CurrentTransformerId = 1,
                        ElectricityMeasuringPointId = 1,
                        Number = "12AC", CheckDate = DateTime.Now, TransformerType = "C1", TransformationRatio = 1.2f
                    }
                });
            
            modelBuilder.Entity<PotentialTransformer>().HasData(
                new PotentialTransformer[]
                {
                    new PotentialTransformer{
                        PotentialTransformerId = 1,
                        ElectricityMeasuringPointId = 1,
                        Number = "12AD", CheckDate = DateTime.Now, TransformerType = "P1", TransformationRatio = 1.8f,
                    }
                });
            
            modelBuilder.Entity<SupplyEndpoint>().HasData(
                new SupplyEndpoint[]
                {
                    new SupplyEndpoint{
                        SupplyEndPointId = 1,
                        PointOfUseId = 1,
                        Name = "EndPoint 1", MaxPower = 12,
                    }
                });

            modelBuilder.Entity<MeteringDevice>().HasData(
                new MeteringDevice[]
                {
                    new MeteringDevice{ 
                        MeteringDeviceId = 1
                    }
                });
        }
    }
}
