using Microsoft.EntityFrameworkCore.Migrations;

namespace KraujoBankasASP.Migrations
{
    public partial class changeToModerator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0efe163c-7cd2-4c22-a3bf-2c7e7b865290");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f8be9f-0d7a-495a-8298-d5657fdd95dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a25a44-26dc-46ac-a80d-af2f3b2fd898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ece133e8-0786-48c0-ae54-feecf54cb36d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "110cec46-21e6-484b-b274-d02922ec55eb", "db882df3-6183-45f8-82ee-f582764d0944", "Admin", "ADMIN" },
                    { "2de602b5-15fb-47b7-a48c-7ae9a19ef161", "bdd77ee3-24df-48a4-9470-bf5abc56bc79", "Moderator", "MODERATOR" },
                    { "09d94689-5b63-480e-a855-0d2014573837", "717193bd-5847-45d9-984b-3261d8d51747", "Donor", "DONOR" },
                    { "cd8de821-7cee-463d-9b4e-2b9ebfb8b09c", "b01bbd59-e3c7-4522-bf34-a603f4741b59", "Employee", "EMPLOYEE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09d94689-5b63-480e-a855-0d2014573837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "110cec46-21e6-484b-b274-d02922ec55eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2de602b5-15fb-47b7-a48c-7ae9a19ef161");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd8de821-7cee-463d-9b4e-2b9ebfb8b09c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ece133e8-0786-48c0-ae54-feecf54cb36d", "9f6e9d86-48bd-4ccc-9661-9400172d7aa1", "Admin", "ADMIN" },
                    { "49f8be9f-0d7a-495a-8298-d5657fdd95dc", "44f3b174-46e6-4b2a-b8ac-a7d3ce89e9ce", "Institution admin", "INSTITUTION ADMIN" },
                    { "93a25a44-26dc-46ac-a80d-af2f3b2fd898", "addd271a-3db2-4ca1-98c3-f78962bbbffc", "Donor", "DONOR" },
                    { "0efe163c-7cd2-4c22-a3bf-2c7e7b865290", "889fd188-27e1-480d-bca3-1ebb5010bc66", "Employee", "EMPLOYEE" }
                });
        }
    }
}
