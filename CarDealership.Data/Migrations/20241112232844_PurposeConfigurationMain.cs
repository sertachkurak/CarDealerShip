using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class PurposeConfigurationMain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0477079b-9fcb-488c-82fa-903982cad7ab"), "Хечбег" },
                    { new Guid("3cec4a6e-ad30-4172-a82f-352f3d58cae9"), "Пикап" },
                    { new Guid("6212c089-8132-4b41-8d77-3316d8f9eed1"), "Седан" },
                    { new Guid("7122e511-b465-4368-b314-0bc022645836"), "Кабрио" },
                    { new Guid("7215cb33-eee4-4c94-87e6-2a9d644030e1"), "Джип" },
                    { new Guid("80538dc9-3a30-453c-bdf6-d92e9ad2d293"), "Комби" },
                    { new Guid("987ef0e6-11a8-4699-bec3-adbe81ae9cbe"), "Купе" },
                    { new Guid("e43f56f0-295b-4060-bfa0-ec479fc5f598"), "Ван" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesPurposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("374654e1-9c79-4b5e-955f-72d339ad3d3e"), "Икономичен Комби" },
                    { new Guid("54d44ac7-f83a-46e3-9ab3-3dd4d3a63532"), "Стандартен" },
                    { new Guid("7d2a79f6-2210-46e4-82be-7b6c43242418"), "Голям" },
                    { new Guid("b4fb0c28-ead9-45e0-97cb-5acfa837e61e"), "Компактен" },
                    { new Guid("c790dfd0-3913-4128-8e2c-37b2e9781b0b"), "Луксозен" },
                    { new Guid("cca4a00d-b6a9-4795-9289-2e0e5703288e"), "Икономичен" },
                    { new Guid("d43c6dca-af92-414a-aeab-74b889e18e67"), "Стандартен Комби" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("519959da-e51d-4467-88d7-36da7055019f"), "Бус" },
                    { new Guid("945139c5-da5f-47eb-8b22-e86d2b9c1363"), "Камион" },
                    { new Guid("b7c4cebd-60a4-4be7-a300-7512d920b279"), "Автомобил" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("0477079b-9fcb-488c-82fa-903982cad7ab"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("3cec4a6e-ad30-4172-a82f-352f3d58cae9"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("6212c089-8132-4b41-8d77-3316d8f9eed1"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("7122e511-b465-4368-b314-0bc022645836"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("7215cb33-eee4-4c94-87e6-2a9d644030e1"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("80538dc9-3a30-453c-bdf6-d92e9ad2d293"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("987ef0e6-11a8-4699-bec3-adbe81ae9cbe"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e43f56f0-295b-4060-bfa0-ec479fc5f598"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("374654e1-9c79-4b5e-955f-72d339ad3d3e"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("54d44ac7-f83a-46e3-9ab3-3dd4d3a63532"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("7d2a79f6-2210-46e4-82be-7b6c43242418"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("b4fb0c28-ead9-45e0-97cb-5acfa837e61e"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("c790dfd0-3913-4128-8e2c-37b2e9781b0b"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("cca4a00d-b6a9-4795-9289-2e0e5703288e"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("d43c6dca-af92-414a-aeab-74b889e18e67"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("519959da-e51d-4467-88d7-36da7055019f"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("945139c5-da5f-47eb-8b22-e86d2b9c1363"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7c4cebd-60a4-4be7-a300-7512d920b279"));

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
    }
}
