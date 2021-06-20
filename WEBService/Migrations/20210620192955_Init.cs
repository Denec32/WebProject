using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBService.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentTransformers_ElectricityMeasuringPoints_ElectricityM~",
                table: "CurrentTransformers");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityMeasuringPoints_PointsOfUse_PointOfUseId",
                table: "ElectricityMeasuringPoints");

            migrationBuilder.DropForeignKey(
                name: "FK_ElectricityMeters_ElectricityMeasuringPoints_ElectricityMea~",
                table: "ElectricityMeters");

            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfUse_Subsidiaries_SubsidiaryId",
                table: "PointsOfUse");

            migrationBuilder.DropForeignKey(
                name: "FK_PotentialTransformers_ElectricityMeasuringPoints_Electricit~",
                table: "PotentialTransformers");

            migrationBuilder.DropForeignKey(
                name: "FK_Subsidiaries_Organizations_OrganizationId",
                table: "Subsidiaries");

            migrationBuilder.DropTable(
                name: "ElectricityMeasuringPointMeteringDevice");

            migrationBuilder.DropTable(
                name: "PointOfUseSupplyEndpoint");

            migrationBuilder.DropIndex(
                name: "IX_Subsidiaries_OrganizationId",
                table: "Subsidiaries");

            migrationBuilder.DropIndex(
                name: "IX_PotentialTransformers_ElectricityMeasuringPointId",
                table: "PotentialTransformers");

            migrationBuilder.DropIndex(
                name: "IX_PointsOfUse_SubsidiaryId",
                table: "PointsOfUse");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityMeters_ElectricityMeasuringPointId",
                table: "ElectricityMeters");

            migrationBuilder.DropIndex(
                name: "IX_ElectricityMeasuringPoints_PointOfUseId",
                table: "ElectricityMeasuringPoints");

            migrationBuilder.DropIndex(
                name: "IX_CurrentTransformers_ElectricityMeasuringPointId",
                table: "CurrentTransformers");

            migrationBuilder.RenameColumn(
                name: "SupplyEndPointId",
                table: "SupplyEndpoints",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SubsidiaryId",
                table: "Subsidiaries",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PotentialTransformerId",
                table: "PotentialTransformers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PointOfUseId",
                table: "PointsOfUse",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "Organizations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MeteringDeviceId",
                table: "MeteringDevices",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ElectricityMeterId",
                table: "ElectricityMeters",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ElectricityMeasuringPointId",
                table: "ElectricityMeasuringPoints",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CurrentTransformerId",
                table: "CurrentTransformers",
                newName: "ID");

            migrationBuilder.AlterColumn<double>(
                name: "TransformationRatio",
                table: "PotentialTransformers",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "TransformationRatio",
                table: "CurrentTransformers",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "CurrentTransformers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckDate", "TransformationRatio" },
                values: new object[] { new DateTime(2021, 6, 20, 22, 29, 54, 426, DateTimeKind.Local).AddTicks(2164), 1.2 });

            migrationBuilder.UpdateData(
                table: "ElectricityMeters",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckDate",
                value: new DateTime(2021, 6, 20, 22, 29, 54, 425, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "PotentialTransformers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CheckDate", "TransformationRatio" },
                values: new object[] { new DateTime(2021, 6, 20, 22, 29, 54, 426, DateTimeKind.Local).AddTicks(3657), 1.8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SupplyEndpoints",
                newName: "SupplyEndPointId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Subsidiaries",
                newName: "SubsidiaryId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PotentialTransformers",
                newName: "PotentialTransformerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PointsOfUse",
                newName: "PointOfUseId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Organizations",
                newName: "OrganizationId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MeteringDevices",
                newName: "MeteringDeviceId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ElectricityMeters",
                newName: "ElectricityMeterId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ElectricityMeasuringPoints",
                newName: "ElectricityMeasuringPointId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CurrentTransformers",
                newName: "CurrentTransformerId");

            migrationBuilder.AlterColumn<float>(
                name: "TransformationRatio",
                table: "PotentialTransformers",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<float>(
                name: "TransformationRatio",
                table: "CurrentTransformers",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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

            migrationBuilder.UpdateData(
                table: "CurrentTransformers",
                keyColumn: "CurrentTransformerId",
                keyValue: 1,
                columns: new[] { "CheckDate", "TransformationRatio" },
                values: new object[] { new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(6945), 1.2f });

            migrationBuilder.UpdateData(
                table: "ElectricityMeters",
                keyColumn: "ElectricityMeterId",
                keyValue: 1,
                column: "CheckDate",
                value: new DateTime(2021, 6, 12, 22, 49, 58, 880, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "PotentialTransformers",
                keyColumn: "PotentialTransformerId",
                keyValue: 1,
                columns: new[] { "CheckDate", "TransformationRatio" },
                values: new object[] { new DateTime(2021, 6, 12, 22, 49, 58, 881, DateTimeKind.Local).AddTicks(8378), 1.8f });

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiaries_OrganizationId",
                table: "Subsidiaries",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PotentialTransformers_ElectricityMeasuringPointId",
                table: "PotentialTransformers",
                column: "ElectricityMeasuringPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfUse_SubsidiaryId",
                table: "PointsOfUse",
                column: "SubsidiaryId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeters_ElectricityMeasuringPointId",
                table: "ElectricityMeters",
                column: "ElectricityMeasuringPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasuringPoints_PointOfUseId",
                table: "ElectricityMeasuringPoints",
                column: "PointOfUseId");

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
                name: "IX_PointOfUseSupplyEndpoint_SupplyEndpointsSupplyEndPointId",
                table: "PointOfUseSupplyEndpoint",
                column: "SupplyEndpointsSupplyEndPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentTransformers_ElectricityMeasuringPoints_ElectricityM~",
                table: "CurrentTransformers",
                column: "ElectricityMeasuringPointId",
                principalTable: "ElectricityMeasuringPoints",
                principalColumn: "ElectricityMeasuringPointId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityMeasuringPoints_PointsOfUse_PointOfUseId",
                table: "ElectricityMeasuringPoints",
                column: "PointOfUseId",
                principalTable: "PointsOfUse",
                principalColumn: "PointOfUseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ElectricityMeters_ElectricityMeasuringPoints_ElectricityMea~",
                table: "ElectricityMeters",
                column: "ElectricityMeasuringPointId",
                principalTable: "ElectricityMeasuringPoints",
                principalColumn: "ElectricityMeasuringPointId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfUse_Subsidiaries_SubsidiaryId",
                table: "PointsOfUse",
                column: "SubsidiaryId",
                principalTable: "Subsidiaries",
                principalColumn: "SubsidiaryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PotentialTransformers_ElectricityMeasuringPoints_Electricit~",
                table: "PotentialTransformers",
                column: "ElectricityMeasuringPointId",
                principalTable: "ElectricityMeasuringPoints",
                principalColumn: "ElectricityMeasuringPointId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subsidiaries_Organizations_OrganizationId",
                table: "Subsidiaries",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
