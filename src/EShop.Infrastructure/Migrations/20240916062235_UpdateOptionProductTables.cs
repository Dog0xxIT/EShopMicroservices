using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOptionProductTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionValues = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OptionValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionValues_OptionTypes_OptionTypeId",
                        column: x => x.OptionTypeId,
                        principalTable: "OptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VariantOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    OptionTypeId = table.Column<int>(type: "int", nullable: false),
                    OptionValueId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantOptions_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "26ba7453-5881-4ba4-9b91-f29ffb3d9115");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "8103d3e2-91cd-4545-a6b9-c0354753f3bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c7d6a90e-28ec-451c-86c2-087733786f81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6e9c4f05-1a8a-40b9-9915-34c67f075248");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "72e8174d-5967-44a5-94a0-dc1c4718482b");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726467754.2663822);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726467754.2663825);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726467754.2663827);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726467754.2663827);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726467754.2663827);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726467754.2663827);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726467754.2663832);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726467754.2663832);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726467754.2663832);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726467754.2663834);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726467754.2663836);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726467754.2663836);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726467754.2663836);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726467754.2663839);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726467754.2663839);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726467754.2663839);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726467754.2663839);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726467754.2663841);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726467754.2663844);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726467754.2663844);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726467754.2663844);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726467754.2663846);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726467754.2663848);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726467754.2663848);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726467754.2663848);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726467754.2663851);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726467754.2663853);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726467754.2663853);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726467754.2663853);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726467754.2663853);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726467754.2663856);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726467754.2663856);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726467754.2663858);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726467754.2663901);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726467754.2663903);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726467754.2663903);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726467754.2663906);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726467754.2663908);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726467754.2663908);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726467754.2663908);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726467754.2608356);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726467754.2608633);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726467754.2608852);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726467754.2609072);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726467754.2609308);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726467754.2609513);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726467754.2609727);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726467754.2609961);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726467754.2610178);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726467754.2610393);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726467754.2610612);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726467754.2610831);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726467754.2611036);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726467754.2611277);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726467754.2611475);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726467754.2611673);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726467754.2611914);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726467754.2612123);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726467754.2612352);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726467754.2612555);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726467754.2612758);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726467754.2612972);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726467754.2613237);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726467754.2613442);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726467754.2613652);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726467754.2613883);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726467754.2614093);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726467754.2614305);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726467754.2614541);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726467754.2614737);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726467754.2614954);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726467754.261518);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726467754.2615416);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726467754.2615623);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726467754.2615848);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726467754.2616136);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726467754.2616341);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726467754.261658);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726467754.2616785);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726467754.2616992);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726467754.2617221);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726467754.2617495);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726467754.2617698);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726467754.26179);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726467754.2618134);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726467754.2618332);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726467754.2618549);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726467754.2618749);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726467754.2618985);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726467754.2619195);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726467754.2619388);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726467754.2619631);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726467754.2619832);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726467754.2620046);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726467754.2620249);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726467754.2620487);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726467754.2620692);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726467754.26209);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726467754.2621117);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726467754.2621341);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726467754.2621555);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726467754.2621763);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726467754.2621996);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726467754.2622199);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726467754.2622397);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726467754.2622671);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726467754.2622874);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726467754.2623074);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726467754.2623284);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726467754.2623537);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726467754.2623751);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726467754.2623956);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726467754.2624199);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726467754.26244);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726467754.2624607);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726467754.2624817);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726467754.2625031);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726467754.2625253);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726467754.2625456);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726467754.2625697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726467754.2625947);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726467754.2626152);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726467754.2626371);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726467754.2626593);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726467754.2626805);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726467754.2627003);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726467754.2627196);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726467754.2627449);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726467754.2627652);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726467754.2627888);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726467754.2628088);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726467754.2628324);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726467754.2628529);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726467754.262872);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726467754.2628942);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726467754.2629168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726467754.262938);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726467754.262958);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726467754.2629769);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726467754.2629993);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726467754.2630212);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726467754.2630427);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726467754.263063);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726467754.2630837);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726467754.2631092);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726467754.2631292);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726467754.2631505);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726467754.2631707);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726467754.2631936);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726467754.2632172);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726467754.2632384);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726467754.2632585);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726467754.2632797);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726467754.2632995);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726467754.2633221);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726467754.2633433);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726467754.2633653);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726467754.2633872);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726467754.2634089);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726467754.2634332);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726467754.2634537);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726467754.2634747);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726467754.2634947);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726467754.2635195);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726467754.26354);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726467754.2635608);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726467754.2635837);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726467754.263608);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726467754.2636304);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726467754.2636535);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726467754.2636747);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726467754.2636976);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726467754.2637177);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726467754.2637422);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726467754.263763);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726467754.2637832);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726467754.2638063);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726467754.2638261);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726467754.2638483);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726467754.2638707);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726467754.2638919);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726467754.2639127);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726467754.2639341);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726467754.2639577);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726467754.263978);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726467754.2640009);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726467754.2640224);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726467754.2640431);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726467754.264066);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726467754.264086);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726467754.2641065);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726467754.2641525);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726467754.2641821);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726467754.26421);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726467754.2642314);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726467754.2642519);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726467754.2642744);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726467754.2642968);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726467754.2643173);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726467754.2643404);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726467754.2643604);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726467754.2643816);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726467754.2644029);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726467754.264425);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726467754.2644453);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726467754.2644663);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726467754.2644861);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726467754.2645092);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726467754.2645292);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726467754.2645495);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726467754.2645731);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726467754.2645991);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726467754.264621);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726467754.2646427);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726467754.2646646);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726467754.2646873);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726467754.2647088);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726467754.2647293);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726467754.2647517);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726467754.2647729);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726467754.2647955);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726467754.2648177);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726467754.264838);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726467754.2648616);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726467754.2648821);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726467754.2649064);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726467754.2649281);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726467754.2649512);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726467754.2649722);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726467754.2649927);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726467754.2650163);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726467754.2650363);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726467754.2650571);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726467754.2650807);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726467754.265101);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726467754.265125);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726467754.2651455);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726467754.2651689);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726467754.2651892);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726467754.2652087);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726467754.2652335);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726467754.2652543);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726467754.2652748);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726467754.2652984);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726467754.2653179);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726467754.2653406);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726467754.2653637);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726467754.2653837);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726467754.2654052);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726467754.2654269);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726467754.2654493);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726467754.2654693);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726467754.2654924);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726467754.2655125);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726467754.2655323);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726467754.2655561);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726467754.2655768);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726467754.2656229);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726467754.2656441);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726467754.2656684);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726467754.2656884);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726467754.2657087);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726467754.2657318);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726467754.2657516);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726467754.2657733);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726467754.2658131);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726467754.2658353);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726467754.2658556);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726467754.2658789);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726467754.2659001);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726467754.2659221);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726467754.2659438);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726467754.2659671);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726467754.2659895);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726467754.2660117);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726467754.2660346);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726467754.2660551);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726467754.2660787);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726467754.2660999);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726467754.2661216);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726467754.2661445);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726467754.2661653);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726467754.2661891);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726467754.2662094);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726467754.2662356);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726467754.2662563);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726467754.2662778);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726467754.2663004);

            migrationBuilder.CreateIndex(
                name: "IX_OptionValues_OptionTypeId",
                table: "OptionValues",
                column: "OptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantOptions_ProductVariantId",
                table: "VariantOptions",
                column: "ProductVariantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OptionValues");

            migrationBuilder.DropTable(
                name: "VariantOptions");

            migrationBuilder.DropTable(
                name: "OptionTypes");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0594717a-16ca-4197-94ee-b55766d39027");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "07fe89e7-aee3-4b36-9f2f-71fc1ddf2bee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "612fc806-5a20-4b9c-991e-ed65f8f2d82f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "abf599be-c35e-4f55-9adb-80178a38e4bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "8231673c-254a-48b7-8ae0-8510e80b49d0");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726243891.7513375);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726243891.751338);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726243891.751338);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726243891.7513382);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726243891.7513385);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726243891.7513385);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726243891.7513385);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726243891.7513385);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726243891.7513387);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726243891.7513387);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726243891.7513387);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726243891.751339);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726243891.7513392);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726243891.7513392);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726243891.7513394);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726243891.7513397);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726243891.7513397);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726243891.7513397);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726243891.7513397);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726243891.7513399);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726243891.7513399);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726243891.7513399);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726243891.7513402);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726243891.7513404);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726243891.7513404);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726243891.7513404);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726243891.7513406);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726243891.7513406);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726243891.7513409);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726243891.7513409);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726243891.7513409);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726243891.7513411);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726243891.7513411);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726243891.7513411);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726243891.7513411);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726243891.7513413);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726243891.7513416);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726243891.7513416);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726243891.7513416);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726243891.7513418);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: 1726243891.7457609);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: 1726243891.7457922);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: 1726243891.7458155);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: 1726243891.7458377);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: 1726243891.7458646);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: 1726243891.7458923);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: 1726243891.745918);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: 1726243891.74594);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: 1726243891.7459631);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: 1726243891.7459891);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: 1726243891.746011);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: 1726243891.7460337);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: 1726243891.7460556);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: 1726243891.7460783);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: 1726243891.7461009);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: 1726243891.7461231);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: 1726243891.7461429);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: 1726243891.7461674);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: 1726243891.7461891);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: 1726243891.746208);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: 1726243891.7462296);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: 1726243891.7462549);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: 1726243891.7462776);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: 1726243891.7463017);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "Created",
                value: 1726243891.7463219);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "Created",
                value: 1726243891.7463436);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "Created",
                value: 1726243891.7463646);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "Created",
                value: 1726243891.7463901);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "Created",
                value: 1726243891.7464108);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "Created",
                value: 1726243891.7464404);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                column: "Created",
                value: 1726243891.7464657);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32,
                column: "Created",
                value: 1726243891.74649);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33,
                column: "Created",
                value: 1726243891.7465131);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34,
                column: "Created",
                value: 1726243891.7465365);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35,
                column: "Created",
                value: 1726243891.7465577);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36,
                column: "Created",
                value: 1726243891.746582);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37,
                column: "Created",
                value: 1726243891.7466056);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38,
                column: "Created",
                value: 1726243891.7466247);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39,
                column: "Created",
                value: 1726243891.7466445);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40,
                column: "Created",
                value: 1726243891.7466669);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41,
                column: "Created",
                value: 1726243891.7466879);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42,
                column: "Created",
                value: 1726243891.7467132);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43,
                column: "Created",
                value: 1726243891.7467368);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44,
                column: "Created",
                value: 1726243891.7467623);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45,
                column: "Created",
                value: 1726243891.7467828);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46,
                column: "Created",
                value: 1726243891.7468052);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47,
                column: "Created",
                value: 1726243891.7468252);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48,
                column: "Created",
                value: 1726243891.7468512);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49,
                column: "Created",
                value: 1726243891.7468741);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50,
                column: "Created",
                value: 1726243891.7468965);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51,
                column: "Created",
                value: 1726243891.7469168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52,
                column: "Created",
                value: 1726243891.7469361);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53,
                column: "Created",
                value: 1726243891.7469604);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54,
                column: "Created",
                value: 1726243891.74698);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55,
                column: "Created",
                value: 1726243891.7469995);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56,
                column: "Created",
                value: 1726243891.74702);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57,
                column: "Created",
                value: 1726243891.7470407);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58,
                column: "Created",
                value: 1726243891.747062);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59,
                column: "Created",
                value: 1726243891.747082);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60,
                column: "Created",
                value: 1726243891.7471044);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61,
                column: "Created",
                value: 1726243891.7471237);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62,
                column: "Created",
                value: 1726243891.7471423);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63,
                column: "Created",
                value: 1726243891.7471633);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64,
                column: "Created",
                value: 1726243891.7471871);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65,
                column: "Created",
                value: 1726243891.7472064);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66,
                column: "Created",
                value: 1726243891.7472315);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67,
                column: "Created",
                value: 1726243891.7472515);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68,
                column: "Created",
                value: 1726243891.7472713);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69,
                column: "Created",
                value: 1726243891.7472918);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70,
                column: "Created",
                value: 1726243891.7473147);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71,
                column: "Created",
                value: 1726243891.7473354);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72,
                column: "Created",
                value: 1726243891.7473555);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73,
                column: "Created",
                value: 1726243891.7473767);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74,
                column: "Created",
                value: 1726243891.7473977);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75,
                column: "Created",
                value: 1726243891.7474179);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76,
                column: "Created",
                value: 1726243891.747438);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77,
                column: "Created",
                value: 1726243891.7474632);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78,
                column: "Created",
                value: 1726243891.7474856);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79,
                column: "Created",
                value: 1726243891.7475059);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80,
                column: "Created",
                value: 1726243891.7475276);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81,
                column: "Created",
                value: 1726243891.7475483);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82,
                column: "Created",
                value: 1726243891.7475677);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83,
                column: "Created",
                value: 1726243891.7475905);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84,
                column: "Created",
                value: 1726243891.7476132);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85,
                column: "Created",
                value: 1726243891.747632);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86,
                column: "Created",
                value: 1726243891.7476532);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87,
                column: "Created",
                value: 1726243891.7476718);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88,
                column: "Created",
                value: 1726243891.7476945);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89,
                column: "Created",
                value: 1726243891.747714);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90,
                column: "Created",
                value: 1726243891.7477329);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91,
                column: "Created",
                value: 1726243891.7477541);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92,
                column: "Created",
                value: 1726243891.7477753);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93,
                column: "Created",
                value: 1726243891.7477956);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94,
                column: "Created",
                value: 1726243891.7478163);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95,
                column: "Created",
                value: 1726243891.7478385);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96,
                column: "Created",
                value: 1726243891.7478576);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97,
                column: "Created",
                value: 1726243891.7478771);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98,
                column: "Created",
                value: 1726243891.7479005);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99,
                column: "Created",
                value: 1726243891.7479205);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100,
                column: "Created",
                value: 1726243891.7479396);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101,
                column: "Created",
                value: 1726243891.7479601);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102,
                column: "Created",
                value: 1726243891.7479815);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103,
                column: "Created",
                value: 1726243891.7480011);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104,
                column: "Created",
                value: 1726243891.7480216);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105,
                column: "Created",
                value: 1726243891.7480404);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106,
                column: "Created",
                value: 1726243891.7480626);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107,
                column: "Created",
                value: 1726243891.7480822);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108,
                column: "Created",
                value: 1726243891.7481019);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109,
                column: "Created",
                value: 1726243891.7481217);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110,
                column: "Created",
                value: 1726243891.7481425);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111,
                column: "Created",
                value: 1726243891.7481654);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112,
                column: "Created",
                value: 1726243891.7481856);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113,
                column: "Created",
                value: 1726243891.7482069);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114,
                column: "Created",
                value: 1726243891.7482305);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115,
                column: "Created",
                value: 1726243891.7482498);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116,
                column: "Created",
                value: 1726243891.7482705);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117,
                column: "Created",
                value: 1726243891.7482936);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118,
                column: "Created",
                value: 1726243891.7483137);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119,
                column: "Created",
                value: 1726243891.7483356);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120,
                column: "Created",
                value: 1726243891.7483578);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121,
                column: "Created",
                value: 1726243891.7483768);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122,
                column: "Created",
                value: 1726243891.7483976);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123,
                column: "Created",
                value: 1726243891.7484186);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124,
                column: "Created",
                value: 1726243891.7484396);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125,
                column: "Created",
                value: 1726243891.7484591);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126,
                column: "Created",
                value: 1726243891.7484815);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127,
                column: "Created",
                value: 1726243891.7485025);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128,
                column: "Created",
                value: 1726243891.7485218);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129,
                column: "Created",
                value: 1726243891.7485456);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130,
                column: "Created",
                value: 1726243891.7485659);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131,
                column: "Created",
                value: 1726243891.748594);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132,
                column: "Created",
                value: 1726243891.7486143);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133,
                column: "Created",
                value: 1726243891.7486343);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134,
                column: "Created",
                value: 1726243891.7486577);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135,
                column: "Created",
                value: 1726243891.7486773);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136,
                column: "Created",
                value: 1726243891.748697);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137,
                column: "Created",
                value: 1726243891.7487197);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138,
                column: "Created",
                value: 1726243891.7487383);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139,
                column: "Created",
                value: 1726243891.7487607);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140,
                column: "Created",
                value: 1726243891.7487826);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141,
                column: "Created",
                value: 1726243891.7488036);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142,
                column: "Created",
                value: 1726243891.7488256);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143,
                column: "Created",
                value: 1726243891.7488472);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144,
                column: "Created",
                value: 1726243891.7488685);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145,
                column: "Created",
                value: 1726243891.748888);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146,
                column: "Created",
                value: 1726243891.7489109);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147,
                column: "Created",
                value: 1726243891.7489307);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148,
                column: "Created",
                value: 1726243891.74895);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149,
                column: "Created",
                value: 1726243891.7489734);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150,
                column: "Created",
                value: 1726243891.7489929);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151,
                column: "Created",
                value: 1726243891.7490149);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152,
                column: "Created",
                value: 1726243891.7490556);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153,
                column: "Created",
                value: 1726243891.7490797);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154,
                column: "Created",
                value: 1726243891.7491);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155,
                column: "Created",
                value: 1726243891.7491229);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156,
                column: "Created",
                value: 1726243891.7491441);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157,
                column: "Created",
                value: 1726243891.7491636);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158,
                column: "Created",
                value: 1726243891.7491872);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159,
                column: "Created",
                value: 1726243891.7492065);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160,
                column: "Created",
                value: 1726243891.7492275);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161,
                column: "Created",
                value: 1726243891.7492468);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162,
                column: "Created",
                value: 1726243891.7493412);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163,
                column: "Created",
                value: 1726243891.7493687);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164,
                column: "Created",
                value: 1726243891.7493882);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165,
                column: "Created",
                value: 1726243891.7494237);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166,
                column: "Created",
                value: 1726243891.7494459);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167,
                column: "Created",
                value: 1726243891.7494664);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168,
                column: "Created",
                value: 1726243891.7494855);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169,
                column: "Created",
                value: 1726243891.749506);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170,
                column: "Created",
                value: 1726243891.7495279);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171,
                column: "Created",
                value: 1726243891.7495492);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172,
                column: "Created",
                value: 1726243891.7495732);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173,
                column: "Created",
                value: 1726243891.7495956);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174,
                column: "Created",
                value: 1726243891.7496171);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175,
                column: "Created",
                value: 1726243891.7496388);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176,
                column: "Created",
                value: 1726243891.7496667);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177,
                column: "Created",
                value: 1726243891.7496865);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178,
                column: "Created",
                value: 1726243891.7497089);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179,
                column: "Created",
                value: 1726243891.7497296);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180,
                column: "Created",
                value: 1726243891.7497523);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181,
                column: "Created",
                value: 1726243891.7497725);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182,
                column: "Created",
                value: 1726243891.7497933);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183,
                column: "Created",
                value: 1726243891.7498147);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184,
                column: "Created",
                value: 1726243891.7498345);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185,
                column: "Created",
                value: 1726243891.7498548);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186,
                column: "Created",
                value: 1726243891.7498753);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187,
                column: "Created",
                value: 1726243891.7499039);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188,
                column: "Created",
                value: 1726243891.7499247);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189,
                column: "Created",
                value: 1726243891.7499475);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190,
                column: "Created",
                value: 1726243891.7499681);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191,
                column: "Created",
                value: 1726243891.7499881);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192,
                column: "Created",
                value: 1726243891.7500117);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193,
                column: "Created",
                value: 1726243891.7500336);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194,
                column: "Created",
                value: 1726243891.7500546);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195,
                column: "Created",
                value: 1726243891.7500746);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196,
                column: "Created",
                value: 1726243891.7500975);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197,
                column: "Created",
                value: 1726243891.7501168);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198,
                column: "Created",
                value: 1726243891.7501426);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199,
                column: "Created",
                value: 1726243891.7501655);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200,
                column: "Created",
                value: 1726243891.7501836);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201,
                column: "Created",
                value: 1726243891.7502108);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202,
                column: "Created",
                value: 1726243891.7502308);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203,
                column: "Created",
                value: 1726243891.7502539);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204,
                column: "Created",
                value: 1726243891.7502737);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205,
                column: "Created",
                value: 1726243891.7502923);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206,
                column: "Created",
                value: 1726243891.7503159);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207,
                column: "Created",
                value: 1726243891.7503359);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208,
                column: "Created",
                value: 1726243891.7503567);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209,
                column: "Created",
                value: 1726243891.7503817);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210,
                column: "Created",
                value: 1726243891.7504039);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211,
                column: "Created",
                value: 1726243891.7504249);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212,
                column: "Created",
                value: 1726243891.7504451);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213,
                column: "Created",
                value: 1726243891.7504723);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214,
                column: "Created",
                value: 1726243891.7504945);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215,
                column: "Created",
                value: 1726243891.7505164);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216,
                column: "Created",
                value: 1726243891.7505364);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217,
                column: "Created",
                value: 1726243891.7505591);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218,
                column: "Created",
                value: 1726243891.7505822);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219,
                column: "Created",
                value: 1726243891.7506096);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220,
                column: "Created",
                value: 1726243891.7506297);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221,
                column: "Created",
                value: 1726243891.7506521);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222,
                column: "Created",
                value: 1726243891.7506728);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223,
                column: "Created",
                value: 1726243891.7506919);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224,
                column: "Created",
                value: 1726243891.7507155);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225,
                column: "Created",
                value: 1726243891.7507362);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226,
                column: "Created",
                value: 1726243891.750778);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227,
                column: "Created",
                value: 1726243891.7508037);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228,
                column: "Created",
                value: 1726243891.7508245);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229,
                column: "Created",
                value: 1726243891.7508488);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230,
                column: "Created",
                value: 1726243891.75087);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231,
                column: "Created",
                value: 1726243891.7508936);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232,
                column: "Created",
                value: 1726243891.7509141);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233,
                column: "Created",
                value: 1726243891.7509334);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234,
                column: "Created",
                value: 1726243891.7509568);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235,
                column: "Created",
                value: 1726243891.7509778);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236,
                column: "Created",
                value: 1726243891.7510009);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237,
                column: "Created",
                value: 1726243891.7510219);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238,
                column: "Created",
                value: 1726243891.7510448);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239,
                column: "Created",
                value: 1726243891.7510638);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240,
                column: "Created",
                value: 1726243891.7510865);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241,
                column: "Created",
                value: 1726243891.7511091);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242,
                column: "Created",
                value: 1726243891.7511308);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243,
                column: "Created",
                value: 1726243891.7511525);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244,
                column: "Created",
                value: 1726243891.751173);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245,
                column: "Created",
                value: 1726243891.7511933);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246,
                column: "Created",
                value: 1726243891.7512195);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247,
                column: "Created",
                value: 1726243891.7512407);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248,
                column: "Created",
                value: 1726243891.7512612);
        }
    }
}
