using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOptionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_ProductVariants_ProductVariantId",
                table: "VariantOptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8bf5ea91-fe91-47d8-b513-fc2343b18bd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "2a2c159b-b125-488c-9dd3-5603d0a4cabc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "91d107ab-d2db-42d2-a15a-4b61b699a0a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6074c9ef-8449-4f06-90cd-a850bda18748");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "6ef7d2b4-0659-41ba-a830-89f614b720a1");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726558713.970407);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726558713.9704075);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726558713.9704075);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726558713.9704075);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726558713.9704077);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726558713.970408);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726558713.970408);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726558713.970408);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726558713.9704082);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726558713.9704084);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726558713.9704084);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726558713.9704084);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726558713.9704087);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726558713.9704089);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726558713.9704089);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726558713.9704089);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726558713.9704089);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726558713.9704092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726558713.9704092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726558713.9704092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726558713.9704094);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726558713.9704096);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726558713.9704096);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726558713.9704096);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726558713.9704096);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726558713.9704099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726558713.9704101);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726558713.9704101);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726558713.9704101);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726558713.9704101);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726558713.9704103);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726558713.9704103);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726558713.9704103);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726558713.9704106);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726558713.9704108);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726558713.9704108);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726558713.9704108);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726558713.9704111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726558713.9704113);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726558713.9704113);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726558713.9649324);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726558713.964958);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726558713.9649796);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726558713.9650021);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726558713.9650247);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726558713.9650455);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726558713.9650664);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726558713.9650881);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726558713.9651115);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726558713.965132);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726558713.9651685);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726558713.9651887);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726558713.96521);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726558713.9652305);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726558713.9652531);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726558713.9652741);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726558713.9652956);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726558713.965318);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726558713.965338);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726558713.9653611);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726558713.9653809);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726558713.9654002);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726558713.9654245);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726558713.9654453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726558713.9654686);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726558713.9654913);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726558713.9655111);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726558713.9655316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726558713.965553);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726558713.9655769);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726558713.9655969);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726558713.9656167);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726558713.9656413);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726558713.9656625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726558713.9656816);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726558713.9657052);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726558713.9657259);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726558713.9657476);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726558713.9657671);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726558713.96579);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726558713.9658124);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726558713.9658325);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726558713.9658556);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726558713.9658754);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726558713.9658954);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726558713.9659183);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726558713.9659369);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726558713.9659588);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726558713.9659791);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726558713.9660032);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726558713.9660232);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726558713.9660451);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726558713.9660673);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726558713.9660876);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726558713.9661081);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726558713.9661276);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726558713.9661555);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726558713.966176);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726558713.9661963);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726558713.9662192);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726558713.9662385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726558713.96626);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726558713.9662797);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726558713.9663053);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726558713.9663248);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726558713.9663458);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726558713.9663677);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726558713.9663875);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726558713.9664085);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726558713.9664304);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726558713.9664519);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726558713.9664719);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726558713.9664955);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726558713.9665155);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726558713.9665384);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726558713.9665596);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726558713.9665816);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726558713.9666028);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726558713.9666228);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726558713.9666495);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726558713.9666765);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726558713.9666955);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726558713.9667168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726558713.9667385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726558713.9667585);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726558713.9667792);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726558713.9667988);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726558713.9668212);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726558713.9668443);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726558713.9668641);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726558713.9668832);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726558713.9669068);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726558713.9669271);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726558713.9669478);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726558713.9669671);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726558713.9669893);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726558713.96701);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726558713.9670296);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726558713.9670503);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726558713.9670708);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726558713.9670932);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726558713.9671156);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726558713.9671359);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726558713.9671605);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726558713.9671853);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726558713.9672053);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726558713.9672277);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726558713.9672484);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726558713.9672697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726558713.9672911);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726558713.9673109);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726558713.9673307);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726558713.9673531);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726558713.9673717);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726558713.9673936);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726558713.9674151);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726558713.9674373);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726558713.967458);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726558713.9674785);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726558713.9675019);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726558713.9675217);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726558713.9675446);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726558713.9675643);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726558713.9675837);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726558713.9676073);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726558713.9676273);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726558713.9676502);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726558713.96767);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726558713.9676914);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726558713.9677143);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726558713.9677346);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726558713.9677575);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726558713.9677763);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726558713.9677985);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726558713.9678204);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726558713.9678442);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726558713.9678643);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726558713.967886);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726558713.9679072);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726558713.9679272);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726558713.9679484);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726558713.9679728);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726558713.9679928);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726558713.9680159);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726558713.9680362);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726558713.9680572);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726558713.96808);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726558713.9680991);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726558713.9681208);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726558713.9681473);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726558713.9681699);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726558713.96821);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726558713.96823);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726558713.9682548);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726558713.9682748);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726558713.9682975);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726558713.9683173);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726558713.9683409);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726558713.9683604);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726558713.9683795);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726558713.9684031);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726558713.9684229);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726558713.9684439);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726558713.9684632);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726558713.9684875);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726558713.9685075);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726558713.9685268);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726558713.9685481);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726558713.96857);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726558713.9685912);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726558713.9686112);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726558713.9686334);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726558713.9686546);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726558713.9686761);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726558713.9687002);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726558713.9687195);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726558713.9687417);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726558713.9687636);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726558713.9687848);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726558713.9688048);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726558713.9688275);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726558713.968848);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726558713.9688692);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726558713.9688909);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726558713.9689109);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726558713.9689331);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726558713.9689538);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726558713.9689727);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726558713.9690084);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726558713.9690311);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726558713.9690516);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726558713.9690711);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726558713.9690936);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726558713.9691145);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726558713.9691341);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726558713.9691627);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726558713.9691827);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726558713.9692025);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726558713.9692228);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726558713.969244);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726558713.9692657);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726558713.9692852);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726558713.9693079);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726558713.9693291);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726558713.9693501);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726558713.9693696);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726558713.9693913);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726558713.9694123);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726558713.9694321);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726558713.9694548);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726558713.9694748);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726558713.9694953);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726558713.9695165);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726558713.9695392);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726558713.9695587);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726558713.9695804);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726558713.9696023);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726558713.9696231);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726558713.9696431);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726558713.9696655);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726558713.969686);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726558713.9697061);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726558713.9697292);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726558713.9697492);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726558713.96977);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726558713.9698062);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726558713.9698288);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726558713.9698503);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726558713.9698732);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726558713.9698939);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726558713.9699171);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726558713.9699364);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726558713.9699607);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726558713.96998);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726558713.9700015);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726558713.9700241);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726558713.9700465);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726558713.9700687);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726558713.9700885);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726558713.9701111);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726558713.9701316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726558713.9701877);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726558713.9702101);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726558713.9702322);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726558713.9702549);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726558713.9702799);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726558713.9703019);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726558713.9703233);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726558713.9704227);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726558713.9704232);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726558713.9704232);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726558713.9704235);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726558713.9704237);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726558713.9704237);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726558713.970417);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726558713.9704173);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726558713.9704173);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726558713.9704175);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726558713.9704175);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726558713.9704175);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726558713.9704175);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726558713.9704175);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726558713.9704177);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726558713.9704177);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726558713.970418);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726558713.970418);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726558713.970418);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726558713.970418);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726558713.9704182);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726558713.9704185);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726558713.9704185);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726558713.9704185);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726558713.9704185);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726558713.9704187);

            migrationBuilder.CreateIndex(
                name: "IX_VariantOptions_OptionTypeId",
                table: "VariantOptions",
                column: "OptionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VariantOptions_OptionTypes_OptionTypeId",
                table: "VariantOptions",
                column: "OptionTypeId",
                principalTable: "OptionTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VariantOptions_ProductVariants_ProductVariantId",
                table: "VariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_OptionTypes_OptionTypeId",
                table: "VariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_ProductVariants_ProductVariantId",
                table: "VariantOptions");

            migrationBuilder.DropIndex(
                name: "IX_VariantOptions_OptionTypeId",
                table: "VariantOptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "972ae7e1-fd4e-452e-9c14-67488e3460e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "642043f1-394f-47e8-895f-1d695efe98dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "39eb347b-d803-4641-8e7f-b0ad5e8258e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "a269325a-ca6d-4671-8669-f71b9fb282fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "24040428-258f-4b34-9da6-c03810716f95");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726549660.9679267);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726549660.9679272);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726549660.9679275);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726549660.9679277);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726549660.9679277);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726549660.9679277);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726549660.9679279);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726549660.9679279);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726549660.9679279);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726549660.9679282);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726549660.9679284);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726549660.9679284);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726549660.9679284);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726549660.9679286);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726549660.9679289);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726549660.9679289);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726549660.9679289);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726549660.9679289);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726549660.9679291);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726549660.9679291);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726549660.9679291);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726549660.9679291);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726549660.9679294);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726549660.9679296);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726549660.9679296);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726549660.9679296);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726549660.9679298);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726549660.9679301);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726549660.9679301);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726549660.9679301);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726549660.9679303);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726549660.9679303);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726549660.9679303);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726549660.9679303);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726549660.9679306);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726549660.9679308);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726549660.9679308);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726549660.9679308);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726549660.9679308);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726549660.967931);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726549660.9616981);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726549660.9617283);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726549660.9617493);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726549660.9617889);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726549660.9618094);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726549660.9618311);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726549660.9618511);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726549660.9618747);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726549660.9618969);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726549660.9619188);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726549660.9619527);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726549660.9619739);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726549660.9619949);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726549660.9620168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726549660.9620397);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726549660.9620595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726549660.962106);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726549660.9621394);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726549660.9621785);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726549660.9622188);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726549660.9622419);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726549660.9623015);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726549660.9623287);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726549660.9623835);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726549660.9624298);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726549660.9624603);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726549660.9624817);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726549660.9625049);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726549660.9625256);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726549660.9625468);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726549660.962569);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726549660.9625914);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726549660.9626145);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726549660.9626393);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726549660.9626608);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726549660.9626813);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726549660.9627051);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726549660.9627256);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726549660.9627469);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726549660.9627707);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726549660.9627929);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726549660.9628153);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726549660.9628358);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726549660.9628625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726549660.962883);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726549660.9629045);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726549660.9629242);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726549660.9629469);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726549660.9629672);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726549660.9629896);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726549660.9630115);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726549660.9630332);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726549660.9630537);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726549660.9630847);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726549660.9631116);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726549660.9631317);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726549660.96316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726549660.9631832);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726549660.9632041);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726549660.9632227);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726549660.9632485);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726549660.9632697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726549660.9632933);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726549660.9633157);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726549660.963336);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726549660.9633596);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726549660.963378);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726549660.9634025);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726549660.9634233);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726549660.9634435);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726549660.9634681);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726549660.9634888);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726549660.9635112);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726549660.9635313);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726549660.9635584);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726549660.9635806);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726549660.9636011);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726549660.9636247);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726549660.9636455);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726549660.963666);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726549660.9636867);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726549660.9637165);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726549660.9637389);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726549660.9637649);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726549660.9637873);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726549660.963809);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726549660.9638293);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726549660.9638481);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726549660.963877);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726549660.9639044);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726549660.9639385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726549660.9639626);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726549660.9639843);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726549660.9640069);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726549660.9640267);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726549660.9640467);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726549660.964076);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726549660.9640987);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726549660.9641218);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726549660.9641433);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726549660.9641652);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726549660.9641881);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726549660.9642136);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726549660.9642358);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726549660.9642549);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726549660.964277);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726549660.9642961);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726549660.9643171);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726549660.9643388);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726549660.9643605);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726549660.9643795);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726549660.9643986);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726549660.9644222);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726549660.9644437);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726549660.9644647);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726549660.9644845);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726549660.9645116);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726549660.9645331);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726549660.9645576);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726549660.9645891);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726549660.9646089);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726549660.9646308);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726549660.9646509);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726549660.9646728);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726549660.9646938);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726549660.9647171);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726549660.9647396);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726549660.9647739);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726549660.9647961);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726549660.9648316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726549660.9648592);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726549660.9648924);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726549660.9649146);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726549660.9649439);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726549660.9649692);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726549660.9649928);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726549660.9650176);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726549660.9650381);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726549660.9650617);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726549660.9650934);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726549660.9651136);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726549660.9651372);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726549660.965157);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726549660.9651768);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726549660.9651995);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726549660.9652183);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726549660.9652395);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726549660.9652658);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726549660.9652855);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726549660.9653063);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726549660.9653339);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726549660.9653904);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726549660.9654286);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726549660.9654536);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726549660.9654782);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726549660.9655149);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726549660.9655392);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726549660.9655647);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726549660.9656067);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726549660.9656379);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726549660.9656632);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726549660.9656987);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726549660.9657235);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726549660.9657435);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726549660.965766);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726549660.9657874);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726549660.9658105);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726549660.9658315);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726549660.9658515);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726549660.9658761);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726549660.9659083);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726549660.9659305);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726549660.9659619);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726549660.9659879);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726549660.966018);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726549660.9660451);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726549660.9660971);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726549660.9661283);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726549660.9661603);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726549660.9661975);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726549660.9662268);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726549660.9662628);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726549660.9662914);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726549660.966326);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726549660.9663625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726549660.9663928);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726549660.966424);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726549660.96645);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726549660.96648);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726549660.9665039);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726549660.9665287);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726549660.9665573);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726549660.966578);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726549660.9666059);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726549660.9666312);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726549660.9666638);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726549660.9666858);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726549660.9667089);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726549660.9667301);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726549660.9667573);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726549660.9667771);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726549660.9668036);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726549660.9668243);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726549660.9668462);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726549660.9668665);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726549660.9668868);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726549660.966908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726549660.9669292);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726549660.9669492);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726549660.9669724);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726549660.9669924);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726549660.9670155);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726549660.9670424);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726549660.9670756);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726549660.9671004);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726549660.9671197);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726549660.9671421);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726549660.9671624);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726549660.9671817);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726549660.967206);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726549660.9672256);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726549660.9672456);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726549660.9672668);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726549660.9672885);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726549660.9673111);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726549660.9673498);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726549660.9673748);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726549660.9673958);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726549660.9674172);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726549660.9674387);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726549660.9674611);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726549660.9674821);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726549660.9675045);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726549660.967526);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726549660.9675479);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726549660.9675682);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726549660.9675908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726549660.9676099);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726549660.9676335);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726549660.9676528);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726549660.967674);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726549660.9676964);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726549660.9677167);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726549660.9677408);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726549660.9677613);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726549660.9677856);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726549660.9678054);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726549660.9678259);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726549660.9679472);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726549660.967948);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726549660.9679482);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726549660.9679484);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726549660.9679484);

            migrationBuilder.UpdateData(
                table: "OptionTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726549660.9679484);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726549660.9679418);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726549660.967942);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726549660.967942);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726549660.967942);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726549660.9679422);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726549660.9679425);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726549660.9679425);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726549660.9679425);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726549660.9679425);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726549660.9679427);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726549660.9679427);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726549660.9679427);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726549660.9679427);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726549660.9679427);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726549660.967943);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726549660.967943);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726549660.9679432);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726549660.9679432);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726549660.9679432);

            migrationBuilder.UpdateData(
                table: "OptionValues",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726549660.9679432);

            migrationBuilder.AddForeignKey(
                name: "FK_VariantOptions_ProductVariants_ProductVariantId",
                table: "VariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
