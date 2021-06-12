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
                    OrganizationId = 1,
                    Name = "Parent",
                    Address = "ул. 8 Марта 35"
                });

            modelBuilder.Entity<Subsidiary>().HasData(
                new Subsidiary
                {
                    SubsidiaryId = 1,
                    OrganizationId = 1,
                    Name = "Child",
                    Address = "ул. Пушкина 12А"
                });

            modelBuilder.Entity<PointOfUse>().HasData(
                new PointOfUse
                {
                    PointOfUseId = 1,
                    SubsidiaryId = 1,
                    Address = "ул. Калинина 12",
                    Name = "Consumer",
                });
            modelBuilder.Entity<ElectricityMeasuringPoint>().HasData(
                new ElectricityMeasuringPoint
                {
                    ElectricityMeasuringPointId = 1,
                    Name = "Point 1",
                    PointOfUseId = 1
                });

            modelBuilder.Entity<ElectricityMeter>().HasData(
                new ElectricityMeter
                {
                    ElectricityMeterId = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AB",
                    CheckDate = DateTime.Now,
                    MeterType = "V1"
                });

            modelBuilder.Entity<CurrentTransformer>().HasData(
                new CurrentTransformer
                {
                    CurrentTransformerId = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AC",
                    CheckDate = DateTime.Now,
                    TransformerType = "C1",
                    TransformationRatio = 1.2f
                });

            modelBuilder.Entity<PotentialTransformer>().HasData(
                new PotentialTransformer
                {
                    PotentialTransformerId = 1,
                    ElectricityMeasuringPointId = 1,
                    Number = "12AD",
                    CheckDate = DateTime.Now,
                    TransformerType = "P1",
                    TransformationRatio = 1.8f,
                });

            modelBuilder.Entity<SupplyEndpoint>().HasData(
                new SupplyEndpoint
                {
                    SupplyEndPointId = 1,
                    PointOfUseId = 1,
                    Name = "EndPoint 1",
                    MaxPower = 12,
                });

            modelBuilder.Entity<MeteringDevice>().HasData(
                new MeteringDevice
                {
                    MeteringDeviceId = 1
                });

        }
    }
}
