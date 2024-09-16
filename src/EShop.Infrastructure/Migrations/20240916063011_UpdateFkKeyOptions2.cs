using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFkKeyOptions2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VariantOptions_OptionTypes_OptionTypeId",
                table: "VariantOptions");

            migrationBuilder.DropIndex(
                name: "IX_VariantOptions_OptionTypeId",
                table: "VariantOptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "54aaad63-0ebf-43ec-85f0-6a74607a61ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7e1bcef4-e8a9-4121-83de-eba0b67dcd02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f321207e-f82d-45ce-b939-47fa835cfda9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "818b299b-7e4e-4398-8db8-9e20d5fe11de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "de2d37f0-c857-4967-b342-9fd4d7639642");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726468210.7875125);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726468210.7875128);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726468210.787513);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726468210.7875133);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726468210.7875133);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726468210.7875133);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726468210.7875135);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726468210.7875135);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726468210.7875135);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726468210.7875137);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726468210.787514);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726468210.787514);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726468210.787514);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726468210.7875142);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726468210.7875144);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726468210.7875144);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726468210.7875144);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726468210.7875147);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726468210.7875147);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726468210.7875147);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726468210.7875147);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726468210.7875149);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726468210.7875152);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726468210.7875152);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726468210.7875152);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726468210.7875154);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726468210.7875156);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726468210.7875156);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726468210.7875156);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726468210.7875159);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726468210.7875161);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726468210.7875161);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726468210.7875161);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726468210.7875161);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726468210.7875164);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726468210.7875164);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726468210.7875164);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726468210.7875166);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726468210.7875168);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726468210.7875168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726468210.7818663);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726468210.7818964);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726468210.7819235);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726468210.7819493);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726468210.7819705);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726468210.7819908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726468210.7820151);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726468210.7820363);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726468210.7820587);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726468210.7820816);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726468210.7821033);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726468210.782125);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726468210.7821453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726468210.7821681);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726468210.7821896);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726468210.782217);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726468210.782238);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726468210.7822597);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726468210.7822828);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726468210.7823031);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726468210.7823248);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726468210.7823448);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726468210.7823689);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726468210.7823892);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726468210.7824163);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726468210.7824471);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726468210.7824669);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726468210.7824907);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726468210.7825112);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726468210.7825336);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726468210.7825568);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726468210.7825778);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726468210.7826011);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726468210.782625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726468210.7826471);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726468210.7826693);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726468210.78269);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726468210.7827103);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726468210.7827339);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726468210.7827537);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726468210.7827773);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726468210.7827997);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726468210.7828214);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726468210.7828417);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726468210.7828641);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726468210.7828853);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726468210.7829049);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726468210.7829299);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726468210.7829535);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726468210.7829745);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726468210.7829957);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726468210.7830172);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726468210.7830389);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726468210.7830589);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726468210.7830789);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726468210.7831018);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726468210.7831211);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726468210.7831428);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726468210.7831628);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726468210.783186);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726468210.7832065);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726468210.7832255);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726468210.7832499);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726468210.7832737);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726468210.7832949);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726468210.7833152);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726468210.7833381);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726468210.78336);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726468210.7833805);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726468210.7834029);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726468210.7834241);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726468210.7834439);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726468210.7834661);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726468210.7834885);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726468210.7835088);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726468210.7835295);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726468210.78355);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726468210.7835739);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726468210.7835948);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726468210.7836154);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726468210.783639);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726468210.7836585);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726468210.7836812);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726468210.7837019);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726468210.7837243);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726468210.7838142);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726468210.7838383);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726468210.7838609);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726468210.7838836);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726468210.7839046);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726468210.7839296);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726468210.7839525);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726468210.7839749);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726468210.7839952);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726468210.7840157);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726468210.7840388);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726468210.7840583);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726468210.7840805);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726468210.7841003);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726468210.7841203);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726468210.7841434);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726468210.7841649);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726468210.7841899);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726468210.7842107);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726468210.7842319);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726468210.7842517);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726468210.7842741);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726468210.7842951);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726468210.7843151);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726468210.7843363);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726468210.784359);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726468210.7843804);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726468210.7844012);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726468210.7844217);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726468210.7844453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726468210.7844656);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726468210.784487);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726468210.7845097);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726468210.7845311);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726468210.7845523);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726468210.7845736);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726468210.7845967);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726468210.7846181);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726468210.7846386);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726468210.7846618);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726468210.7846823);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726468210.7847023);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726468210.7847257);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726468210.7847455);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726468210.7847707);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726468210.7847912);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726468210.7848127);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726468210.7848349);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726468210.7848561);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726468210.7848773);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726468210.7849019);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726468210.7849276);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726468210.7849483);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726468210.7849717);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726468210.7849927);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726468210.7850127);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726468210.7850323);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726468210.7850564);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726468210.7850771);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726468210.7851007);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726468210.7851207);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726468210.7851465);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726468210.7851701);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726468210.7851896);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726468210.7852099);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726468210.7852335);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726468210.7852774);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726468210.7853067);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726468210.7853355);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726468210.7853556);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726468210.785378);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726468210.785398);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726468210.7854342);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726468210.7854564);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726468210.7854776);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726468210.7854989);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726468210.785522);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726468210.785542);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726468210.7855623);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726468210.7855847);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726468210.7856059);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726468210.7856259);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726468210.7856472);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726468210.7856696);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726468210.7856908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726468210.785712);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726468210.7857339);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726468210.7857561);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726468210.7857783);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726468210.7858071);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726468210.7858276);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726468210.7858503);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726468210.785871);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726468210.7858934);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726468210.785918);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726468210.7859395);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726468210.7859628);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726468210.7859831);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726468210.7860067);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726468210.7860267);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726468210.7860465);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726468210.7860689);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726468210.7860949);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726468210.7861154);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726468210.7861404);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726468210.7861636);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726468210.7861831);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726468210.7862058);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726468210.786226);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726468210.7862494);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726468210.7862697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726468210.7862892);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726468210.7863126);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726468210.7863331);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726468210.7863545);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726468210.7863748);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726468210.7864015);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726468210.786422);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726468210.7864497);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726468210.7864699);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726468210.7864926);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726468210.7865129);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726468210.7865322);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726468210.7865541);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726468210.7865772);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726468210.7865987);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726468210.7866187);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726468210.7866409);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726468210.7866619);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726468210.7866819);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726468210.7867117);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726468210.7867327);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726468210.7867546);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726468210.7867751);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726468210.7867951);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726468210.7868187);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726468210.7868392);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726468210.7868612);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726468210.7868817);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726468210.786906);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726468210.786948);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726468210.7869711);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726468210.7869933);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726468210.7870135);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726468210.7870376);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726468210.7870581);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726468210.7870815);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726468210.787102);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726468210.7871213);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726468210.7871485);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726468210.7871716);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726468210.7871947);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726468210.7872159);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726468210.7872384);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726468210.7872591);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726468210.7872803);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726468210.7873025);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726468210.7873249);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726468210.787348);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726468210.7873697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726468210.7873924);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726468210.7874131);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726468210.7874348);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "671654be-f3b6-4d55-869e-7d45a3d5cc75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d87663c4-23a3-46bd-ac03-00b1ffeb354e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1df545b2-75ef-4b71-be7a-18e3cb326ca3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e0400d0c-2608-40ff-b81f-1cffee129665");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "c50ae13a-d898-4ef0-be01-525d4a9b7593");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726467976.4974549);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726467976.4974551);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726467976.4974554);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726467976.4974556);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726467976.4974556);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726467976.4974558);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726467976.4974561);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726467976.4974561);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726467976.4974561);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726467976.4974563);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726467976.4974563);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726467976.4974563);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726467976.4974563);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726467976.4974566);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726467976.4974568);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726467976.4974568);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726467976.4974568);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726467976.497457);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726467976.4974573);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726467976.4974573);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726467976.4974573);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726467976.4974575);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726467976.4974575);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726467976.4974575);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726467976.4974575);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726467976.4974577);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726467976.497458);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726467976.497458);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726467976.497458);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726467976.4974582);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726467976.4974585);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726467976.4974585);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726467976.4974585);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726467976.4974587);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726467976.4974587);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726467976.4974587);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726467976.4974587);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726467976.4974589);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726467976.4974592);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726467976.4974592);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726467976.4914751);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726467976.4915044);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726467976.4915304);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726467976.4915547);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726467976.4915769);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726467976.4915974);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726467976.4916213);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726467976.4916413);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726467976.4916625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726467976.4916885);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726467976.4917088);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726467976.49173);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726467976.4917526);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726467976.4917746);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726467976.4918022);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726467976.4918237);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726467976.4918463);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726467976.4918697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726467976.4918904);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726467976.4919107);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726467976.4919317);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726467976.4919543);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726467976.4919772);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726467976.4919972);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726467976.4920204);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726467976.4920404);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726467976.4920695);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726467976.492095);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726467976.4921167);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726467976.4921396);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726467976.4921637);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726467976.4921856);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726467976.4922085);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726467976.4922321);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726467976.4922559);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726467976.4922884);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726467976.4923215);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726467976.4923503);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726467976.4923739);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726467976.4924088);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726467976.4924316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726467976.4924519);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726467976.4924729);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726467976.4924958);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726467976.4925203);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726467976.492542);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726467976.4925616);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726467976.4925852);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726467976.4926059);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726467976.4926264);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726467976.4926505);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726467976.4926724);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726467976.4926932);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726467976.4927168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726467976.4927373);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726467976.492758);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726467976.4927788);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726467976.4928033);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726467976.4928277);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726467976.4928496);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726467976.4928722);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726467976.4928937);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726467976.4929135);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726467976.4929402);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726467976.4929683);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726467976.4929934);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726467976.4930148);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726467976.4930367);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726467976.493057);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726467976.493084);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726467976.4931149);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726467976.4931371);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726467976.4931681);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726467976.4931953);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726467976.4932151);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726467976.4932432);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726467976.4932709);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726467976.4932981);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726467976.4933188);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726467976.4933479);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726467976.4933715);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726467976.4933913);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726467976.4934132);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726467976.4934332);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726467976.4934564);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726467976.4934764);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726467976.4934959);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726467976.4935172);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726467976.49354);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726467976.4935603);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726467976.4935827);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726467976.4936073);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726467976.4936273);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726467976.4936481);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726467976.4936724);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726467976.4936979);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726467976.4937224);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726467976.493742);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726467976.4937658);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726467976.4937887);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726467976.4938092);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726467976.49383);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726467976.49385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726467976.4938743);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726467976.4938941);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726467976.4939179);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726467976.4939396);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726467976.4939682);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726467976.4939952);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726467976.4940183);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726467976.4940453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726467976.4940655);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726467976.4940872);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726467976.4941075);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726467976.4941316);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726467976.4941528);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726467976.4941728);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726467976.4941957);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726467976.4942183);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726467976.4942391);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726467976.4942625);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726467976.4942815);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726467976.4943037);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726467976.4943273);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726467976.4943485);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726467976.4943721);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726467976.4944708);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726467976.4945383);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726467976.4945848);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726467976.4946148);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726467976.4946363);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726467976.494658);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726467976.4946845);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726467976.4947052);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726467976.4947269);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726467976.4947555);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726467976.4947789);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726467976.4947982);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726467976.4948227);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726467976.4948428);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726467976.494864);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726467976.4948852);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726467976.4949093);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726467976.4949305);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726467976.4949517);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726467976.4949751);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726467976.4949956);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726467976.4950197);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726467976.4950402);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726467976.4950593);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726467976.4950807);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726467976.4951475);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726467976.495172);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726467976.4951923);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726467976.4952159);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726467976.4952378);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726467976.4952641);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726467976.4953015);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726467976.4953227);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726467976.4953451);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726467976.4953859);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726467976.4954104);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726467976.4954338);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726467976.4954538);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726467976.4954765);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726467976.495496);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726467976.4955149);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726467976.4955361);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726467976.495558);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726467976.4955795);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726467976.4956017);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726467976.4956248);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726467976.4956453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726467976.4956789);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726467976.4957156);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726467976.4957376);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726467976.4957643);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726467976.4957852);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726467976.4958065);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726467976.4958291);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726467976.4958522);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726467976.495873);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726467976.4958966);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726467976.4959168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726467976.4959359);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726467976.49596);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726467976.4959812);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726467976.4960017);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726467976.4960215);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726467976.4960456);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726467976.4960661);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726467976.4960866);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726467976.49611);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726467976.4961295);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726467976.4961512);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726467976.4961734);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726467976.4961946);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726467976.4962149);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726467976.4962335);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726467976.4962578);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726467976.496279);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726467976.4962997);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726467976.4963226);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726467976.4963431);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726467976.4963717);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726467976.4963937);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726467976.4964137);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726467976.4964352);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726467976.4964571);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726467976.4964793);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726467976.4964995);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726467976.4965229);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726467976.4965427);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726467976.4965639);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726467976.4965868);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726467976.4966075);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726467976.4966307);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726467976.4966512);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726467976.496675);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726467976.496696);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726467976.4967165);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726467976.4967401);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726467976.4967592);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726467976.4967821);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726467976.4968033);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726467976.4968455);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726467976.4968667);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726467976.4968903);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726467976.4969103);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726467976.4969347);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726467976.4969552);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726467976.4969788);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726467976.4969995);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726467976.49702);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726467976.4970446);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726467976.4970648);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726467976.4970908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726467976.4971137);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726467976.4971385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726467976.4971585);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726467976.4971805);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726467976.4972043);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726467976.4972289);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726467976.4972515);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726467976.4972751);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726467976.4972975);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726467976.4973185);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726467976.4973412);

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
        }
    }
}
