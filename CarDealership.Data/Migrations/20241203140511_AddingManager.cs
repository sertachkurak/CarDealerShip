using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserVehicle_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserVehicle_Vehicles_VehicleId",
                table: "ApplicationUserVehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserVehicle",
                table: "ApplicationUserVehicle");

            migrationBuilder.RenameTable(
                name: "ApplicationUserVehicle",
                newName: "UsersVehicles");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserVehicle_VehicleId",
                table: "UsersVehicles",
                newName: "IX_UsersVehicles_VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersVehicles",
                table: "UsersVehicles",
                columns: new[] { "ApplicationUserId", "VehicleId" });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersVehicles_AspNetUsers_ApplicationUserId",
                table: "UsersVehicles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersVehicles_Vehicles_VehicleId",
                table: "UsersVehicles",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserVehicle_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserVehicle",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserVehicle_Vehicles_VehicleId",
                table: "ApplicationUserVehicle",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
