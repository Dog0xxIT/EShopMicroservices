using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AvatarLink",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "25370bec-6f93-4cfe-a183-31894d5da48f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e981bf4d-fc78-45c5-b68e-9171bbf4054d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "eb0abebb-ec19-4c4e-b431-f5ee7e9346c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "61d0e61b-8481-49a5-971e-50b4270fac40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "2049b05e-3657-4414-8eb4-b37ebe06ffe3");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556681 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556684 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556684 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556688 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556688 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556688 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556691 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556693 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556693 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556693 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556693 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556695 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556695 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556695 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556695 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556698 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.55567 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.55567 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.55567 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556731 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556734 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556736 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556736 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556736 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556736 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556738 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556741 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556741 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556741 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556743 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556743 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556743 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556743 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556746 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556746 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556748 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556748 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556748 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.555675 });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvatarLink", "Created" },
                values: new object[] { "", 1725613142.5556753 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556607, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556619, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556619, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556622, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556624, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556624, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556626, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556629, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556629, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556629, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556629, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556631, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556631, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556633, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556636, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556636, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556636, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556638, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556638, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556641, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556641, "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Icon" },
                values: new object[] { 1725613142.5556641, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725613142.5556779, 0.0, 61, 817.54999999999995, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725613142.5556867, 0.0, 151, 243.68000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5556879, 0.0, 45, 968.22000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725613142.5556884, 0.0, 190, 480.58999999999997, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725613142.5556891, 0.0, 184, 193.13999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725613142.5556901, 0.0, 86, 282.05000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725613142.5556905, 0.0, 124, 684.74000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725613142.5556912, 0.0, 154, 127.87, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725613142.555692, 0.0, 146, 867.57000000000005, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725613142.5556927, 0.0, 62, 783.09000000000003, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 59, 1725613142.5556955, 0.0, 137, 62.969999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5556965, 0.0, 184, 361.22000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725613142.5556972, 0.0, 176, 940.61000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725613142.5556977, 0.0, 98, 604.37, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725613142.5556984, 0.0, 178, 446.89999999999998, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725613142.5556991, 0.0, 51, 12.52, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725613142.5556996, 0.0, 74, 987.02999999999997, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725613142.5557003, 0.0, 197, 953.53999999999996, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5557013, 0.0, 120, 298.19, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5557017, 0.0, 161, 146.03, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5557024, 0.0, 181, 801.62, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5557029, 0.0, 38, 99.780000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725613142.5557036, 0.0, 62, 525.38999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725613142.5557063, 0.0, 163, 514.30999999999995, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725613142.5557067, 0.0, 194, 362.38999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725613142.5557077, 0.0, 72, 567.99000000000001, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5557082, 0.0, 119, 666.97000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725613142.5557089, 0.0, 190, 283.44999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725613142.5557096, 0.0, 181, 296.27999999999997, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725613142.5557101, 0.0, 46, 463.88999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725613142.5557106, 0.0, 71, 659.86000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725613142.5557113, 0.0, 57, 53.359999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725613142.555712, 0.0, 26, 362.79000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5557127, 0.0, 190, 186.19, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725613142.5557132, 0.0, 58, 325.22000000000003, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725613142.5557139, 0.0, 119, 323.70999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5557165, 0.0, 112, 461.72000000000003, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5557172, 0.0, 97, 184.46000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5557177, 0.0, 131, 182.59999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725613142.5557184, 0.0, 72, 295.68000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725613142.5557189, 0.0, 155, 481.0, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725613142.5557196, 0.0, 112, 459.67000000000002, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.5557201, 0.0, 41, 644.91999999999996, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725613142.5557208, 0.0, 109, 726.54999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725613142.5557215, 0.0, 91, 524.37, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725613142.555722, 0.0, 96, 964.50999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725613142.5557227, 0.0, 95, 867.79999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725613142.5557232, 0.0, 127, 897.53999999999996, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725613142.5557239, 0.0, 152, 371.75, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725613142.5557246, 0.0, 179, 622.38999999999999, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725613142.5557272, 0.0, 43, 728.59000000000003, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.555728, 0.0, 155, 317.27999999999997, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725613142.5557284, 0.0, 149, 215.63, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725613142.5557292, 0.0, 85, 325.42000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5557296, 0.0, 135, 349.97000000000003, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725613142.5557303, 0.0, 149, 175.47999999999999, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725613142.5557311, 0.0, 114, 843.98000000000002, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725613142.5557315, 0.0, 45, 147.41, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725613142.5557323, 0.0, 149, 713.21000000000004, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725613142.5557327, 0.0, 77, 12.43, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725613142.5557334, 0.0, 168, 648.29999999999995, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725613142.5557339, 0.0, 117, 169.27000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725613142.5557346, 0.0, 38, 801.30999999999995, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725613142.5557351, 0.0, 73, 657.24000000000001, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725613142.5557375, 0.0, 173, 391.91000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5557384, 0.0, 58, 209.81, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725613142.5557389, 0.0, 68, 106.01000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725613142.5557396, 0.0, 35, 597.80999999999995, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725613142.5557401, 0.0, 108, 681.73000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725613142.5557408, 0.0, 83, 12.92, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725613142.5557413, 0.0, 59, 195.12, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725613142.555742, 0.0, 188, 819.78999999999996, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5557425, 0.0, 71, 548.99000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725613142.5557432, 0.0, 175, 35.579999999999998, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725613142.5557437, 0.0, 72, 415.33999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725613142.5557444, 0.0, 80, 346.31999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725613142.5557449, 0.0, 166, 501.58999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725613142.5557468, 0.0, 135, 989.41999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725613142.5557475, 0.0, 136, 942.42999999999995, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725613142.555748, 0.0, 137, 12.77, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 33, 1725613142.5557487, 0.0, 159, 858.36000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725613142.5557494, 0.0, 147, 410.24000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 4, 1725613142.5557499, 0.0, 152, 782.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 67, 1725613142.5557506, 0.0, 175, 648.88, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725613142.5557511, 0.0, 171, 802.74000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 52, 1725613142.5557518, 0.0, 197, 256.45999999999998, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725613142.5557525, 0.0, 69, 895.5, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725613142.555753, 0.0, 125, 606.37, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725613142.5557537, 0.0, 31, 236.81, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725613142.5557542, 0.0, 106, 894.94000000000005, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725613142.5557578, 0.0, 78, 864.5, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 4, 1725613142.5557585, 0.0, 179, 286.97000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725613142.5557592, 0.0, 66, 440.06999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725613142.5557597, 0.0, 198, 994.29999999999995, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725613142.5557604, 0.0, 199, 206.47, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725613142.5557609, 0.0, 141, 961.45000000000005, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725613142.5557616, 0.0, 42, 525.40999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5557621, 0.0, 84, 370.61000000000001, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725613142.5557628, 0.0, 103, 771.88, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725613142.5557632, 0.0, 145, 404.10000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725613142.555764, 0.0, 180, 103.77, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725613142.5557647, 0.0, 39, 811.55999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725613142.5557652, 0.0, 137, 903.88999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5557656, 0.0, 196, 316.60000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725613142.5557692, 0.0, 90, 43.609999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725613142.5557697, 0.0, 47, 246.78999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725613142.5557704, 0.0, 192, 783.60000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725613142.5557711, 0.0, 57, 310.30000000000001, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725613142.5557716, 0.0, 125, 717.62, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725613142.5557723, 0.0, 116, 873.69000000000005, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5557728, 0.0, 167, 977.88, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725613142.5557735, 0.0, 178, 117.97, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725613142.5557742, 0.0, 57, 229.59, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 48, 1725613142.5557747, 0.0, 106, 501.64999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725613142.5557754, 0.0, 154, 378.52999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725613142.5557759, 0.0, 35, 671.12, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5557766, 0.0, 156, 952.30999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5557773, 0.0, 109, 687.30999999999995, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 94, 1725613142.5557797, 0.0, 118, 121.64, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5557804, 0.0, 109, 728.25, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.5557809, 0.0, 41, 581.96000000000004, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 47, 1725613142.5557816, 0.0, 186, 806.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 3, 1725613142.5557823, 0.0, 47, 737.27999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725613142.5557828, 0.0, 63, 134.81999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725613142.5557835, 0.0, 185, 868.23000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 48, 1725613142.5557842, 0.0, 155, 153.47, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725613142.5557847, 0.0, 100, 658.62, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725613142.5557854, 0.0, 176, 974.75999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725613142.5557859, 0.0, 147, 167.13, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5557888, 0.0, 109, 277.63, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5557897, 0.0, 39, 821.16999999999996, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725613142.5557899, 0.0, 163, 545.32000000000005, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725613142.5557909, 0.0, 62, 510.56, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725613142.5557911, 0.0, 190, 484.55000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.5557921, 0.0, 165, 20.640000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725613142.5557923, 0.0, 185, 168.87, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5557933, 0.0, 183, 63.979999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5557938, 0.0, 77, 501.35000000000002, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725613142.5557945, 0.0, 96, 34.439999999999998, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725613142.555795, 0.0, 136, 196.83000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725613142.5557957, 0.0, 121, 817.28999999999996, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5557961, 0.0, 123, 373.23000000000002, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725613142.5557992, 0.0, 110, 586.63999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725613142.5558, 0.0, 168, 935.95000000000005, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725613142.5558007, 0.0, 70, 253.38999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725613142.5558012, 0.0, 105, 780.75999999999999, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.5558019, 0.0, 84, 306.48000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725613142.5558023, 0.0, 144, 990.21000000000004, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725613142.5558033, 0.0, 123, 752.46000000000004, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5558035, 0.0, 63, 229.11000000000001, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5558045, 0.0, 108, 482.31999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.5558047, 0.0, 166, 940.83000000000004, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5558057, 0.0, 127, 537.13999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725613142.5558059, 0.0, 145, 295.76999999999998, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725613142.5558069, 0.0, 133, 173.09999999999999, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725613142.5558071, 0.0, 160, 387.01999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725613142.5558107, 0.0, 72, 106.54000000000001, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725613142.5558116, 0.0, 71, 616.66999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.5558119, 0.0, 174, 453.0, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 13, 1725613142.5558128, 0.0, 71, 402.67000000000002, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725613142.5558133, 0.0, 199, 924.04999999999995, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.555814, 0.0, 76, 577.33000000000004, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725613142.5558145, 0.0, 170, 84.840000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725613142.5558152, 0.0, 156, 317.44999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5558159, 0.0, 140, 533.25, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725613142.5558164, 0.0, 171, 950.87, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 95, 1725613142.5558171, 0.0, 42, 737.45000000000005, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725613142.5558176, 0.0, 45, 845.88, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725613142.5558183, 0.0, 148, 925.51999999999998, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725613142.5558188, 0.0, 147, 661.42999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 53, 1725613142.5558221, 0.0, 130, 141.33000000000001, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5558228, 0.0, 80, 223.41, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5558233, 0.0, 138, 504.81999999999999, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725613142.555824, 0.0, 44, 681.46000000000004, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725613142.5558248, 0.0, 144, 448.5, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725613142.5558252, 0.0, 67, 465.06999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725613142.5558259, 0.0, 149, 982.77999999999997, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725613142.5558267, 0.0, 141, 593.52999999999997, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725613142.5558271, 0.0, 111, 485.24000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725613142.5558281, 0.0, 164, 387.38999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 3, 1725613142.5558283, 0.0, 173, 212.56999999999999, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5558293, 0.0, 50, 21.09, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725613142.5558295, 0.0, 98, 766.80999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 74, 1725613142.5558324, 0.0, 127, 519.25999999999999, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 19, 1725613142.5558331, 0.0, 32, 80.140000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5558336, 0.0, 40, 977.52999999999997, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5558343, 0.0, 96, 449.14999999999998, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725613142.5558348, 0.0, 84, 904.00999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.5558355, 0.0, 143, 526.22000000000003, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 66, 1725613142.555836, 0.0, 160, 556.78999999999996, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 20, 1725613142.5558369, 0.0, 198, 576.54999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725613142.5558374, 0.0, 29, 835.10000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5558381, 0.0, 52, 670.71000000000004, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1, 1725613142.5558383, 0.0, 55, 289.25, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725613142.5558393, 0.0, 63, 676.79999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725613142.5558395, 0.0, 122, 623.64999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725613142.5558405, 0.0, 105, 543.51999999999998, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725613142.5558431, 0.0, 70, 447.56, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725613142.5558436, 0.0, 91, 766.67999999999995, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725613142.5558443, 0.0, 191, 839.77999999999997, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725613142.555845, 0.0, 23, 868.80999999999995, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 95, 1725613142.5558455, 0.0, 40, 625.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 63, 1725613142.5558465, 0.0, 94, 562.24000000000001, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725613142.5558467, 0.0, 104, 83.730000000000004, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725613142.5558474, 0.0, 118, 906.80999999999995, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5558479, 0.0, 183, 455.44, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 18, 1725613142.5558486, 0.0, 53, 562.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725613142.5558493, 0.0, 112, 818.33000000000004, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725613142.55585, 0.0, 47, 325.31999999999999, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 44, 1725613142.5558505, 0.0, 64, 211.68000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725613142.5558512, 0.0, 47, 356.89999999999998, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725613142.5558538, 0.0, 180, 747.38999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 70, 1725613142.5558543, 0.0, 194, 400.60000000000002, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5558553, 0.0, 183, 286.13, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 93, 1725613142.5558555, 0.0, 189, 187.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725613142.5558565, 0.0, 126, 321.74000000000001, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 30, 1725613142.5558569, 0.0, 159, 665.92999999999995, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5558577, 0.0, 136, 403.81999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725613142.5558581, 0.0, 36, 522.64999999999998, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725613142.5558589, 0.0, 107, 911.15999999999997, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725613142.5558593, 0.0, 100, 601.22000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725613142.55586, 0.0, 47, 806.74000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725613142.5558605, 0.0, 144, 584.44000000000005, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 85, 1725613142.5558612, 0.0, 73, 609.88999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725613142.5558617, 0.0, 30, 133.87, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725613142.5558643, 0.0, 49, 602.59000000000003, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.555865, 0.0, 194, 57.280000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5558655, 0.0, 40, 730.41999999999996, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725613142.5558665, 0.0, 180, 546.17999999999995, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5558667, 0.0, 106, 647.37, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5558677, 0.0, 107, 728.92999999999995, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725613142.5558679, 0.0, 199, 485.0, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725613142.5558689, 0.0, 115, 173.86000000000001, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.5558691, 0.0, 188, 243.49000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725613142.5558701, 0.0, 94, 141.53999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725613142.5558703, 0.0, 52, 607.41999999999996, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 69, 1725613142.5558712, 0.0, 43, 861.05999999999995, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5558715, 0.0, 92, 948.62, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725613142.5558724, 0.0, 61, 77.099999999999994, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725613142.5558753, 0.0, 158, 841.19000000000005, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725613142.5558758, 0.0, 100, 234.91, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 75, 1725613142.5558765, 0.0, 68, 542.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725613142.555877, 0.0, 49, 54.479999999999997, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.5558777, 0.0, 195, 930.73000000000002, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.5558784, 0.0, 40, 633.34000000000003, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725613142.5558789, 0.0, 45, 904.17999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725613142.5558796, 0.0, 50, 458.50999999999999, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725613142.5558801, 0.0, 29, 535.24000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725613142.5558808, 0.0, 198, 2.0099999999999998, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725613142.5558813, 0.0, 74, 553.00999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725613142.555882, 0.0, 166, 992.98000000000002, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5558825, 0.0, 174, 558.91999999999996, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 17, 1725613142.5558832, 0.0, 178, 110.56, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725613142.5558853, 0.0, 85, 167.81999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725613142.5558856, 0.0, 78, 925.91999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5558865, 0.0, 33, 430.06999999999999, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5558867, 0.0, 142, 179.53999999999999, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725613142.5558877, 0.0, 80, 747.13999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725613142.5558884, 0.0, 170, 284.79000000000002, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725613142.5558915, 0.0, 145, 104.48999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725613142.5558922, 0.0, 121, 979.52999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725613142.5558927, 0.0, 184, 82.569999999999993, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725613142.5558937, 0.0, 118, 324.93000000000001, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725613142.5558939, 0.0, 97, 855.54999999999995, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725613142.5558949, 0.0, 95, 993.57000000000005, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725613142.5558951, 0.0, 48, 141.27000000000001, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 8, 1725613142.555896, 0.0, 50, 740.38999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.5558963, 0.0, 122, 69.670000000000002, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 89, 1725613142.5558972, 0.0, 54, 92.239999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725613142.5558977, 0.0, 58, 74.299999999999997, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725613142.5558984, 0.0, 53, 186.27000000000001, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725613142.5558989, 0.0, 134, 381.17000000000002, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725613142.5558996, 0.0, 133, 459.39999999999998, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725613142.555903, 0.0, 179, 777.55999999999995, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725613142.5559037, 0.0, 62, 614.52999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailableStock", "Created", "Discount", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.5559042, 0.0, 553.77999999999997, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5559049, 0.0, 55, 720.20000000000005, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725613142.5559053, 0.0, 136, 704.37, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5559061, 0.0, 103, 16.039999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725613142.5559065, 0.0, 23, 997.14999999999998, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725613142.5559072, 0.0, 79, 572.59000000000003, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 21, 1725613142.5559077, 0.0, 33, 915.97000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725613142.5559084, 0.0, 160, 525.52999999999997, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 81, 1725613142.5559089, 0.0, 50, 863.40999999999997, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725613142.5559096, 0.0, 135, 492.88999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725613142.5559101, 0.0, 193, 580.03999999999996, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 94, 1725613142.5559108, 0.0, 20, 800.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725613142.5559137, 0.0, 194, 299.82999999999998, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725613142.5559144, 0.0, 104, 410.11000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 49, 1725613142.5559149, 0.0, 54, 154.24000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725613142.5559156, 0.0, 24, 532.29999999999995, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5559161, 0.0, 63, 380.85000000000002, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5559168, 0.0, 110, 260.23000000000002, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725613142.5559173, 0.0, 185, 255.94999999999999, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 97, 1725613142.555918, 0.0, 39, 772.61000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 68, 1725613142.5559185, 0.0, 102, 220.81, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725613142.5559192, 0.0, 146, 832.77999999999997, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725613142.5559196, 0.0, 42, 859.95000000000005, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 65, 1725613142.5559204, 0.0, 54, 661.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725613142.5559208, 0.0, 95, 384.13, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5559216, 0.0, 141, 512.28999999999996, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 84, 1725613142.5559242, 0.0, 35, 61.460000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 50, 1725613142.5559249, 0.0, 127, 125.09999999999999, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725613142.5559254, 0.0, 103, 342.91000000000003, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725613142.5559261, 0.0, 186, 710.75999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 80, 1725613142.5559266, 0.0, 147, 120.16, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 57, 1725613142.5559273, 0.0, 187, 117.64, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725613142.5559278, 0.0, 84, 146.72, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725613142.5559285, 0.0, 51, 634.29999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725613142.5559289, 0.0, 156, 648.65999999999997, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725613142.5559297, 0.0, 141, 537.5, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725613142.5559304, 0.0, 133, 426.07999999999998, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5559309, 0.0, 83, 128.47999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725613142.5559316, 0.0, 75, 740.50999999999999, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.5559323, 0.0, 128, 196.52000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 38, 1725613142.5559349, 0.0, 92, 553.13, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5559351, 0.0, 93, 248.50999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 98, 1725613142.5559361, 0.0, 98, 557.45000000000005, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 43, 1725613142.5559366, 0.0, 63, 620.21000000000004, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725613142.5559373, 0.0, 41, 265.94, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725613142.5559378, 0.0, 125, 522.91999999999996, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5559385, 0.0, 76, 419.20999999999998, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725613142.5559392, 0.0, 73, 169.22999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 93, 1725613142.5559397, 0.0, 67, 106.45, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725613142.5559404, 0.0, 153, 1.53, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5559409, 0.0, 102, 350.91000000000003, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 10, 1725613142.5559416, 0.0, 46, 104.56, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725613142.5559421, 0.0, 29, 690.07000000000005, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725613142.5559447, 0.0, 42, 23.5, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725613142.5559454, 0.0, 40, 462.42000000000002, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 24, 1725613142.5559461, 0.0, 198, 330.82999999999998, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 73, 1725613142.5559466, 0.0, 54, 27.710000000000001, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725613142.5559509, 0.0, 174, 29.309999999999999, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 87, 1725613142.5559511, 0.0, 41, 507.05000000000001, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725613142.5559521, 0.0, 39, 670.39999999999998, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5559523, 0.0, 133, 323.38, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725613142.5559533, 0.0, 170, 840.86000000000001, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 18, 1725613142.5559537, 0.0, 106, 660.09000000000003, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5559545, 0.0, 108, 519.74000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725613142.5559547, 0.0, 93, 104.09999999999999, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725613142.5559556, 0.0, 91, 11.970000000000001, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 23, 1725613142.5559559, 0.0, 34, 938.30999999999995, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 82, 1725613142.5559587, 0.0, 162, 914.96000000000004, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725613142.5559597, 0.0, 91, 202.97, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725613142.5559599, 0.0, 36, 507.13999999999999, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725613142.5559609, 0.0, 34, 950.14999999999998, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5559614, 0.0, 92, 189.13999999999999, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5559621, 0.0, 115, 878.62, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 61, 1725613142.5559623, 0.0, 168, 957.23000000000002, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailableStock", "Created", "Discount", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5559633, 0.0, 624.53999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 97, 1725613142.5559635, 0.0, 148, 668.79999999999995, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 90, 1725613142.5559645, 0.0, 40, 540.10000000000002, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 27, 1725613142.5559647, 0.0, 136, 102.53, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 7, 1725613142.5559657, 0.0, 97, 80.939999999999998, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725613142.5559659, 0.0, 168, 344.19, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725613142.5559669, 0.0, 50, 858.09000000000003, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.5559704, 0.0, 122, 194.08000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 20, 1725613142.5559709, 0.0, 113, 885.02999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 78, 1725613142.5559716, 0.0, 146, 122.40000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725613142.5559721, 0.0, 193, 262.5, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 2, 1725613142.5559728, 0.0, 174, 671.90999999999997, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 77, 1725613142.5559735, 0.0, 39, 889.02999999999997, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725613142.555974, 0.0, 50, 713.24000000000001, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 92, 1725613142.5559747, 0.0, 26, 841.66999999999996, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5559752, 0.0, 159, 434.63, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725613142.5559759, 0.0, 194, 82.379999999999995, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725613142.5559764, 0.0, 190, 111.70999999999999, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 71, 1725613142.5559771, 0.0, 25, 594.97000000000003, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 79, 1725613142.5559778, 0.0, 92, 232.28999999999999, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725613142.5559783, 0.0, 40, 65.900000000000006, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 47, 1725613142.5559809, 0.0, 87, 949.25, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725613142.5559816, 0.0, 118, 771.15999999999997, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 73, 1725613142.5559821, 0.0, 81, 136.44999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 5, 1725613142.5559828, 0.0, 93, 637.66999999999996, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 51, 1725613142.5559833, 0.0, 60, 458.82999999999998, 13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.555984, 0.0, 157, 454.80000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 31, 1725613142.5559845, 0.0, 138, 445.16000000000003, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725613142.5559852, 0.0, 29, 326.33999999999997, 14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 29, 1725613142.5559857, 0.0, 86, 379.25, 19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 22, 1725613142.5559864, 0.0, 54, 783.53999999999996, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725613142.5559871, 0.0, 102, 966.88999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 39, 1725613142.5559876, 0.0, 145, 745.12, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725613142.5559883, 0.0, 45, 17.379999999999999, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 76, 1725613142.5559888, 0.0, 160, 835.66999999999996, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 14, 1725613142.5559907, 0.0, 180, 942.86000000000001, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 92, 1725613142.5559916, 0.0, 52, 417.68000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725613142.5559919, 0.0, 193, 464.43000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 37, 1725613142.5559928, 0.0, 124, 50.789999999999999, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725613142.5559933, 0.0, 135, 511.05000000000001, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725613142.555994, 0.0, 166, 273.12, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725613142.5559945, 0.0, 71, 925.48000000000002, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 44, 1725613142.5559952, 0.0, 121, 255.50999999999999, 17 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1, 1725613142.5559957, 0.0, 172, 203.44999999999999, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 15, 1725613142.5559964, 0.0, 44, 491.11000000000001, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725613142.5559969, 0.0, 73, 597.70000000000005, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725613142.5559976, 0.0, 129, 412.60000000000002, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 99, 1725613142.5559981, 0.0, 186, 815.91999999999996, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 41, 1725613142.5560017, 0.0, 50, 892.38, 16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price" },
                values: new object[] { 63, 1725613142.5560019, 0.0, 73, 539.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailableStock", "Created", "Discount", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 25, 1725613142.5560029, 0.0, 86, 242.56999999999999, 17 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AvatarLink",
                table: "Brands");

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 91, 1725375134.6753316, 186, 243.13999999999999, 2 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 12, 1725375134.6753345, 70, 742.66999999999996, 4 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6753571, 44, 767.32000000000005, 3 });

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
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6753705, 39, 203.69, 6 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 60, 1725375134.6753759, 22, 16.27, 11 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 55, 1725375134.6753829, 65, 984.5, 6 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 98, 1725375134.6753883, 34, 317.66000000000003 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 88, 1725375134.6753907, 71, 51.509999999999998, 13 });

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
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.6753967, 122, 633.16999999999996, 11 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 49, 1725375134.6753981, 98, 625.25999999999999 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 26, 1725375134.6754012, 163, 976.49000000000001, 14 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 56, 1725375134.6754088, 32, 210.11000000000001, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 86, 1725375134.6754093, 159, 625.10000000000002, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 96, 1725375134.67541, 30, 49.829999999999998, 4 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 65, 1725375134.6754177, 41, 473.94999999999999, 5 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.6754198, 94, 378.68000000000001, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 2, 1725375134.6754203, 86, 894.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 15, 1725375134.675421, 135, 724.04999999999995 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 35, 1725375134.6754239, 93, 293.91000000000003, 10 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.6754279, 55, 889.00999999999999, 4 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 54, 1725375134.6754365, 165, 683.77999999999997, 12 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 36, 1725375134.6754684, 72, 695.04999999999995, 14 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 47, 1725375134.6754732, 76, 908.20000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 46, 1725375134.6754739, 160, 57.68, 12 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 70, 1725375134.675482, 125, 950.57000000000005 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 66, 1725375134.6754849, 151, 936.19000000000005 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 83, 1725375134.6754868, 181, 529.04999999999995 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 64, 1725375134.6754904, 191, 792.30999999999995, 10 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 94, 1725375134.6754916, 177, 972.78999999999996 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 28, 1725375134.6754947, 31, 623.52999999999997, 18 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 6, 1725375134.6754963, 172, 470.70999999999998, 9 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 21, 1725375134.6755109, 46, 193.61000000000001 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 16, 1725375134.6755121, 85, 878.72000000000003, 5 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 75, 1725375134.6755202, 101, 981.35000000000002, 19 });

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
                columns: new[] { "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 1725375134.675524, 107, 686.54999999999995, 15 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 72, 1725375134.6755314, 125, 864.67999999999995, 6 });

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
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 9, 1725375134.6755388, 14.800000000000001, 5 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 80, 1725375134.6755452, 100, 630.90999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 49, 1725375134.6755481, 112, 969.62, 18 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 40, 1725375134.6755493, 34, 869.98000000000002 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 25, 1725375134.6755524, 177, 997.80999999999995 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 51, 1725375134.6755548, 85, 923.42999999999995 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 40, 1725375134.6755707, 58, 316.44, 18 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 4, 1725375134.6755831, 160, 897.46000000000004, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 11, 1725375134.6755841, 32, 107.36, 10 });

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
                columns: new[] { "AvailableStock", "Created", "Price", "RestockThreshold" },
                values: new object[] { 58, 1725375134.6755922, 374.12, 11 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 42, 1725375134.6755958, 131, 34.619999999999997, 11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 32, 1725375134.6755991, 157, 518.63999999999999, 7 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 83, 1725375134.6756065, 26, 85.909999999999997, 2 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 97, 1725375134.6756113, 115, 236.84999999999999 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 45, 1725375134.6756144, 87, 222.25999999999999, 7 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 43, 1725375134.6756213, 139, 461.41000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 34, 1725375134.675622, 40, 918.92999999999995, 8 });

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
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price" },
                values: new object[] { 36, 1725375134.6756291, 54, 955.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailableStock", "Created", "MaxStockThreshold", "Price", "RestockThreshold" },
                values: new object[] { 62, 1725375134.6756318, 78, 240.03999999999999, 19 });
        }
    }
}
