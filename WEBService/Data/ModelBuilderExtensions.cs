using Microsoft.EntityFrameworkCore;
using System;
using WEBService.Models;

namespace WEBService.Data
{
    public static class ModelBuilderExtensions
    {
        public static void AddData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().HasData(
                new Organization
                {
                    ID = 1,
                    Name = "Parent",
                    Address = "ул. 8 Марта 35"
                });

            modelBuilder.Entity<Subsidiary>().HasData(
                new Subsidiary
                {
                    ID = 1,
                    OrganizationId = 1,
                    Name = "Child",
                    Address = "ул. Пушкина 12А"
                });

            modelBuilder.Entity<PointOfUse>().HasData(
                new PointOfUse
                {
                    ID = 1,
                    SubsidiaryId = 1,
                    Address = "ул. Калинина 12",
                    Name = "Consumer",
                });
            modelBuilder.Entity<ElectricityMeasuringPoint>().HasData(
                new ElectricityMeasuringPoint
                {
                    ID = 1,
                    Name = "Point 1",
                    PointOfUseId = 1
                });

            modelBuilder.Entity<ElectricityMeter>().HasData(
                new ElectricityMeter
                {
                    ID = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AB",
                    CheckDate = DateTime.Now,
                    MeterType = "V1"
                });

            modelBuilder.Entity<CurrentTransformer>().HasData(
                new CurrentTransformer
                {
                    ID = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AC",
                    CheckDate = DateTime.Now,
                    TransformerType = "C1",
                    TransformationRatio = 1.2
                });

            modelBuilder.Entity<PotentialTransformer>().HasData(
                new PotentialTransformer
                {
                    ID = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AD",
                    CheckDate = DateTime.Now,
                    TransformerType = "P1",
                    TransformationRatio = 1.8
                });

            modelBuilder.Entity<SupplyEndpoint>().HasData(
                new SupplyEndpoint
                {
                    ID = 1,
                    PointOfUseId = 1,
                    Name = "EndPoint 1",
                    MaxPower = 12
                });

            modelBuilder.Entity<MeteringDevice>().HasData(
                new MeteringDevice
                {
                    ID = 1
                });

        }
    }
}
