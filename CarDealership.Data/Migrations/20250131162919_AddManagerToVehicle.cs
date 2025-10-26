using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddManagerToVehicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("160b8bc3-fa53-489d-84d4-b46b02863a91"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("44fc94c2-b239-417a-944e-6f8b8d87e4d2"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b02108ee-ff61-434a-8aa3-8e2ac61bbca1"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d35eacf2-b1d0-46bf-8cd1-21eb134c4b2b"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("dac01ffe-e539-4dac-9f74-1c7a177cc562"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("2dbd3991-701f-4786-8ce5-4c1a80175ea4"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("4d5bd88e-2c03-4e51-889c-72be9808843a"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("956175a8-ed80-4baf-b11b-cc8a8e0607f0"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("ad9e126e-a378-4dde-a93b-6576aa826a33"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc285879-063b-42d9-8f22-0a660c65589e"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e3f7ab9d-955d-4722-b5a4-5de3c6aac3df"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e549d0c4-3d4b-4f50-800e-d3ecf74004b8"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e6416c89-8797-43ad-83cf-0edfe89d8ece"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7479c56-2d1c-440e-b1d3-a8293a2735b9"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4c537c8-9453-4a6a-a7b6-4d9be75d45d7"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("334d022f-38c8-47ac-bc55-74f094aa507f"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("4112f874-b641-4f78-bd69-9f07293a4fe6"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("5c2fb52f-c511-4e54-aa8e-9ed7d44a7a98"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("63659075-78b0-4936-bb74-685c82aba31a"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("6a9b73ee-1f6b-4fe8-9436-5ac89dbafcb7"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("8c0c25dd-50e0-4c8d-b48d-38243617ff70"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("ebfef40b-1104-4113-870c-182818f7ce87"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("091c3f68-7b64-4df8-a595-753f1bb854dc"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("cc7ce3ee-564a-4cec-983f-2ae6e2050af2"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("de45d1fd-c8c6-4b77-9900-959f1533516b"));

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4742b1f7-9b0b-4142-9739-d12cf74673d2"), "Плевен" },
                    { new Guid("cae012db-fd18-4b0d-8750-57e2f24ac492"), "Варна" },
                    { new Guid("ce6fbdef-f502-4c38-88b8-e5b136a11ce6"), "Бургас" },
                    { new Guid("de461496-2645-4629-8dd8-d683ac100d8c"), "София" },
                    { new Guid("f0ed5de5-7df3-4cd6-8f41-dd23bbf9e89f"), "Пловдив" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("07a52dd4-ba04-448d-80b9-0730a0716a24"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("09ce8f2c-f974-4e36-8093-ce3aa7376cf2"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("194ae085-cc33-46c6-923e-c44a5e14d4df"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("204e50c5-56b3-492d-bdcb-e0f4e7cc3e93"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3c3f2cb0-fb06-4616-8396-3aad20b6d7a6"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3ccb56a9-4a35-4221-be4c-a8757d297461"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3cf850a3-2278-4a70-af61-157bc9e9f69a"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5149fb0c-d53e-4ecc-bea2-9d005edbbdd4"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("5b0ddfa3-1bef-4993-a879-f643a34d374b"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("60b708ce-d98a-4c51-a39a-05a50fddf989"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("6c57e66b-4ad8-445c-ba76-1408b86ad7fb"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("98f82568-0fe5-4e75-87e1-c5688fe42860"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("99ec8db1-b331-452c-a22e-1cb72d05379f"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a80bdd96-7a9e-49c1-be7b-bd7a371051ed"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("a89b2858-ea73-4338-8e02-18d01ae2b008"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("adac99fc-a75f-4af4-9f1e-3570d67e6017"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("c42c760d-0e3e-4194-a88e-7318a084faab"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("d3c87fc7-8f2e-4385-88cf-750802a00157"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f2d53339-77a9-4d2a-a1bd-bd7ab0e07e26"),
                column: "ManagerId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "VehiclesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2acf8ea0-dccd-4053-a953-fa3f079ef1d5"), "Седан" },
                    { new Guid("2bcc7bbc-131b-48b2-98c9-5603998d66f2"), "Ван" },
                    { new Guid("39928415-72e4-437c-beef-59685f4ab888"), "Хечбег" },
                    { new Guid("5d49e678-5b7d-4c4e-9d71-6eff3543d9e7"), "Пикап" },
                    { new Guid("7ca5bb7f-32be-4266-a44f-d8ec4bc5a3e5"), "Комби" },
                    { new Guid("82a2a87a-d35e-4a01-91ee-a43e47e6b5f0"), "Кабрио" },
                    { new Guid("ac759d30-c500-4d07-b164-0c063a567e6f"), "Бус" },
                    { new Guid("e7b8e32b-8b6a-4439-a4c7-2be85ae0d0c2"), "Камион" },
                    { new Guid("e90aecf4-ee6b-4f66-8a6e-d6f5c78a8490"), "Джип" },
                    { new Guid("ed15dcf4-f645-489b-97ef-ddead8ea8a8a"), "Купе" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesPurposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("072b2025-af4f-49c6-bcee-6ce604814c81"), "Компактен" },
                    { new Guid("147623ed-9525-4a9d-aa26-08329cc5e7a8"), "Луксозен" },
                    { new Guid("2b4534b3-fe3c-4b88-8eae-2c2e0a05000b"), "Стандартен Комби" },
                    { new Guid("6e978a5c-7679-461b-982f-aa73474a953c"), "Стандартен" },
                    { new Guid("aeb86b01-0d1d-4b60-9f63-2d344502e711"), "Голям" },
                    { new Guid("da75a8c7-8517-48c9-b93b-377a611df030"), "Икономичен" },
                    { new Guid("df094c62-499e-483b-bde0-fd43c358d815"), "Икономичен Комби" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9083a913-dfb3-4912-8399-e64e5f98912a"), "Бус" },
                    { new Guid("b8811545-8496-4dac-88e6-b0c3a2f721f8"), "Автомобил" },
                    { new Guid("be55498a-f2ac-41d8-9205-48cbb94bc8d2"), "Камион" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ManagerId",
                table: "Vehicles",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Managers_ManagerId",
                table: "Vehicles",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Managers_ManagerId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ManagerId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("4742b1f7-9b0b-4142-9739-d12cf74673d2"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("cae012db-fd18-4b0d-8750-57e2f24ac492"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ce6fbdef-f502-4c38-88b8-e5b136a11ce6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("de461496-2645-4629-8dd8-d683ac100d8c"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f0ed5de5-7df3-4cd6-8f41-dd23bbf9e89f"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("2acf8ea0-dccd-4053-a953-fa3f079ef1d5"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("2bcc7bbc-131b-48b2-98c9-5603998d66f2"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("39928415-72e4-437c-beef-59685f4ab888"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d49e678-5b7d-4c4e-9d71-6eff3543d9e7"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("7ca5bb7f-32be-4266-a44f-d8ec4bc5a3e5"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("82a2a87a-d35e-4a01-91ee-a43e47e6b5f0"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("ac759d30-c500-4d07-b164-0c063a567e6f"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7b8e32b-8b6a-4439-a4c7-2be85ae0d0c2"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("e90aecf4-ee6b-4f66-8a6e-d6f5c78a8490"));

            migrationBuilder.DeleteData(
                table: "VehiclesCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed15dcf4-f645-489b-97ef-ddead8ea8a8a"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("072b2025-af4f-49c6-bcee-6ce604814c81"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("147623ed-9525-4a9d-aa26-08329cc5e7a8"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("2b4534b3-fe3c-4b88-8eae-2c2e0a05000b"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("6e978a5c-7679-461b-982f-aa73474a953c"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("aeb86b01-0d1d-4b60-9f63-2d344502e711"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("da75a8c7-8517-48c9-b93b-377a611df030"));

            migrationBuilder.DeleteData(
                table: "VehiclesPurposes",
                keyColumn: "Id",
                keyValue: new Guid("df094c62-499e-483b-bde0-fd43c358d815"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("9083a913-dfb3-4912-8399-e64e5f98912a"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("b8811545-8496-4dac-88e6-b0c3a2f721f8"));

            migrationBuilder.DeleteData(
                table: "VehiclesTypes",
                keyColumn: "Id",
                keyValue: new Guid("be55498a-f2ac-41d8-9205-48cbb94bc8d2"));

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Vehicles");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("160b8bc3-fa53-489d-84d4-b46b02863a91"), "Плевен" },
                    { new Guid("44fc94c2-b239-417a-944e-6f8b8d87e4d2"), "София" },
                    { new Guid("b02108ee-ff61-434a-8aa3-8e2ac61bbca1"), "Пловдив" },
                    { new Guid("d35eacf2-b1d0-46bf-8cd1-21eb134c4b2b"), "Варна" },
                    { new Guid("dac01ffe-e539-4dac-9f74-1c7a177cc562"), "Бургас" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2dbd3991-701f-4786-8ce5-4c1a80175ea4"), "Купе" },
                    { new Guid("4d5bd88e-2c03-4e51-889c-72be9808843a"), "Пикап" },
                    { new Guid("956175a8-ed80-4baf-b11b-cc8a8e0607f0"), "Комби" },
                    { new Guid("ad9e126e-a378-4dde-a93b-6576aa826a33"), "Седан" },
                    { new Guid("cc285879-063b-42d9-8f22-0a660c65589e"), "Бус" },
                    { new Guid("e3f7ab9d-955d-4722-b5a4-5de3c6aac3df"), "Джип" },
                    { new Guid("e549d0c4-3d4b-4f50-800e-d3ecf74004b8"), "Хечбег" },
                    { new Guid("e6416c89-8797-43ad-83cf-0edfe89d8ece"), "Кабрио" },
                    { new Guid("e7479c56-2d1c-440e-b1d3-a8293a2735b9"), "Камион" },
                    { new Guid("f4c537c8-9453-4a6a-a7b6-4d9be75d45d7"), "Ван" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesPurposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("334d022f-38c8-47ac-bc55-74f094aa507f"), "Икономичен Комби" },
                    { new Guid("4112f874-b641-4f78-bd69-9f07293a4fe6"), "Компактен" },
                    { new Guid("5c2fb52f-c511-4e54-aa8e-9ed7d44a7a98"), "Луксозен" },
                    { new Guid("63659075-78b0-4936-bb74-685c82aba31a"), "Стандартен Комби" },
                    { new Guid("6a9b73ee-1f6b-4fe8-9436-5ac89dbafcb7"), "Стандартен" },
                    { new Guid("8c0c25dd-50e0-4c8d-b48d-38243617ff70"), "Икономичен" },
                    { new Guid("ebfef40b-1104-4113-870c-182818f7ce87"), "Голям" }
                });

            migrationBuilder.InsertData(
                table: "VehiclesTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("091c3f68-7b64-4df8-a595-753f1bb854dc"), "Камион" },
                    { new Guid("cc7ce3ee-564a-4cec-983f-2ae6e2050af2"), "Автомобил" },
                    { new Guid("de45d1fd-c8c6-4b77-9900-959f1533516b"), "Бус" }
                });
        }
    }
}
