using Microsoft.EntityFrameworkCore.Migrations;

namespace KraujoBankasASP.Migrations
{
    public partial class Created_aeployee_to_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b920ac3-1365-490c-976a-765f71fc8151");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20e55959-736b-4a99-ae91-94ba42e74d30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a3a0f30-ffb9-4e0b-8860-fe4aae36aa1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e61c5b8-143f-4f1b-81d6-5e8749230879");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "5e61c5b8-143f-4f1b-81d6-5e8749230879", "f4c2d0d0-094b-4235-8f82-f9a14bb4eff0", "Admin", "ADMIN" },
                    { "3a3a0f30-ffb9-4e0b-8860-fe4aae36aa1b", "c1652709-b716-41f6-b707-cba15b8401e4", "Institution admin", "INSTITUTION ADMIN" },
                    { "1b920ac3-1365-490c-976a-765f71fc8151", "88ca9a19-ca73-4e18-83c5-ee1594a7d864", "Donor", "DONOR" },
                    { "20e55959-736b-4a99-ae91-94ba42e74d30", "d149a96b-4625-4654-b0ee-c7d861cd3754", "Employee", "EMPLOYEE" }
                });
        }
    }
}
