using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Identity.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69cca172-4305-43ca-8bc7-a5b881b4145d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfd370e5-f3bc-4c04-bbc0-7a4915f55b01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0261405-fc25-43d1-ab12-0c2e63bc7665");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0485059-c641-43a0-ba0f-7e235ad644da");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c505302-6e26-4a42-a1f0-eed97bdc5104", null, "Guest", null },
                    { "51f43e3a-8117-419b-8fd4-df0094590c91", null, "Customer", null },
                    { "c99e4de1-64be-49b9-b7ad-964404c1101b", null, "Seller", null },
                    { "ed4c7066-fc0a-4d9c-8c1b-95f10f310545", null, "Admin", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c505302-6e26-4a42-a1f0-eed97bdc5104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51f43e3a-8117-419b-8fd4-df0094590c91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c99e4de1-64be-49b9-b7ad-964404c1101b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed4c7066-fc0a-4d9c-8c1b-95f10f310545");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69cca172-4305-43ca-8bc7-a5b881b4145d", null, "Guest", null },
                    { "bfd370e5-f3bc-4c04-bbc0-7a4915f55b01", null, "Seller", null },
                    { "c0261405-fc25-43d1-ab12-0c2e63bc7665", null, "Customer", null },
                    { "e0485059-c641-43a0-ba0f-7e235ad644da", null, "Admin", null }
                });
        }
    }
}
