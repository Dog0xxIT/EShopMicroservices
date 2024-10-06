using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ordering.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCreateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "5cea49bb-3127-497f-bd1c-96c014ff720b");

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "c05c78c5-7cbb-4188-bcca-ca9d5109d544");

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "f680059b-0600-4c14-a913-a122e2d9b94b");

            migrationBuilder.AddColumn<double>(
                name: "Created",
                table: "PaymentMethods",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Created",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Created",
                table: "OrderItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Created",
                table: "CardTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Created",
                table: "Buyers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { "0d5ba35b-b4bb-492e-a822-ab6f548605ba", 1728150657.4110675, false, 0.0, "Amex" },
                    { "d018e07e-e90e-4c9d-96b8-b79729f84a16", 1728150657.4110692, false, 0.0, "MasterCard" },
                    { "e7194f86-9961-45a8-b503-ab0ada9231d3", 1728150657.4110689, false, 0.0, "Visa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "0d5ba35b-b4bb-492e-a822-ab6f548605ba");

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "d018e07e-e90e-4c9d-96b8-b79729f84a16");

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: "e7194f86-9961-45a8-b503-ab0ada9231d3");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PaymentMethods");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "CardTypes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Buyers");

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { "5cea49bb-3127-497f-bd1c-96c014ff720b", false, 0.0, "Visa" },
                    { "c05c78c5-7cbb-4188-bcca-ca9d5109d544", false, 0.0, "MasterCard" },
                    { "f680059b-0600-4c14-a913-a122e2d9b94b", false, 0.0, "Amex" }
                });
        }
    }
}
