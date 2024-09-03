using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserPayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e6d2b905-46b4-4b4b-a60e-dfeead3ce2c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "dd184f72-733d-4d55-897d-8c9b5f328581");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cc22fa9b-bfa9-4010-9549-01d29cbb65d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "ee854700-b285-47f1-9c93-1f38ce6e397b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "373b3b9e-b2f6-4696-b111-71361d610514");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1725375134.6753078);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1725375134.6753082);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1725375134.6753085);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1725375134.6753085);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1725375134.6753085);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1725375134.6753087);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1725375134.6753087);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1725375134.6753087);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1725375134.6753087);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1725375134.6753089);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1725375134.6753092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1725375134.6753092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1725375134.6753092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1725375134.6753092);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1725375134.6753094);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1725375134.6753097);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1725375134.6753097);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1725375134.6753097);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1725375134.6753097);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1725375134.6753099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1725375134.6753099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1725375134.6753099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1725375134.6753099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1725375134.6753099);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1725375134.6753101);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1725375134.6753104);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1725375134.6753104);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1725375134.6753104);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1725375134.6753104);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1725375134.6753106);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1725375134.6753109);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1725375134.6753109);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1725375134.6753109);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1725375134.6753109);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1725375134.6753111);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1725375134.6752982);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1725375134.6752992);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1725375134.6752992);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1725375134.6752992);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1725375134.6752994);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1725375134.6752996);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1725375134.6752996);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1725375134.6752996);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1725375134.6752999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1725375134.6752999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1725375134.6752999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1725375134.6752999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1725375134.6752999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1725375134.6753001);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1725375134.6753004);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1725375134.6753004);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1725375134.6753027);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1725375134.675303);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1725375134.6753032);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1725375134.6753032);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1725375134.6753032);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1725375134.6753035);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725375134.6753144, 86, 994.73000000000002, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725375134.6753235, 94, 927.09000000000003, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725375134.6753244, 75, 428.92000000000002, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725375134.6753252, 191, 352.25, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725375134.6753261, 142, 829.74000000000001, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725375134.6753263, 149, 293.43000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6753287, 79, 664.63, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6753292, 193, 880.59000000000003, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6753299, 60, 904.92999999999995, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.6753306, 85, 179.72, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 91, 1725375134.6753316, 186, 243.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6753321, 43, 673.47000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725375134.6753328, 126, 155.28, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6753333, 23, 596.66999999999996, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.675334, 31, 907.58000000000004, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725375134.6753345, 742.66999999999996, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6753352, 157, 862.34000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6753359, 37, 350.05000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725375134.6753364, 157, 943.52999999999997, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6753409, 133, 108.81999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.6753416, 96, 370.77999999999997, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725375134.6753421, 180, 800.14999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6753428, 118, 996.95000000000005, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6753433, 116, 709.35000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725375134.675344, 199, 571.09000000000003, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725375134.6753445, 26, 871.13999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725375134.6753452, 23, 837.20000000000005, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725375134.6753459, 156, 481.91000000000003, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725375134.6753464, 157, 312.25, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725375134.6753471, 48, 334.30000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725375134.6753476, 44, 501.93000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725375134.675348, 122, 646.88999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725375134.6753488, 104, 883.54999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6753521, 174, 331.18000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6753528, 110, 156.28, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725375134.6753533, 100, 916.48000000000002, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725375134.675354, 124, 644.22000000000003, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6753545, 141, 781.71000000000004, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725375134.6753552, 117, 784.63999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725375134.6753557, 113, 11.17, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.6753564, 92, 448.85000000000002, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6753571, 767.32000000000005, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6753576, 74, 750.64999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725375134.6753581, 96, 640.22000000000003, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6753588, 125, 555.92999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725375134.6753592, 133, 817.55999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725375134.67536, 108, 530.57000000000005, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725375134.6753631, 143, 967.23000000000002, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725375134.6753635, 145, 745.77999999999997, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725375134.6753645, 130, 496.94999999999999, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.6753647, 110, 732.99000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725375134.6753657, 108, 794.04999999999995, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725375134.6753662, 88, 337.60000000000002, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6753669, 64, 685.61000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725375134.6753671, 96, 907.92999999999995, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725375134.6753681, 166, 274.89999999999998, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725375134.6753683, 127, 916.19000000000005, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725375134.6753693, 91, 366.99000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725375134.6753697, 180, 591.15999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725375134.6753705, 39, 203.69, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6753709, 26, 401.22000000000003, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725375134.6753736, 73, 19.300000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6753745, 33, 401.0, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725375134.6753747, 107, 35.399999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725375134.6753755, 190, 948.60000000000002, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 1725375134.6753759, 22, 16.27 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725375134.6753769, 94, 306.49000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725375134.6753771, 158, 917.00999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725375134.6753781, 193, 874.66999999999996, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725375134.6753783, 163, 64.239999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725375134.6753793, 78, 68.170000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725375134.6753795, 127, 846.91999999999996, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6753802, 35, 403.25999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 55, 1725375134.6753829, 65, 984.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725375134.6753833, 34, 506.17000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.675384, 86, 376.00999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6753848, 62, 985.57000000000005, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725375134.6753852, 188, 12.07, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725375134.675386, 102, 451.33999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6753864, 20, 233.21000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725375134.6753871, 95, 324.61000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725375134.6753876, 119, 56.659999999999997, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725375134.6753883, 34, 317.66000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6753888, 51, 262.97000000000003, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725375134.6753895, 141, 978.62, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725375134.67539, 116, 729.82000000000005, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 88, 1725375134.6753907, 71, 51.509999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.6753955, 53, 563.08000000000004, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725375134.6753964, 191, 273.13, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.6753967, 122, 633.16999999999996, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725375134.6753976, 182, 380.24000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725375134.6753981, 98, 625.25999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6753988, 81, 3.1099999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6753993, 104, 384.39999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.6754, 62, 17.93, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6754005, 107, 464.99000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 26, 1725375134.6754012, 163, 976.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6754017, 61, 865.41999999999996, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725375134.6754024, 55, 310.23000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6754031, 93, 667.30999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725375134.6754036, 77, 171.34999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725375134.6754043, 25, 788.59000000000003, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6754069, 37, 487.88999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6754076, 176, 784.30999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725375134.6754079, 92, 486.88, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 56, 1725375134.6754088, 32, 210.11000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6754093, 159, 625.10000000000002, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailableStock", "Created", "Price" },
                values: new object[] { 96, 1725375134.67541, 49.829999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6754105, 174, 645.96000000000004, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 48, 1725375134.6754112, 198, 664.58000000000004, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725375134.6754117, 174, 441.26999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725375134.6754124, 77, 444.81999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725375134.6754129, 40, 132.74000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725375134.6754136, 136, 382.94, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6754141, 70, 260.82999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6754146, 143, 943.33000000000004, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 65, 1725375134.6754177, 41, 473.94999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6754179, 46, 821.74000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6754189, 71, 161.41999999999999, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725375134.6754191, 25, 222.94999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 34, 1725375134.6754198, 94, 378.68000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.6754203, 86, 894.75999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725375134.675421, 135, 724.04999999999995, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725375134.6754217, 77, 448.31999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725375134.675422, 157, 317.13, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725375134.6754229, 63, 95.010000000000005, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725375134.6754231, 62, 170.63999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 35, 1725375134.6754239, 93, 293.91000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6754243, 142, 503.54000000000002, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725375134.6754265, 185, 319.55000000000001, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725375134.6754272, 102, 166.68000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 28, 1725375134.6754279, 55, 889.00999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6754284, 110, 33.780000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725375134.6754291, 27, 124.47, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6754298, 166, 895.79999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725375134.6754303, 139, 160.47999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725375134.6754308, 25, 703.36000000000001, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6754315, 85, 20.91, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725375134.6754322, 111, 473.14999999999998, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6754327, 184, 636.79999999999995, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 54, 1725375134.6754365, 165, 683.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725375134.675437, 53, 759.16999999999996, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725375134.6754377, 190, 288.56, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725375134.6754384, 176, 809.71000000000004, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6754389, 81, 93.040000000000006, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725375134.6754396, 73, 840.15999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.6754401, 87, 108.86, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725375134.6754408, 50, 876.44000000000005, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725375134.6754413, 82, 897.39999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.675442, 175, 468.25, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725375134.6754425, 78, 612.78999999999996, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725375134.6754429, 34, 15.23, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725375134.6754436, 191, 520.02999999999997, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6754441, 169, 29.52, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725375134.6754477, 94, 497.07999999999998, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6754482, 78, 733.01999999999998, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725375134.6754489, 94, 245.41999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725375134.6754494, 155, 594.16999999999996, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.6754501, 66, 912.13999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725375134.6754503, 137, 125.18000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725375134.6754513, 162, 65.120000000000005, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725375134.6754515, 155, 175.47, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725375134.6754525, 24, 970.99000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725375134.6754527, 26, 452.62, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725375134.6754537, 69, 145.15000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725375134.6754539, 144, 132.99000000000001, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6754546, 157, 645.98000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725375134.6754551, 143, 784.52999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.675458, 160, 13.6, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6754584, 34, 222.87, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725375134.6754589, 170, 40.18, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725375134.6754596, 157, 439.99000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6754603, 191, 458.63, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725375134.6754608, 194, 351.05000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.6754613, 189, 248.18000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.675462, 155, 20.399999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725375134.6754627, 59, 463.60000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.6754632, 152, 988.98000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725375134.6754639, 51, 797.63, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725375134.6754646, 182, 274.79000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.6754651, 166, 57.100000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725375134.6754658, 55, 908.08000000000004, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 36, 1725375134.6754684, 72, 695.04999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6754689, 87, 762.04999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6754696, 21, 390.79000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6754701, 165, 150.50999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725375134.6754708, 103, 146.77000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725375134.6754713, 175, 185.24000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725375134.675472, 126, 212.27000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6754725, 52, 570.75, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725375134.6754732, 76, 908.20000000000005, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6754739, 160, 57.68, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6754744, 158, 210.68000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6754751, 163, 917.86000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6754756, 155, 422.12, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6754763, 52, 464.72000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725375134.6754789, 125, 173.80000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6754797, 106, 664.30999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725375134.6754801, 198, 585.69000000000005, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725375134.6754808, 180, 452.27999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 48, 1725375134.6754813, 143, 531.54999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725375134.675482, 125, 950.57000000000005, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725375134.6754825, 188, 485.89999999999998, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6754832, 146, 395.35000000000002, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725375134.6754837, 153, 47.259999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725375134.6754844, 107, 668.71000000000004, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725375134.6754849, 151, 936.19000000000005, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725375134.6754856, 99, 214.62, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725375134.6754861, 194, 394.08999999999997, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6754868, 181, 529.04999999999995, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725375134.6754892, 193, 396.47000000000003, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6754899, 47, 564.34000000000003, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 64, 1725375134.6754904, 191, 792.30999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6754911, 50, 833.95000000000005, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725375134.6754916, 177, 972.78999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6754923, 165, 161.74000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725375134.6754928, 184, 100.64, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725375134.6754937, 111, 119.20999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.675494, 145, 598.30999999999995, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 28, 1725375134.6754947, 31, 623.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725375134.6754951, 139, 198.13, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6754961, 193, 671.02999999999997, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 6, 1725375134.6754963, 172, 470.70999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6754971, 120, 351.56, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.6754997, 120, 821.77999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6754999, 42, 710.23000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725375134.6755009, 21, 450.43000000000001, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6755011, 117, 60.119999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725375134.6755021, 171, 270.32999999999998, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725375134.6755023, 112, 451.51999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725375134.6755033, 195, 124.47, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725375134.6755035, 61, 985.77999999999997, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725375134.6755044, 133, 831.38999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725375134.6755047, 36, 196.16, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6755054, 22, 313.31, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725375134.6755061, 184, 417.49000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.6755066, 149, 996.34000000000003, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.6755073, 101, 511.56, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6755092, 151, 654.83000000000004, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725375134.6755097, 190, 185.22999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725375134.6755102, 165, 84.620000000000005, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6755109, 46, 193.61000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725375134.6755114, 95, 682.99000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725375134.6755121, 878.72000000000003, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.6755126, 23, 717.75, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725375134.6755133, 194, 368.75999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6755137, 147, 111.64, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6755145, 35, 900.30999999999995, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725375134.6755152, 73, 300.19999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725375134.6755157, 100, 663.69000000000005, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6755164, 123, 5.71, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725375134.6755168, 179, 243.05000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 75, 1725375134.6755202, 101, 981.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6755209, 154, 807.58000000000004, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725375134.6755216, 26, 665.47000000000003, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725375134.6755221, 37, 685.16999999999996, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725375134.6755228, 100, 276.63, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6755233, 127, 577.0, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725375134.675524, 107, 686.54999999999995, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1, 1725375134.6755273, 143, 750.73000000000002, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.675528, 51, 976.62, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6755285, 59, 72.879999999999995, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725375134.6755292, 39, 471.07999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6755297, 75, 250.80000000000001, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725375134.6755304, 70, 257.33999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725375134.6755309, 38, 608.97000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 72, 1725375134.6755314, 125, 864.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6755321, 73, 300.87, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725375134.6755326, 180, 334.88999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725375134.6755333, 189, 341.32999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725375134.6755338, 125, 280.30000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725375134.6755345, 169, 845.90999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.675535, 160, 150.84999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725375134.6755376, 105, 603.80999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.6755383, 29, 308.26999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6755388, 66, 14.800000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6755395, 50, 717.97000000000003, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725375134.67554, 48, 196.36000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725375134.6755407, 185, 780.73000000000002, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.6755412, 172, 809.57000000000005, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.6755419, 48, 35.960000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725375134.6755424, 56, 775.16999999999996, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725375134.6755431, 180, 997.64999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725375134.6755435, 64, 249.09999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.675544, 178, 731.58000000000004, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725375134.6755447, 143, 726.66999999999996, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.6755452, 100, 630.90999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 49, 1725375134.6755481, 112, 969.62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725375134.6755486, 26, 703.53999999999996, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725375134.6755493, 34, 869.98000000000002, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725375134.6755497, 44, 507.67000000000002, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.6755505, 53, 623.30999999999995, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725375134.6755509, 137, 33.460000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6755517, 134, 849.76999999999998, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725375134.6755524, 177, 997.80999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725375134.6755528, 73, 898.29999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725375134.6755536, 61, 986.15999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.675554, 157, 709.36000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725375134.6755548, 85, 923.42999999999995, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.6755552, 195, 163.44, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725375134.6755557, 127, 680.07000000000005, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6755586, 168, 836.16999999999996, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6755593, 46, 846.75, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725375134.6755598, 181, 725.15999999999997, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725375134.6755605, 49, 979.33000000000004, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725375134.6755612, 157, 292.88999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725375134.6755617, 121, 822.15999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6755624, 119, 448.37, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725375134.6755629, 150, 899.25999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6755633, 198, 862.12, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.6755641, 188, 188.56999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725375134.6755645, 62, 531.46000000000004, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.6755652, 78, 447.14999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6755657, 138, 105.67, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725375134.6755664, 118, 72.680000000000007, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6755691, 61, 150.75999999999999, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6755695, 77, 326.27999999999997, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6755702, 150, 728.58000000000004, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 40, 1725375134.6755707, 58, 316.44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725375134.6755714, 105, 775.85000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6755719, 63, 978.36000000000001, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725375134.6755724, 136, 23.329999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.6755731, 55, 574.29999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725375134.6755736, 99, 382.42000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725375134.6755743, 176, 315.51999999999998, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725375134.6755748, 22, 548.72000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725375134.6755755, 25, 732.52999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725375134.675576, 134, 315.75999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6755767, 56, 814.51999999999998, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725375134.6755793, 73, 965.99000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725375134.6755798, 34, 570.50999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725375134.6755805, 90, 780.03999999999996, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725375134.6755807, 155, 490.95999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725375134.6755817, 76, 591.19000000000005, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725375134.6755819, 50, 923.04999999999995, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725375134.6755829, 196, 807.00999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 4, 1725375134.6755831, 160, 897.46000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 11, 1725375134.6755841, 32, 107.36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725375134.6755843, 86, 82.659999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725375134.675585, 198, 399.29000000000002, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725375134.6755855, 86, 344.93000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.6755862, 75, 220.06, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6755867, 67, 468.42000000000002, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725375134.6755886, 170, 466.88999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725375134.6755891, 159, 806.20000000000005, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725375134.67559, 57, 553.78999999999996, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725375134.6755905, 185, 871.59000000000003, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725375134.675591, 180, 382.85000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725375134.6755917, 197, 624.49000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725375134.6755922, 165, 374.12, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725375134.6755929, 152, 519.91999999999996, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725375134.6755934, 53, 51.25, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6755941, 27, 633.66999999999996, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725375134.6755948, 32, 340.10000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6755953, 66, 694.26999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6755958, 131, 34.619999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 32, 1725375134.6755991, 157, 518.63999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6755996, 99, 546.25, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725375134.6756003, 154, 783.28999999999996, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.675601, 194, 392.43000000000001, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725375134.6756015, 155, 339.91000000000003, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725375134.675602, 121, 677.57000000000005, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725375134.6756029, 81, 705.59000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725375134.6756032, 177, 605.34000000000003, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6756041, 67, 402.58999999999997, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6756043, 41, 871.94000000000005, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725375134.6756051, 22, 725.58000000000004, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725375134.6756055, 166, 566.17999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 83, 1725375134.6756065, 26, 85.909999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6756067, 139, 559.15999999999997, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725375134.6756101, 195, 406.56999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725375134.6756108, 48, 748.60000000000002, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725375134.6756113, 115, 236.84999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725375134.675612, 161, 336.85000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725375134.6756127, 85, 302.49000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.6756132, 32, 834.30999999999995, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725375134.6756136, 196, 287.66000000000003, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 45, 1725375134.6756144, 87, 222.25999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725375134.6756148, 105, 218.12, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725375134.6756155, 156, 71.769999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725375134.675616, 179, 528.25999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725375134.6756167, 105, 10.869999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725375134.6756172, 84, 768.37, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725375134.6756177, 189, 657.88, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725375134.6756208, 66, 504.58999999999997, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725375134.6756213, 139, 461.41000000000003, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 34, 1725375134.675622, 40, 918.92999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725375134.6756225, 74, 502.39999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725375134.6756232, 191, 797.00999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725375134.6756237, 110, 631.20000000000005, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725375134.6756244, 128, 300.14999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725375134.6756248, 92, 553.29999999999995, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725375134.6756256, 116, 382.44, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725375134.675626, 158, 868.76999999999998, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725375134.6756268, 83, 884.16999999999996, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725375134.6756272, 123, 86.459999999999994, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725375134.6756279, 40, 785.46000000000004, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725375134.6756284, 97, 293.64999999999998, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725375134.6756291, 54, 955.35000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6756318, 78, 240.03999999999999, 19 });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_AspNetUsers_UserId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_UserId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "fab1c687-2e21-43a3-b791-83c6d02451ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b5d403e5-a70d-495f-ac9e-75595a138d45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "8c1ad43b-5982-4dff-9efe-a8791f78d380");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "d2420ee5-b129-46be-a1fd-81c9cd463965");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "5c9657cb-eceb-4c9c-9cdf-eb651bfd3225");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1725355865.9592681);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1725355865.9592683);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1725355865.9592683);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1725355865.9592683);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1725355865.9592686);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1725355865.9592688);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1725355865.9592688);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1725355865.9592688);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1725355865.9592688);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1725355865.959269);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1725355865.9592693);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1725355865.9592693);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1725355865.9592693);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1725355865.9592693);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1725355865.9592693);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1725355865.9592695);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1725355865.9592695);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1725355865.9592695);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1725355865.9592695);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1725355865.9592698);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1725355865.95927);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1725355865.95927);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1725355865.95927);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1725355865.95927);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1725355865.9592702);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1725355865.9592705);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1725355865.9592705);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1725355865.9592705);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1725355865.9592705);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1725355865.9592707);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1725355865.9592707);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1725355865.9592707);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1725355865.9592707);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1725355865.9592707);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1725355865.959271);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1725355865.959271);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1725355865.9592712);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1725355865.9592712);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1725355865.9592712);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1725355865.9592714);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1725355865.9592576);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1725355865.9592583);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1725355865.9592583);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1725355865.9592586);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1725355865.9592588);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1725355865.9592588);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1725355865.9592588);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1725355865.9592588);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1725355865.959259);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1725355865.9592593);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1725355865.9592593);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1725355865.9592593);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1725355865.9592595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1725355865.9592595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1725355865.9592595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1725355865.9592595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1725355865.9592595);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1725355865.9592597);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1725355865.9592636);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1725355865.9592638);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1725355865.9592638);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1725355865.959264);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9592741, 149, 604.54999999999995, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725355865.9592831, 169, 246.53999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725355865.9592843, 179, 816.71000000000004, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.959285, 138, 697.15999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725355865.9592855, 94, 68.849999999999994, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725355865.9592865, 63, 817.32000000000005, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725355865.9592893, 107, 28.050000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.95929, 45, 514.17999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725355865.9592905, 128, 701.01999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725355865.9592915, 155, 61.340000000000003, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 43, 1725355865.9592924, 149, 126.95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.9592929, 144, 979.55999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725355865.9592936, 80, 299.10000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725355865.9592943, 142, 372.82999999999998, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725355865.959295, 68, 478.70999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.9592955, 291.30000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.9592962, 92, 507.79000000000002, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725355865.9592967, 24, 998.17999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725355865.9592977, 128, 893.63999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9592981, 163, 541.62, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725355865.9593024, 103, 231.16, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725355865.9593029, 142, 227.71000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725355865.9593036, 87, 270.94, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.9593041, 192, 539.32000000000005, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9593048, 35, 630.02999999999997, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725355865.9593055, 62, 671.39999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725355865.959306, 101, 701.95000000000005, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725355865.9593067, 51, 605.41999999999996, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725355865.9593074, 158, 319.25, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725355865.9593079, 93, 881.07000000000005, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725355865.9593086, 145, 270.32999999999998, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.9593091, 67, 806.38999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725355865.9593098, 149, 588.00999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725355865.9593129, 164, 974.90999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9593136, 184, 648.90999999999997, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725355865.9593143, 108, 678.09000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725355865.9593153, 127, 419.19999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9593158, 86, 447.54000000000002, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725355865.9593165, 92, 98.219999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.959317, 153, 661.5, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725355865.9593177, 97, 562.13, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725355865.9593184, 688.53999999999996, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725355865.9593189, 113, 182.09999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725355865.9593196, 175, 234.21000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725355865.9593201, 107, 893.46000000000004, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725355865.9593208, 164, 798.13999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725355865.9593215, 54, 34.159999999999997, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725355865.9593234, 105, 925.74000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725355865.9593239, 120, 977.77999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.9593248, 149, 787.28999999999996, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9593253, 196, 285.36000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725355865.959326, 153, 887.63999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725355865.9593267, 164, 391.67000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725355865.9593272, 92, 549.15999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9593279, 136, 441.16000000000003, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725355865.9593284, 43, 756.35000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725355865.9593291, 105, 958.89999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725355865.9593298, 147, 33.549999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725355865.9593303, 119, 237.41, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725355865.959331, 128, 992.64999999999998, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9593315, 98, 269.31, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725355865.9593363, 185, 87.090000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9593372, 176, 619.36000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725355865.9593377, 131, 396.12, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725355865.9593384, 22, 693.40999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 1725355865.9593391, 36, 135.86000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9593399, 33, 349.64999999999998, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725355865.9593403, 187, 398.66000000000003, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9593413, 78, 854.54999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725355865.9593418, 151, 279.29000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725355865.9593425, 90, 612.89999999999998, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.959343, 47, 598.26999999999998, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725355865.9593437, 125, 999.49000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 61, 1725355865.9593475, 146, 151.72999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9593484, 103, 529.23000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725355865.9593489, 188, 493.81999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9593496, 196, 389.93000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9593503, 145, 279.33999999999997, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9593508, 160, 607.20000000000005, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.9593515, 186, 230.31999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.9593523, 156, 473.45999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725355865.9593527, 195, 780.19000000000005, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9593537, 133, 866.39999999999998, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725355865.9593542, 157, 82.459999999999994, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725355865.9593549, 67, 897.0, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725355865.9593556, 129, 675.58000000000004, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 32, 1725355865.9593561, 50, 145.69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9593568, 54, 398.58999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725355865.9593599, 98, 766.22000000000003, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725355865.9593604, 64, 777.52999999999997, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725355865.9593613, 133, 806.16999999999996, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725355865.9593618, 194, 692.98000000000002, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725355865.9593625, 82, 768.89999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725355865.959363, 26, 11.85, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9593637, 92, 277.44, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725355865.9593644, 93, 570.22000000000003, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 57, 1725355865.9593649, 108, 260.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9593656, 112, 914.28999999999996, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725355865.9593661, 22, 325.45999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9593668, 183, 282.47000000000003, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725355865.9593675, 111, 350.72000000000003, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725355865.9593682, 103, 568.40999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9593711, 67, 282.22000000000003, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.959372, 174, 57.149999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725355865.9593725, 138, 926.96000000000004, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 58, 1725355865.9593732, 102, 347.99000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725355865.959374, 184, 52.939999999999998, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailableStock", "Created", "Price" },
                values: new object[] { 4, 1725355865.9593747, 21.800000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725355865.9593751, 154, 599.62, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725355865.9593759, 101, 492.49000000000001, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725355865.9593763, 96, 653.03999999999996, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725355865.9593773, 169, 609.51999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725355865.9593775, 143, 29.41, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9593785, 49, 252.58000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725355865.959379, 199, 875.30999999999995, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725355865.9593797, 127, 241.62, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 23, 1725355865.9593828, 57, 294.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725355865.9593835, 113, 50.619999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725355865.959384, 119, 816.37, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9593849, 79, 411.98000000000002, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 54, 1725355865.9593854, 44, 612.01999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725355865.9593861, 153, 996.27999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725355865.9593866, 129, 300.62, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725355865.9593873, 161, 101.72, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725355865.959388, 23, 857.61000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725355865.9593885, 159, 407.83999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725355865.9593892, 186, 754.87, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 37, 1725355865.9593897, 32, 791.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725355865.9593904, 30, 972.84000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725355865.9593935, 24, 849.90999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.9593942, 37, 884.66999999999996, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 63, 1725355865.9593947, 121, 946.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.9593956, 24, 360.33999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725355865.9593961, 180, 262.06999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9593968, 130, 627.63999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725355865.9593973, 168, 277.14999999999998, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725355865.959398, 129, 380.67000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.9593987, 33, 238.43000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725355865.9593992, 177, 103.62, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725355865.9593999, 172, 680.48000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 96, 1725355865.959403, 26, 600.78999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.9594035, 194, 529.25, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9594045, 103, 19.920000000000002, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725355865.9594047, 89, 8.7100000000000009, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9594057, 150, 551.17999999999995, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725355865.9594061, 153, 529.13999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725355865.9594069, 110, 252.49000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725355865.9594073, 28, 997.14999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.959408, 145, 934.0, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.9594088, 26, 174.24000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725355865.9594095, 143, 605.62, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.95941, 178, 458.27999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725355865.9594107, 146, 880.15999999999997, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725355865.9594111, 160, 68.659999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9594133, 111, 208.25999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725355865.9594138, 159, 395.0, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9594145, 112, 47.350000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.959415, 114, 41.170000000000002, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725355865.9594157, 51, 12.789999999999999, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725355865.9594164, 164, 644.75999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725355865.9594169, 53, 771.48000000000002, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725355865.9594176, 124, 119.13, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725355865.9594181, 117, 154.25, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725355865.9594188, 87, 783.38999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725355865.9594195, 152, 757.09000000000003, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725355865.95942, 72, 176.19999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725355865.9594207, 44, 732.42999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725355865.9594212, 174, 442.55000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725355865.9594245, 112, 433.56, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725355865.9594252, 68, 926.76999999999998, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725355865.9594259, 92, 611.53999999999996, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594266, 105, 336.06, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594271, 89, 683.92999999999995, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594281, 32, 89.629999999999995, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725355865.9594283, 123, 848.86000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9594293, 119, 891.87, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9594295, 113, 833.77999999999997, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9594305, 108, 850.75999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725355865.9594307, 133, 321.0, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725355865.9594316, 76, 849.36000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9594321, 176, 119.0, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725355865.9594328, 57, 463.62, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 7, 1725355865.9594381, 77, 426.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725355865.9594383, 130, 64.209999999999994, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725355865.9594393, 144, 345.91000000000003, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725355865.9594398, 95, 432.85000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9594405, 123, 456.70999999999998, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725355865.9594409, 158, 177.31, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594417, 61, 811.89999999999998, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725355865.9594424, 89, 769.10000000000002, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.9594429, 83, 214.18000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725355865.9594436, 62, 443.81, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 48, 1725355865.959444, 58, 880.28999999999996, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725355865.9594448, 198, 583.76999999999998, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725355865.9594455, 64, 138.63999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725355865.959446, 97, 18.68, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725355865.9594488, 196, 683.82000000000005, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725355865.9594495, 134, 414.18000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725355865.9594502, 131, 322.33999999999997, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725355865.9594507, 31, 620.65999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725355865.9594517, 164, 276.69, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.9594519, 110, 251.46000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725355865.9594529, 118, 390.69999999999999, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725355865.9594533, 189, 314.62, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725355865.9594541, 165, 83.799999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594548, 61, 464.80000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.9594553, 85, 509.52999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.959456, 146, 801.62, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9594564, 117, 491.64999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725355865.9594572, 131, 988.66999999999996, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9594595, 94, 282.49000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725355865.9594605, 143, 794.55999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 95, 1725355865.9594607, 40, 646.01999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.9594617, 114, 74.920000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725355865.9594619, 145, 493.50999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.9594629, 185, 421.25, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.9594634, 150, 707.75, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9594641, 109, 196.38, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9594646, 167, 246.97, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 67, 1725355865.9594653, 148, 932.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725355865.9594657, 131, 844.40999999999997, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725355865.9594665, 132, 923.96000000000004, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 70, 1725355865.9594672, 123, 910.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.9594676, 132, 957.47000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725355865.9594705, 174, 666.72000000000003, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725355865.959471, 60, 515.52999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725355865.9594717, 86, 544.27999999999997, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.9594724, 187, 751.39999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725355865.9594729, 90, 608.17999999999995, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725355865.9594736, 69, 439.52999999999997, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725355865.9594741, 42, 343.50999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725355865.9594748, 75, 961.42999999999995, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9594755, 66, 714.57000000000005, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725355865.959476, 60, 591.27999999999997, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725355865.9594767, 167, 449.56999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725355865.9594772, 174, 146.77000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725355865.9594779, 90, 575.74000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725355865.9594784, 79, 689.41999999999996, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725355865.959481, 127, 583.91999999999996, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725355865.9594817, 116, 635.67999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725355865.9594824, 153, 727.07000000000005, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725355865.9594829, 132, 834.70000000000005, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9594836, 199, 310.17000000000002, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725355865.9594841, 751.14999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725355865.9594848, 34, 719.70000000000005, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725355865.9594855, 126, 777.46000000000004, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.959486, 140, 98.680000000000007, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725355865.9594867, 96, 12.630000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725355865.9594874, 82, 626.84000000000003, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725355865.9594879, 139, 252.02000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9594886, 84, 305.55000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725355865.9594891, 44, 81.260000000000005, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 49, 1725355865.9594917, 152, 606.89999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725355865.9594924, 31, 698.16999999999996, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725355865.9594932, 107, 892.05999999999995, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725355865.9594936, 53, 431.39999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725355865.9594944, 127, 564.54999999999995, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.9594953, 102, 710.25, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725355865.9594955, 138, 494.42000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.9594977, 155, 810.34000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725355865.9594984, 134, 830.25999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9594989, 186, 528.40999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9594996, 189, 660.88999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725355865.9595003, 104, 753.15999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.9595008, 165, 516.51999999999998, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725355865.9595015, 175, 779.11000000000001, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 59, 1725355865.9595022, 34, 705.78999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725355865.9595027, 99, 444.69, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725355865.9595034, 99, 246.25999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725355865.9595039, 93, 495.72000000000003, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725355865.9595048, 170, 848.00999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9595051, 42, 550.58000000000004, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725355865.959506, 156, 124.14, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9595091, 94, 947.34000000000003, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725355865.9595101, 131, 17.559999999999999, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725355865.9595106, 180, 735.46000000000004, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725355865.9595113, 162, 968.98000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725355865.959512, 169, 780.12, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725355865.9595125, 165, 953.65999999999997, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725355865.9595132, 116, 292.91000000000003, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725355865.9595139, 157, 103.56999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9595144, 98, 396.74000000000001, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725355865.9595151, 178, 734.17999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725355865.9595156, 89, 837.40999999999997, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9595163, 180, 311.14999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.9595168, 173, 491.83999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.9595177, 131, 347.92000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 93, 1725355865.9595208, 128, 886.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725355865.9595215, 73, 289.97000000000003, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725355865.959522, 95, 44.039999999999999, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725355865.9595227, 141, 315.67000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.9595234, 95, 270.26999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725355865.9595239, 75, 698.32000000000005, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725355865.9595249, 111, 5.0800000000000001, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.9595251, 87, 427.19, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725355865.9595261, 156, 130.55000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725355865.9595263, 181, 292.32999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725355865.9595273, 64, 747.42999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725355865.9595275, 42, 381.23000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725355865.9595284, 122, 606.10000000000002, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725355865.9595289, 188, 616.65999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725355865.9595315, 171, 113.22, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725355865.959532, 41, 569.71000000000004, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725355865.9595327, 95, 123.65000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725355865.9595335, 195, 679.79999999999995, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725355865.9595339, 98, 390.25, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.9595349, 102, 776.38999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725355865.9595351, 120, 123.15000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725355865.9595361, 24, 325.66000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725355865.9595366, 123, 421.07999999999998, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725355865.9595373, 57, 399.52999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725355865.9595377, 125, 317.76999999999998, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725355865.9595385, 155, 280.61000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9595392, 145, 962.23000000000002, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9595397, 63, 838.66999999999996, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725355865.9595423, 53, 304.22000000000003, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725355865.9595428, 42, 866.27999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725355865.9595437, 130, 264.45999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 80, 1725355865.9595439, 165, 103.33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.9595449, 174, 677.04999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725355865.9595454, 112, 902.25, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725355865.9595461, 53, 54.659999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725355865.9595468, 50, 387.57999999999998, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725355865.9595473, 75, 610.03999999999996, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725355865.959548, 114, 473.48000000000002, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725355865.9595487, 91, 812.30999999999995, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.9595494, 83, 942.13999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9595499, 186, 502.89999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725355865.9595509, 134, 15.32, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725355865.9595532, 182, 809.39999999999998, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725355865.959554, 157, 762.29999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725355865.9595544, 80, 934.65999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725355865.9595551, 150, 448.30000000000001, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725355865.9595556, 88, 285.12, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725355865.9595563, 29, 433.48000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725355865.9595571, 90, 638.25, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 68, 1725355865.9595575, 67, 634.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 66, 1725355865.9595585, 151, 176.46000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9595587, 35, 811.62, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725355865.9595597, 54, 845.77999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725355865.9595599, 130, 902.70000000000005, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725355865.9595609, 30, 734.63999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725355865.9595613, 191, 885.12, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.959564, 146, 13.720000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.9595647, 198, 35.649999999999999, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9595652, 193, 463.57999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725355865.9595661, 149, 433.04000000000002, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725355865.9595664, 104, 515.88, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725355865.9595673, 31, 523.77999999999997, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725355865.9595678, 91, 268.94999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725355865.9595685, 94, 628.38, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725355865.959569, 75, 180.66999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725355865.9595697, 135, 363.06999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725355865.9595702, 126, 451.91000000000003, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725355865.9595709, 91, 299.69999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725355865.9595714, 93, 244.93000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 63, 1725355865.9595721, 60, 673.95000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725355865.9595747, 150, 512.76999999999998, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725355865.9595754, 112, 568.64999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725355865.9595759, 81, 414.29000000000002, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725355865.9595768, 179, 819.27999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725355865.9595773, 154, 931.88, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725355865.959578, 194, 680.5, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725355865.9595788, 113, 706.51999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725355865.9595792, 78, 41.270000000000003, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.9595799, 163, 311.81999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725355865.9595809, 173, 71.790000000000006, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725355865.9595814, 178, 727.85000000000002, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 10, 1725355865.9595821, 22, 4.3300000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725355865.9595828, 70, 426.69, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725355865.9595833, 54, 516.90999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725355865.9595857, 143, 920.63999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725355865.9595861, 159, 164.05000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725355865.9595869, 94, 322.93000000000001, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725355865.9595876, 102, 584.49000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725355865.9595883, 117, 177.56, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725355865.9595888, 153, 678.08000000000004, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 79, 1725355865.9595895, 116, 852.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725355865.95959, 120, 388.26999999999998, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725355865.9595909, 96, 70.090000000000003, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725355865.9595912, 83, 580.16999999999996, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725355865.9595921, 69, 899.26999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725355865.9595926, 120, 277.79000000000002, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725355865.9595933, 114, 915.44000000000005, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725355865.9595938, 88, 517.09000000000003, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725355865.9595993, 98, 485.44, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 27, 1725355865.9595997, 63, 403.93000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725355865.9596004, 28, 108.73, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725355865.9596012, 35, 150.78999999999999, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725355865.9596016, 91, 283.82999999999998, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1, 1725355865.9596024, 155, 120.97, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725355865.9596031, 25, 943.57000000000005, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725355865.9596035, 195, 714.83000000000004, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725355865.9596043, 80, 732.97000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725355865.9596047, 69, 869.01999999999998, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725355865.9596055, 72, 875.25, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725355865.9596059, 85, 207.78, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725355865.9596066, 54, 572.55999999999995, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725355865.9596071, 114, 270.82999999999998, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725355865.9596105, 58, 615.61000000000001, 14 });
        }
    }
}
