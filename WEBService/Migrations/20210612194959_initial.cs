using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WEBService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeteringDevices",
                columns: table => new
                {
                    MeteringDeviceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeteringDevices", x => x.MeteringDeviceId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "SupplyEndpoints",
                columns: table => new
                {
                    SupplyEndPointId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MaxPower = table.Column<float>(type: "real", nullable: false),
                    PointOfUseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyEndpoints", x => x.SupplyEndPointId);
                });

            migrationBuilder.CreateTable(
                name: "Subsidiaries",
                columns: table => new
                {
                    SubsidiaryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidiaries", x => x.SubsidiaryId);
                    table.ForeignKey(
                        name: "FK_Subsidiaries_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointsOfUse",
                columns: table => new
                {
                    PointOfUseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    SubsidiaryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointsOfUse", x => x.PointOfUseId);
                    table.ForeignKey(
                        name: "FK_PointsOfUse_Subsidiaries_SubsidiaryId",
                        column: x => x.SubsidiaryId,
                        principalTable: "Subsidiaries",
                        principalColumn: "SubsidiaryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeasuringPoints",
                columns: table => new
                {
                    ElectricityMeasuringPointId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PointOfUseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeasuringPoints", x => x.ElectricityMeasuringPointId);
                    table.ForeignKey(
                        name: "FK_ElectricityMeasuringPoints_PointsOfUse_PointOfUseId",
                        column: x => x.PointOfUseId,
                        principalTable: "PointsOfUse",
                        principalColumn: "PointOfUseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointOfUseSupplyEndpoint",
                columns: table => new
                {
                    PointsOfUsePointOfUseId = table.Column<int>(type: "integer", nullable: false),
                    SupplyEndpointsSupplyEndPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointOfUseSupplyEndpoint", x => new { x.PointsOfUsePointOfUseId, x.SupplyEndpointsSupplyEndPointId });
                    table.ForeignKey(
                        name: "FK_PointOfUseSupplyEndpoint_PointsOfUse_PointsOfUsePointOfUseId",
                        column: x => x.PointsOfUsePointOfUseId,
                        principalTable: "PointsOfUse",
                        principalColumn: "PointOfUseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PointOfUseSupplyEndpoint_SupplyEndpoints_SupplyEndpointsSup~",
                        column: x => x.SupplyEndpointsSupplyEndPointId,
                        principalTable: "SupplyEndpoints",
                        principalColumn: "SupplyEndPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentTransformers",
                columns: table => new
                {
                    CurrentTransformerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    TransformationRatio = table.Column<float>(type: "real", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TransformerType = table.Column<string>(type: "text", nullable: true),
                    ElectricityMeasuringPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTransformers", x => x.CurrentTransformerId);
                    table.ForeignKey(
                        name: "FK_CurrentTransformers_ElectricityMeasuringPoints_ElectricityM~",
                        column: x => x.ElectricityMeasuringPointId,
                        principalTable: "ElectricityMeasuringPoints",
                        principalColumn: "ElectricityMeasuringPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeasuringPointMeteringDevice",
                columns: table => new
                {
                    ElectricityMeasuringPointsElectricityMeasuringPointId = table.Column<int>(type: "integer", nullable: false),
                    MeteringDevicesMeteringDeviceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeasuringPointMeteringDevice", x => new { x.ElectricityMeasuringPointsElectricityMeasuringPointId, x.MeteringDevicesMeteringDeviceId });
                    table.ForeignKey(
                        name: "FK_ElectricityMeasuringPointMeteringDevice_ElectricityMeasurin~",
                        column: x => x.ElectricityMeasuringPointsElectricityMeasuringPointId,
                        principalTable: "ElectricityMeasuringPoints",
                        principalColumn: "ElectricityMeasuringPointId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricityMeasuringPointMeteringDevice_MeteringDevices_Met~",
                        column: x => x.MeteringDevicesMeteringDeviceId,
                        principalTable: "MeteringDevices",
                        principalColumn: "MeteringDeviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeters",
                columns: table => new
                {
                    ElectricityMeterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    MeterType = table.Column<string>(type: "text", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ElectricityMeasuringPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeters", x => x.ElectricityMeterId);
                    table.ForeignKey(
                        name: "FK_ElectricityMeters_ElectricityMeasuringPoints_ElectricityMea~",
                        column: x => x.ElectricityMeasuringPointId,
                        principalTable: "ElectricityMeasuringPoints",
                        principalColumn: "ElectricityMeasuringPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PotentialTransformers",
                columns: table => new
                {
                    PotentialTransformerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    TransformerType = table.Column<string>(type: "text", nullable: true),
                    CheckDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TransformationRatio = table.Column<float>(type: "real", nullable: false),
                    ElectricityMeasuringPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotentialTransformers", x => x.PotentialTransformerId);
                    table.ForeignKey(
                        name: "FK_PotentialTransformers_ElectricityMeasuringPoints_Electricit~",
                        column: x => x.ElectricityMeasuringPointId,
                        principalTable: "ElectricityMeasuringPoints",
                        principalColumn: "ElectricityMeasuringPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MeteringDevices",
                column: "MeteringDeviceId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "Address", "Name" },
                values: new object[] { 1, "ул. 8 Марта 35", "Parent" });

            migrationBuilder.InsertData(
                table: "SupplyEndpoints",
                columns: new[] { "SupplyEndPointId", "MaxPower", "Name", "PointOfUseId" },
                values: new object[] { 1, 12f, "EndPoint 1", 1 });

            migrationBuilder.InsertData(
                table: "Subsidiaries",
                columns: new[] { "SubsidiaryId", "Address", "Name", "OrganizationId" },
                values: new object[] { 1, "ул. Пушкина 12А", "Child", 1 });

            migrationBuilder.InsertData(
                table: "PointsOfUse",
                columns: new[] { "PointOfUseId", "Address", "Name", "SubsidiaryId" },
                values: new object[] { 1, "ул. Калинина 12", "Consumer", 1 });

            migrationBuilder.InsertData(
                table: "ElectricityMeasuringPoints",
                columns: new[] { "ElectricityMeasuringPointId", "Name", "PointOfUseId" },
                values: new object[] { 1, "Point 1", 1 });

            migrationBuilder.InsertData(
                table: "CurrentTransformers",
                columns: new[] { "CurrentTransformerId", "CheckDate", "ElectricityMeasuringPointId", "Number", "TransformationRatio", "TransformerType" },
                values: new object[] { 1, new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(6945), 1, "12AC", 1.2f, "C1" });

            migrationBuilder.InsertData(
                table: "ElectricityMeters",
                columns: new[] { "ElectricityMeterId", "CheckDate", "ElectricityMeasuringPointId", "MeterType", "Number" },
                values: new object[] { 1, new DateTime(2021, 6, 12, 22, 49, 58, 880, DateTimeKind.Local).AddTicks(8015), 1, "V1", "12AB" });

            migrationBuilder.InsertData(
                table: "PotentialTransformers",
                columns: new[] { "PotentialTransformerId", "CheckDate", "ElectricityMeasuringPointId", "Number", "TransformationRatio", "TransformerType" },
                values: new object[] { 1, new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(8378), 1, "12AD", 1.8f, "P1" });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTransformers_ElectricityMeasuringPointId",
                table: "CurrentTransformers",
                column: "ElectricityMeasuringPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasuringPointMeteringDevice_MeteringDevicesMete~",
                table: "ElectricityMeasuringPointMeteringDevice",
                column: "MeteringDevicesMeteringDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasuringPoints_PointOfUseId",
                table: "ElectricityMeasuringPoints",
                column: "PointOfUseId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeters_ElectricityMeasuringPointId",
                table: "ElectricityMeters",
                column: "ElectricityMeasuringPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PointOfUseSupplyEndpoint_SupplyEndpointsSupplyEndPointId",
                table: "PointOfUseSupplyEndpoint",
                column: "SupplyEndpointsSupplyEndPointId");

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfUse_SubsidiaryId",
                table: "PointsOfUse",
                column: "SubsidiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PotentialTransformers_ElectricityMeasuringPointId",
                table: "PotentialTransformers",
                column: "ElectricityMeasuringPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiaries_OrganizationId",
                table: "Subsidiaries",
                column: "OrganizationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentTransformers");

            migrationBuilder.DropTable(
                name: "ElectricityMeasuringPointMeteringDevice");

            migrationBuilder.DropTable(
                name: "ElectricityMeters");

            migrationBuilder.DropTable(
                name: "PointOfUseSupplyEndpoint");

            migrationBuilder.DropTable(
                name: "PotentialTransformers");

            migrationBuilder.DropTable(
                name: "MeteringDevices");

            migrationBuilder.DropTable(
                name: "SupplyEndpoints");

            migrationBuilder.DropTable(
                name: "ElectricityMeasuringPoints");

            migrationBuilder.DropTable(
                name: "PointsOfUse");

            migrationBuilder.DropTable(
                name: "Subsidiaries");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
