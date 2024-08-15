using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace storeapp.Migrations
{
    public partial class IdentityRoleSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1db070a5-1238-4443-bb41-529b32d28a54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc88bc5f-3b65-4119-99d0-90bf3c871654");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce18e306-adab-4bdc-98a7-3206ccfff066");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cea7adbb-ef04-48f9-8b10-74f59f729bbf", "357724d3-e969-43c0-a3fa-f95ff916ae34", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6769364-05ba-4e05-8197-f62cd274199a", "500f3747-bffa-4aa8-a5af-1faed13377ec", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f569a7e9-68cb-40ae-8b90-b611d0d0939f", "306218fb-a68c-4afb-83d4-2117e50acfaa", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cea7adbb-ef04-48f9-8b10-74f59f729bbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6769364-05ba-4e05-8197-f62cd274199a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f569a7e9-68cb-40ae-8b90-b611d0d0939f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1db070a5-1238-4443-bb41-529b32d28a54", "6c6e2eb7-0021-4b05-9ff6-dfdbe6ca8fcf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc88bc5f-3b65-4119-99d0-90bf3c871654", "214b256e-1baa-4132-a5a4-2545b19dfbde", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce18e306-adab-4bdc-98a7-3206ccfff066", "e71c26e0-aafe-4674-84cf-a375d530d180", "Admin", "ADMIN" });
        }
    }
}
