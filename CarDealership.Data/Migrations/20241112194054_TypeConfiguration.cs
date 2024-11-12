using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class TypeConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e0b632a-cc24-4177-bc66-079b0e725162"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("5128f791-3ec5-415e-bc9a-123e466869e3"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("670741c1-51a2-446b-89d4-b9434db570cf"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b9d5a0d-27a7-4fd1-a7ed-c647958dc32b"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("6f578eed-145b-4a74-8a56-51fdf91581aa"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("81659da7-9f7c-46dd-acb9-a0019e9ec0d4"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9a077a6-65ae-4a75-ba45-21708ed191e3"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e628f646-d267-4e13-8380-528ffeb2ce43"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "VehiclesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e0b632a-cc24-4177-bc66-079b0e725162"), "Ван" },
                    { new Guid("5128f791-3ec5-415e-bc9a-123e466869e3"), "Хечбег" },
                    { new Guid("670741c1-51a2-446b-89d4-b9434db570cf"), "Седан" },
                    { new Guid("6b9d5a0d-27a7-4fd1-a7ed-c647958dc32b"), "Комби" },
                    { new Guid("6f578eed-145b-4a74-8a56-51fdf91581aa"), "Кабрио" },
                    { new Guid("81659da7-9f7c-46dd-acb9-a0019e9ec0d4"), "Джип" },
                    { new Guid("a9a077a6-65ae-4a75-ba45-21708ed191e3"), "Пикап" },
                    { new Guid("e628f646-d267-4e13-8380-528ffeb2ce43"), "Купе" }
                });
        }
    }
}
