using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class LocationConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("171893b6-d014-48ce-95a6-1acb1e5cc6a9"), "Плевен" },
                    { new Guid("452a22f0-1f19-47a7-ba17-e70862761d6b"), "София" },
                    { new Guid("ccfd06a9-5d1c-4819-b497-bdd32facd946"), "Варна" },
                    { new Guid("d0d3a9c7-0dd2-41b8-8a53-11c206259142"), "Бургас" },
                    { new Guid("e003cb0d-1a35-4a6c-95f8-4af614928be6"), "Пловдив" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("265fca3d-4e9c-45b9-a66b-44ed76c69f0a"), "Седан" },
                    { new Guid("56939a4a-9081-48a9-8568-603a710a755f"), "Джип" },
                    { new Guid("5736552f-c0ef-4a59-874b-d90ff197065f"), "Комби" },
                    { new Guid("77d1e752-ffd7-4474-acdc-24b9dcadabaa"), "Хечбег" },
                    { new Guid("c65547ba-932c-4867-933c-04d39b6f9b67"), "Пикап" },
                    { new Guid("ccd6db7a-6190-4b5c-887a-613765548159"), "Кабрио" },
                    { new Guid("daae2da8-a192-4d1b-9ad2-4c8ccae60650"), "Купе" },
                    { new Guid("eb337c1a-614c-4ac5-ac3a-33f7be909c6e"), "Ван" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesPurposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6376f8ad-730e-453a-a8a7-6702d89b1827"), "Компактен" },
                    { new Guid("765ee250-2a71-46f0-92a0-135f7f8caa2f"), "Стандартен" },
                    { new Guid("822f450a-43f1-4b38-8b58-e0b7c8ab7194"), "Стандартен Комби" },
                    { new Guid("8a4593a5-db68-4e60-9d7e-716eecf3dc90"), "Луксозен" },
                    { new Guid("a23d0fcf-4a84-4383-89a7-21340af222bc"), "Голям" },
                    { new Guid("e56797a6-246f-436c-9b85-3da6bffa35c6"), "Икономичен Комби" },
                    { new Guid("f0f6ec4c-c32b-4c78-9432-879540de5115"), "Икономичен" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20e98c5a-670a-4215-bbec-611cc9c92aed"), "Камион" },
                    { new Guid("32043b08-143b-413c-a8cb-77a9eb4ba334"), "Бус" },
                    { new Guid("f540f085-8856-40c0-bd20-e9a75eda7b04"), "Автомобил" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("171893b6-d014-48ce-95a6-1acb1e5cc6a9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("452a22f0-1f19-47a7-ba17-e70862761d6b"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ccfd06a9-5d1c-4819-b497-bdd32facd946"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d0d3a9c7-0dd2-41b8-8a53-11c206259142"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e003cb0d-1a35-4a6c-95f8-4af614928be6"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("265fca3d-4e9c-45b9-a66b-44ed76c69f0a"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("56939a4a-9081-48a9-8568-603a710a755f"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("5736552f-c0ef-4a59-874b-d90ff197065f"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("77d1e752-ffd7-4474-acdc-24b9dcadabaa"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("c65547ba-932c-4867-933c-04d39b6f9b67"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccd6db7a-6190-4b5c-887a-613765548159"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("daae2da8-a192-4d1b-9ad2-4c8ccae60650"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("eb337c1a-614c-4ac5-ac3a-33f7be909c6e"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("6376f8ad-730e-453a-a8a7-6702d89b1827"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("765ee250-2a71-46f0-92a0-135f7f8caa2f"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("822f450a-43f1-4b38-8b58-e0b7c8ab7194"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("8a4593a5-db68-4e60-9d7e-716eecf3dc90"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("a23d0fcf-4a84-4383-89a7-21340af222bc"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("e56797a6-246f-436c-9b85-3da6bffa35c6"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("f0f6ec4c-c32b-4c78-9432-879540de5115"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("20e98c5a-670a-4215-bbec-611cc9c92aed"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("32043b08-143b-413c-a8cb-77a9eb4ba334"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("f540f085-8856-40c0-bd20-e9a75eda7b04"));

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
    }
}
