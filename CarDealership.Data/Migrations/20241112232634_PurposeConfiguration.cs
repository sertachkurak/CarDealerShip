using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class PurposeConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("2696c67b-4d57-4883-9df8-7952f4c24c98"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("44e1d2c3-ef42-4e0d-b573-9ac5bfa5b3ee"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("6afd9ec0-d5a6-410b-b4e4-356fe14f03de"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ef0d5c1-824e-4b10-bc45-502e11e1909f"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("84ab0342-0eb7-4862-b6d7-cf8f861d26a5"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d8c184f-2436-4927-92a9-446ef80d4b3c"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("c78ec9e0-3524-437c-a21a-477443ba6752"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5930b60-508b-45cb-9002-8e830030a90f"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("78301bf0-a381-4a02-8081-253fc8c5fe81"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("bbf14558-41b8-4124-bda2-163963dbb6af"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("e39d4209-3544-46e5-9a7b-bd648aba647b"));

            migrationBuilder.InsertData(
                table: "VehiclesPurposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f455a4e-6194-4d9b-9c2d-5b68bc88b9c8"), "Компактен" },
                    { new Guid("340330ff-e480-4204-b1ba-8a6788e4052e"), "Икономичен Комби" },
                    { new Guid("46f0224e-b70c-4ea1-bf28-28d3cc904a46"), "Стандартен Комби" },
                    { new Guid("8f6520ca-6154-48e1-a18f-73998c492cd3"), "Икономичен" },
                    { new Guid("c209318d-3673-4604-acf3-95ff160f846f"), "Голям" },
                    { new Guid("e8948072-e9c1-44ad-afd0-52dbb59f38a8"), "Луксозен" },
                    { new Guid("fc6ee428-18c4-4835-ad41-986bf68cbab6"), "Стандартен" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("1f455a4e-6194-4d9b-9c2d-5b68bc88b9c8"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("340330ff-e480-4204-b1ba-8a6788e4052e"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("46f0224e-b70c-4ea1-bf28-28d3cc904a46"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("8f6520ca-6154-48e1-a18f-73998c492cd3"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("c209318d-3673-4604-acf3-95ff160f846f"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("e8948072-e9c1-44ad-afd0-52dbb59f38a8"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("fc6ee428-18c4-4835-ad41-986bf68cbab6"));

            migrationBuilder.InsertData(
                table: "VehiclesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2696c67b-4d57-4883-9df8-7952f4c24c98"), "Купе" },
                    { new Guid("44e1d2c3-ef42-4e0d-b573-9ac5bfa5b3ee"), "Джип" },
                    { new Guid("6afd9ec0-d5a6-410b-b4e4-356fe14f03de"), "Пикап" },
                    { new Guid("7ef0d5c1-824e-4b10-bc45-502e11e1909f"), "Кабрио" },
                    { new Guid("84ab0342-0eb7-4862-b6d7-cf8f861d26a5"), "Ван" },
                    { new Guid("8d8c184f-2436-4927-92a9-446ef80d4b3c"), "Хечбег" },
                    { new Guid("c78ec9e0-3524-437c-a21a-477443ba6752"), "Комби" },
                    { new Guid("e5930b60-508b-45cb-9002-8e830030a90f"), "Седан" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("78301bf0-a381-4a02-8081-253fc8c5fe81"), "Автомобил" },
                    { new Guid("bbf14558-41b8-4124-bda2-163963dbb6af"), "Бус" },
                    { new Guid("e39d4209-3544-46e5-9a7b-bd648aba647b"), "Камион" }
                });
        }
    }
}
