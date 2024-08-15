using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace storeapp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
