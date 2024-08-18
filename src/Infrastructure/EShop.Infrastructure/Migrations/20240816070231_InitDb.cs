using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PictureFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    RestockThreshold = table.Column<int>(type: "int", nullable: false),
                    MaxStockThreshold = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarPoint = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Units = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<double>(type: "float", nullable: false),
                    LastModified = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "8ddfd8ee-8b76-4059-9a48-7ecd370f0f42", "Administrator", "ADMINISTRATOR" },
                    { 2, "5f8b89eb-543b-457f-8c83-96f251471cb4", "Customer", "CUSTOMER" },
                    { 3, "dd32e8fe-bec1-4328-8c26-19f76b7d8049", "SalesManager", "SALESMANAGER" },
                    { 4, "a72aa8dd-7372-42ec-b5cc-2b38ba9abc1f", "StoreManager", "STOREMANAGER" },
                    { 5, "bd3ac564-203d-4526-8576-9e6441c30936", "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "APPLE", 1723791749.5482111, false, 0.0, "Apple" },
                    { 2, "SAMSUNG", 1723791749.5482113, false, 0.0, "Samsung" },
                    { 3, "MICROSOFT", 1723791749.5482116, false, 0.0, "Microsoft" },
                    { 4, "GOOGLE", 1723791749.5482116, false, 0.0, "Google" },
                    { 5, "AMAZON", 1723791749.5482116, false, 0.0, "Amazon" },
                    { 6, "FACEBOOK", 1723791749.5482116, false, 0.0, "Facebook" },
                    { 7, "INTEL", 1723791749.5482118, false, 0.0, "Intel" },
                    { 8, "IBM", 1723791749.5482121, false, 0.0, "IBM" },
                    { 9, "SONY", 1723791749.5482121, false, 0.0, "Sony" },
                    { 10, "DELL", 1723791749.5482121, false, 0.0, "Dell" },
                    { 11, "HP", 1723791749.5482121, false, 0.0, "HP" },
                    { 12, "LG", 1723791749.5482123, false, 0.0, "LG" },
                    { 13, "HUAWEI", 1723791749.5482123, false, 0.0, "Huawei" },
                    { 14, "CISCO", 1723791749.5482123, false, 0.0, "Cisco" },
                    { 15, "ORACLE", 1723791749.5482123, false, 0.0, "Oracle" },
                    { 16, "NVIDIA", 1723791749.5482123, false, 0.0, "Nvidia" },
                    { 17, "AMD", 1723791749.5482125, false, 0.0, "AMD" },
                    { 18, "LENOVO", 1723791749.5482128, false, 0.0, "Lenovo" },
                    { 19, "ASUS", 1723791749.5482154, false, 0.0, "Asus" },
                    { 20, "ACER", 1723791749.5482156, false, 0.0, "Acer" },
                    { 21, "NIKE", 1723791749.5482156, false, 0.0, "Nike" },
                    { 22, "ADIDAS", 1723791749.5482156, false, 0.0, "Adidas" },
                    { 23, "PUMA", 1723791749.5482159, false, 0.0, "Puma" },
                    { 24, "UA", 1723791749.5482159, false, 0.0, "Under Armour" },
                    { 25, "REEBOK", 1723791749.5482161, false, 0.0, "Reebok" },
                    { 26, "NB", 1723791749.5482161, false, 0.0, "New Balance" },
                    { 27, "ASICS", 1723791749.5482161, false, 0.0, "Asics" },
                    { 28, "CONV", 1723791749.5482161, false, 0.0, "Converse" },
                    { 29, "VANS", 1723791749.5482161, false, 0.0, "Vans" },
                    { 30, "SKETCH", 1723791749.5482163, false, 0.0, "Sketchers" },
                    { 31, "FILA", 1723791749.5482163, false, 0.0, "Fila" },
                    { 32, "HM", 1723791749.5482163, false, 0.0, "H&M" },
                    { 33, "ZARA", 1723791749.5482166, false, 0.0, "Zara" },
                    { 34, "UNIQLO", 1723791749.5482168, false, 0.0, "Uniqlo" },
                    { 35, "GUCCI", 1723791749.5482168, false, 0.0, "Gucci" },
                    { 36, "LV", 1723791749.5482168, false, 0.0, "Louis Vuitton" },
                    { 37, "PRADA", 1723791749.5482168, false, 0.0, "Prada" },
                    { 38, "CHANEL", 1723791749.5482171, false, 0.0, "Chanel" },
                    { 39, "HERMES", 1723791749.5482171, false, 0.0, "Hermès" },
                    { 40, "BURBERRY", 1723791749.5482173, false, 0.0, "Burberry" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "ELEC", 1723791749.5482051, false, 0.0, "Electronics" },
                    { 2, "BOOK", 1723791749.5482061, false, 0.0, "Books" },
                    { 3, "CLTH", 1723791749.5482061, false, 0.0, "Clothing" },
                    { 4, "HOME", 1723791749.5482061, false, 0.0, "Home and Kitchen" },
                    { 5, "SPORT", 1723791749.5482063, false, 0.0, "Sports and Outdoors" },
                    { 6, "BEAUTY", 1723791749.5482063, false, 0.0, "Beauty and Personal Care" },
                    { 7, "TOYS", 1723791749.5482063, false, 0.0, "Toys and Games" },
                    { 8, "AUTO", 1723791749.5482063, false, 0.0, "Automotive" },
                    { 9, "GROCERY", 1723791749.5482066, false, 0.0, "Grocery and Gourmet Food" },
                    { 10, "HEALTH", 1723791749.5482068, false, 0.0, "Health and Household" },
                    { 11, "INDUST", 1723791749.5482068, false, 0.0, "Industrial and Scientific" },
                    { 12, "PET", 1723791749.5482068, false, 0.0, "Pet Supplies" },
                    { 13, "OFFICE", 1723791749.5482068, false, 0.0, "Office Products" },
                    { 14, "SOFT", 1723791749.548207, false, 0.0, "Software" },
                    { 15, "GARDEN", 1723791749.5482073, false, 0.0, "Garden and Outdoor" },
                    { 16, "TOOLS", 1723791749.5482073, false, 0.0, "Tools and Home Improvement" },
                    { 17, "BABY", 1723791749.5482073, false, 0.0, "Baby" },
                    { 18, "MUSIC", 1723791749.5482073, false, 0.0, "Musical Instruments" },
                    { 19, "ARTS", 1723791749.5482073, false, 0.0, "Arts, Crafts, and Sewing" },
                    { 20, "JEWEL", 1723791749.5482075, false, 0.0, "Jewelry" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "BrandId", "CategoryId", "Created", "Description", "IsDeleted", "LastModified", "MaxStockThreshold", "Name", "PictureFileName", "Price", "RestockThreshold" },
                values: new object[,]
                {
                    { 1, 39, 2, 2, 1723791749.5482199, "Description for product 1", false, 0.0, 48, "Product 1", "product1.jpg", 155.72999999999999, 3 },
                    { 2, 70, 3, 3, 1723791749.5482285, "Description for product 2", false, 0.0, 184, "Product 2", "product2.jpg", 541.40999999999997, 3 },
                    { 3, 17, 4, 4, 1723791749.5482292, "Description for product 3", false, 0.0, 95, "Product 3", "product3.jpg", 283.27999999999997, 4 },
                    { 4, 8, 5, 5, 1723791749.5482299, "Description for product 4", false, 0.0, 57, "Product 4", "product4.jpg", 251.80000000000001, 10 },
                    { 5, 16, 6, 6, 1723791749.5482306, "Description for product 5", false, 0.0, 68, "Product 5", "product5.jpg", 783.30999999999995, 11 },
                    { 6, 35, 7, 7, 1723791749.5482316, "Description for product 6", false, 0.0, 111, "Product 6", "product6.jpg", 328.19999999999999, 11 },
                    { 7, 13, 8, 8, 1723791749.5482321, "Description for product 7", false, 0.0, 49, "Product 7", "product7.jpg", 792.75999999999999, 11 },
                    { 8, 66, 9, 9, 1723791749.5482328, "Description for product 8", false, 0.0, 189, "Product 8", "product8.jpg", 177.40000000000001, 12 },
                    { 9, 58, 10, 10, 1723791749.5482335, "Description for product 9", false, 0.0, 75, "Product 9", "product9.jpg", 926.90999999999997, 9 },
                    { 10, 94, 11, 11, 1723791749.5482345, "Description for product 10", false, 0.0, 28, "Product 10", "product10.jpg", 954.12, 15 },
                    { 11, 33, 12, 12, 1723791749.5482376, "Description for product 11", false, 0.0, 175, "Product 11", "product11.jpg", 90.859999999999999, 1 },
                    { 12, 26, 13, 13, 1723791749.5482385, "Description for product 12", false, 0.0, 190, "Product 12", "product12.jpg", 312.74000000000001, 14 },
                    { 13, 21, 14, 14, 1723791749.548239, "Description for product 13", false, 0.0, 70, "Product 13", "product13.jpg", 393.36000000000001, 19 },
                    { 14, 34, 15, 15, 1723791749.5482397, "Description for product 14", false, 0.0, 182, "Product 14", "product14.jpg", 795.69000000000005, 8 },
                    { 15, 59, 16, 16, 1723791749.5482404, "Description for product 15", false, 0.0, 45, "Product 15", "product15.jpg", 867.30999999999995, 11 },
                    { 16, 3, 17, 17, 1723791749.5482409, "Description for product 16", false, 0.0, 169, "Product 16", "product16.jpg", 415.36000000000001, 2 },
                    { 17, 59, 18, 18, 1723791749.5482416, "Description for product 17", false, 0.0, 26, "Product 17", "product17.jpg", 77.340000000000003, 12 },
                    { 18, 70, 19, 19, 1723791749.5482426, "Description for product 18", false, 0.0, 139, "Product 18", "product18.jpg", 232.94999999999999, 19 },
                    { 19, 63, 20, 20, 1723791749.5482433, "Description for product 19", false, 0.0, 183, "Product 19", "product19.jpg", 461.02999999999997, 3 },
                    { 20, 92, 21, 1, 1723791749.548244, "Description for product 20", false, 0.0, 178, "Product 20", "product20.jpg", 49.770000000000003, 2 },
                    { 21, 87, 22, 2, 1723791749.5482445, "Description for product 21", false, 0.0, 154, "Product 21", "product21.jpg", 573.46000000000004, 15 },
                    { 22, 83, 23, 3, 1723791749.5482452, "Description for product 22", false, 0.0, 37, "Product 22", "product22.jpg", 476.64999999999998, 7 },
                    { 23, 24, 24, 4, 1723791749.5482459, "Description for product 23", false, 0.0, 48, "Product 23", "product23.jpg", 511.47000000000003, 10 },
                    { 24, 41, 25, 5, 1723791749.5482464, "Description for product 24", false, 0.0, 112, "Product 24", "product24.jpg", 87.480000000000004, 8 },
                    { 25, 4, 26, 6, 1723791749.5482495, "Description for product 25", false, 0.0, 45, "Product 25", "product25.jpg", 835.63, 2 },
                    { 26, 69, 27, 7, 1723791749.5482502, "Description for product 26", false, 0.0, 68, "Product 26", "product26.jpg", 744.73000000000002, 3 },
                    { 27, 42, 28, 8, 1723791749.5482509, "Description for product 27", false, 0.0, 55, "Product 27", "product27.jpg", 456.64999999999998, 9 },
                    { 28, 4, 29, 9, 1723791749.5482516, "Description for product 28", false, 0.0, 115, "Product 28", "product28.jpg", 326.58999999999997, 5 },
                    { 29, 48, 30, 10, 1723791749.5482521, "Description for product 29", false, 0.0, 23, "Product 29", "product29.jpg", 998.60000000000002, 6 },
                    { 30, 24, 31, 11, 1723791749.5482528, "Description for product 30", false, 0.0, 78, "Product 30", "product30.jpg", 540.13, 16 },
                    { 31, 27, 32, 12, 1723791749.5482533, "Description for product 31", false, 0.0, 48, "Product 31", "product31.jpg", 737.86000000000001, 2 },
                    { 32, 8, 33, 13, 1723791749.548254, "Description for product 32", false, 0.0, 114, "Product 32", "product32.jpg", 211.84, 6 },
                    { 33, 86, 34, 14, 1723791749.5482545, "Description for product 33", false, 0.0, 127, "Product 33", "product33.jpg", 954.63, 11 },
                    { 34, 5, 35, 15, 1723791749.5482554, "Description for product 34", false, 0.0, 181, "Product 34", "product34.jpg", 373.5, 3 },
                    { 35, 22, 36, 16, 1723791749.5482559, "Description for product 35", false, 0.0, 171, "Product 35", "product35.jpg", 658.38999999999999, 5 },
                    { 36, 57, 37, 17, 1723791749.5482569, "Description for product 36", false, 0.0, 90, "Product 36", "product36.jpg", 281.12, 16 },
                    { 37, 67, 38, 18, 1723791749.5482574, "Description for product 37", false, 0.0, 31, "Product 37", "product37.jpg", 23.350000000000001, 4 },
                    { 38, 97, 39, 19, 1723791749.5482607, "Description for product 38", false, 0.0, 160, "Product 38", "product38.jpg", 993.00999999999999, 10 },
                    { 39, 70, 40, 20, 1723791749.5482612, "Description for product 39", false, 0.0, 55, "Product 39", "product39.jpg", 244.83000000000001, 16 },
                    { 40, 73, 1, 1, 1723791749.5482619, "Description for product 40", false, 0.0, 25, "Product 40", "product40.jpg", 561.87, 2 },
                    { 41, 63, 2, 2, 1723791749.5482624, "Description for product 41", false, 0.0, 37, "Product 41", "product41.jpg", 803.60000000000002, 16 },
                    { 42, 18, 3, 3, 1723791749.5482633, "Description for product 42", false, 0.0, 118, "Product 42", "product42.jpg", 872.71000000000004, 13 },
                    { 43, 79, 4, 4, 1723791749.5482638, "Description for product 43", false, 0.0, 24, "Product 43", "product43.jpg", 44.469999999999999, 10 },
                    { 44, 48, 5, 5, 1723791749.5482645, "Description for product 44", false, 0.0, 56, "Product 44", "product44.jpg", 694.50999999999999, 18 },
                    { 45, 2, 6, 6, 1723791749.548265, "Description for product 45", false, 0.0, 109, "Product 45", "product45.jpg", 115.0, 3 },
                    { 46, 85, 7, 7, 1723791749.5482657, "Description for product 46", false, 0.0, 187, "Product 46", "product46.jpg", 201.59, 10 },
                    { 47, 6, 8, 8, 1723791749.5482664, "Description for product 47", false, 0.0, 164, "Product 47", "product47.jpg", 668.60000000000002, 9 },
                    { 48, 9, 9, 9, 1723791749.5482669, "Description for product 48", false, 0.0, 150, "Product 48", "product48.jpg", 53.719999999999999, 5 },
                    { 49, 13, 10, 10, 1723791749.5482676, "Description for product 49", false, 0.0, 26, "Product 49", "product49.jpg", 230.19999999999999, 9 },
                    { 50, 41, 11, 11, 1723791749.5482683, "Description for product 50", false, 0.0, 183, "Product 50", "product50.jpg", 777.35000000000002, 5 },
                    { 51, 2, 12, 12, 1723791749.5482688, "Description for product 51", false, 0.0, 134, "Product 51", "product51.jpg", 43.700000000000003, 10 },
                    { 52, 58, 13, 13, 1723791749.5482719, "Description for product 52", false, 0.0, 164, "Product 52", "product52.jpg", 212.81999999999999, 17 },
                    { 53, 81, 14, 14, 1723791749.5482726, "Description for product 53", false, 0.0, 127, "Product 53", "product53.jpg", 758.76999999999998, 7 },
                    { 54, 38, 15, 15, 1723791749.5482731, "Description for product 54", false, 0.0, 42, "Product 54", "product54.jpg", 582.37, 18 },
                    { 55, 55, 16, 16, 1723791749.5482738, "Description for product 55", false, 0.0, 87, "Product 55", "product55.jpg", 161.08000000000001, 8 },
                    { 56, 21, 17, 17, 1723791749.5482745, "Description for product 56", false, 0.0, 156, "Product 56", "product56.jpg", 658.30999999999995, 11 },
                    { 57, 19, 18, 18, 1723791749.5482752, "Description for product 57", false, 0.0, 21, "Product 57", "product57.jpg", 357.66000000000003, 9 },
                    { 58, 41, 19, 19, 1723791749.5482757, "Description for product 58", false, 0.0, 100, "Product 58", "product58.jpg", 782.72000000000003, 10 },
                    { 59, 51, 20, 20, 1723791749.5482764, "Description for product 59", false, 0.0, 27, "Product 59", "product59.jpg", 529.76999999999998, 2 },
                    { 60, 29, 21, 1, 1723791749.5482769, "Description for product 60", false, 0.0, 153, "Product 60", "product60.jpg", 459.49000000000001, 12 },
                    { 61, 43, 22, 2, 1723791749.5482776, "Description for product 61", false, 0.0, 107, "Product 61", "product61.jpg", 709.03999999999996, 6 },
                    { 62, 27, 23, 3, 1723791749.5482783, "Description for product 62", false, 0.0, 84, "Product 62", "product62.jpg", 737.92999999999995, 4 },
                    { 63, 5, 24, 4, 1723791749.5482788, "Description for product 63", false, 0.0, 76, "Product 63", "product63.jpg", 334.70999999999998, 12 },
                    { 64, 24, 25, 5, 1723791749.5482795, "Description for product 64", false, 0.0, 94, "Product 64", "product64.jpg", 468.16000000000003, 19 },
                    { 65, 27, 26, 6, 1723791749.5482802, "Description for product 65", false, 0.0, 172, "Product 65", "product65.jpg", 279.48000000000002, 9 },
                    { 66, 65, 27, 7, 1723791749.5482824, "Description for product 66", false, 0.0, 65, "Product 66", "product66.jpg", 400.50999999999999, 19 },
                    { 67, 7, 28, 8, 1723791749.5482831, "Description for product 67", false, 0.0, 157, "Product 67", "product67.jpg", 899.88999999999999, 13 },
                    { 68, 2, 29, 9, 1723791749.5482838, "Description for product 68", false, 0.0, 65, "Product 68", "product68.jpg", 788.82000000000005, 11 },
                    { 69, 85, 30, 10, 1723791749.5482843, "Description for product 69", false, 0.0, 167, "Product 69", "product69.jpg", 420.36000000000001, 15 },
                    { 70, 39, 31, 11, 1723791749.5482852, "Description for product 70", false, 0.0, 110, "Product 70", "product70.jpg", 688.25999999999999, 10 },
                    { 71, 2, 32, 12, 1723791749.5482855, "Description for product 71", false, 0.0, 178, "Product 71", "product71.jpg", 526.19000000000005, 15 },
                    { 72, 6, 33, 13, 1723791749.5482864, "Description for product 72", false, 0.0, 139, "Product 72", "product72.jpg", 525.45000000000005, 14 },
                    { 73, 43, 34, 14, 1723791749.5482869, "Description for product 73", false, 0.0, 81, "Product 73", "product73.jpg", 910.76999999999998, 5 },
                    { 74, 6, 35, 15, 1723791749.5482876, "Description for product 74", false, 0.0, 142, "Product 74", "product74.jpg", 337.22000000000003, 13 },
                    { 75, 7, 36, 16, 1723791749.5482883, "Description for product 75", false, 0.0, 106, "Product 75", "product75.jpg", 838.66999999999996, 1 },
                    { 76, 82, 37, 17, 1723791749.5482891, "Description for product 76", false, 0.0, 113, "Product 76", "product76.jpg", 232.55000000000001, 13 },
                    { 77, 83, 38, 18, 1723791749.5482895, "Description for product 77", false, 0.0, 164, "Product 77", "product77.jpg", 192.06, 4 },
                    { 78, 98, 39, 19, 1723791749.5482905, "Description for product 78", false, 0.0, 188, "Product 78", "product78.jpg", 299.36000000000001, 11 },
                    { 79, 14, 40, 20, 1723791749.5482948, "Description for product 79", false, 0.0, 48, "Product 79", "product79.jpg", 107.45999999999999, 9 },
                    { 80, 5, 1, 1, 1723791749.5482953, "Description for product 80", false, 0.0, 39, "Product 80", "product80.jpg", 955.85000000000002, 19 },
                    { 81, 28, 2, 2, 1723791749.548296, "Description for product 81", false, 0.0, 159, "Product 81", "product81.jpg", 133.69999999999999, 13 },
                    { 82, 27, 3, 3, 1723791749.5482967, "Description for product 82", false, 0.0, 23, "Product 82", "product82.jpg", 430.02999999999997, 6 },
                    { 83, 95, 4, 4, 1723791749.5482972, "Description for product 83", false, 0.0, 137, "Product 83", "product83.jpg", 658.53999999999996, 2 },
                    { 84, 25, 5, 5, 1723791749.5482979, "Description for product 84", false, 0.0, 72, "Product 84", "product84.jpg", 528.37, 1 },
                    { 85, 14, 6, 6, 1723791749.5482986, "Description for product 85", false, 0.0, 135, "Product 85", "product85.jpg", 361.06999999999999, 16 },
                    { 86, 72, 7, 7, 1723791749.5482993, "Description for product 86", false, 0.0, 161, "Product 86", "product86.jpg", 971.13999999999999, 11 },
                    { 87, 30, 8, 8, 1723791749.5482998, "Description for product 87", false, 0.0, 147, "Product 87", "product87.jpg", 91.829999999999998, 11 },
                    { 88, 51, 9, 9, 1723791749.5483005, "Description for product 88", false, 0.0, 42, "Product 88", "product88.jpg", 373.06999999999999, 12 },
                    { 89, 51, 10, 10, 1723791749.5483012, "Description for product 89", false, 0.0, 140, "Product 89", "product89.jpg", 367.12, 15 },
                    { 90, 93, 11, 11, 1723791749.5483017, "Description for product 90", false, 0.0, 173, "Product 90", "product90.jpg", 877.23000000000002, 3 },
                    { 91, 82, 12, 12, 1723791749.5483024, "Description for product 91", false, 0.0, 191, "Product 91", "product91.jpg", 969.30999999999995, 4 },
                    { 92, 73, 13, 13, 1723791749.5483031, "Description for product 92", false, 0.0, 121, "Product 92", "product92.jpg", 643.83000000000004, 9 },
                    { 93, 26, 14, 14, 1723791749.5483067, "Description for product 93", false, 0.0, 135, "Product 93", "product93.jpg", 108.29000000000001, 15 },
                    { 94, 51, 15, 15, 1723791749.5483077, "Description for product 94", false, 0.0, 197, "Product 94", "product94.jpg", 221.47999999999999, 16 },
                    { 95, 63, 16, 16, 1723791749.5483084, "Description for product 95", false, 0.0, 196, "Product 95", "product95.jpg", 606.03999999999996, 4 },
                    { 96, 90, 17, 17, 1723791749.5483088, "Description for product 96", false, 0.0, 79, "Product 96", "product96.jpg", 616.49000000000001, 3 },
                    { 97, 86, 18, 18, 1723791749.5483096, "Description for product 97", false, 0.0, 180, "Product 97", "product97.jpg", 722.20000000000005, 1 },
                    { 98, 36, 19, 19, 1723791749.5483103, "Description for product 98", false, 0.0, 109, "Product 98", "product98.jpg", 45.409999999999997, 19 },
                    { 99, 70, 20, 20, 1723791749.5483108, "Description for product 99", false, 0.0, 103, "Product 99", "product99.jpg", 389.51999999999998, 17 },
                    { 100, 86, 21, 1, 1723791749.5483117, "Description for product 100", false, 0.0, 29, "Product 100", "product100.jpg", 246.13, 16 },
                    { 101, 42, 22, 2, 1723791749.5483122, "Description for product 101", false, 0.0, 156, "Product 101", "product101.jpg", 544.19000000000005, 16 },
                    { 102, 97, 23, 3, 1723791749.5483129, "Description for product 102", false, 0.0, 181, "Product 102", "product102.jpg", 178.71000000000001, 14 },
                    { 103, 33, 24, 4, 1723791749.5483136, "Description for product 103", false, 0.0, 50, "Product 103", "product103.jpg", 117.93000000000001, 14 },
                    { 104, 90, 25, 5, 1723791749.5483141, "Description for product 104", false, 0.0, 62, "Product 104", "product104.jpg", 633.25, 9 },
                    { 105, 79, 26, 6, 1723791749.5483148, "Description for product 105", false, 0.0, 152, "Product 105", "product105.jpg", 639.44000000000005, 1 },
                    { 106, 60, 27, 7, 1723791749.5483155, "Description for product 106", false, 0.0, 118, "Product 106", "product106.jpg", 729.28999999999996, 4 },
                    { 107, 3, 28, 8, 1723791749.5483205, "Description for product 107", false, 0.0, 96, "Product 107", "product107.jpg", 107.23999999999999, 3 },
                    { 108, 63, 29, 9, 1723791749.5483212, "Description for product 108", false, 0.0, 71, "Product 108", "product108.jpg", 835.99000000000001, 5 },
                    { 109, 38, 30, 10, 1723791749.548322, "Description for product 109", false, 0.0, 114, "Product 109", "product109.jpg", 517.22000000000003, 6 },
                    { 110, 59, 31, 11, 1723791749.5483227, "Description for product 110", false, 0.0, 68, "Product 110", "product110.jpg", 613.14999999999998, 2 },
                    { 111, 92, 32, 12, 1723791749.5483232, "Description for product 111", false, 0.0, 85, "Product 111", "product111.jpg", 987.65999999999997, 2 },
                    { 112, 27, 33, 13, 1723791749.5483241, "Description for product 112", false, 0.0, 107, "Product 112", "product112.jpg", 187.38999999999999, 6 },
                    { 113, 92, 34, 14, 1723791749.5483243, "Description for product 113", false, 0.0, 94, "Product 113", "product113.jpg", 603.52999999999997, 8 },
                    { 114, 13, 35, 15, 1723791749.5483253, "Description for product 114", false, 0.0, 149, "Product 114", "product114.jpg", 918.91999999999996, 5 },
                    { 115, 67, 36, 16, 1723791749.5483258, "Description for product 115", false, 0.0, 60, "Product 115", "product115.jpg", 795.40999999999997, 11 },
                    { 116, 53, 37, 17, 1723791749.5483265, "Description for product 116", false, 0.0, 54, "Product 116", "product116.jpg", 946.59000000000003, 19 },
                    { 117, 91, 38, 18, 1723791749.548327, "Description for product 117", false, 0.0, 105, "Product 117", "product117.jpg", 225.91999999999999, 2 },
                    { 118, 19, 39, 19, 1723791749.5483277, "Description for product 118", false, 0.0, 195, "Product 118", "product118.jpg", 713.12, 10 },
                    { 119, 78, 40, 20, 1723791749.5483284, "Description for product 119", false, 0.0, 165, "Product 119", "product119.jpg", 862.15999999999997, 2 },
                    { 120, 51, 1, 1, 1723791749.5483291, "Description for product 120", false, 0.0, 77, "Product 120", "product120.jpg", 28.510000000000002, 7 },
                    { 121, 3, 2, 2, 1723791749.5483327, "Description for product 121", false, 0.0, 123, "Product 121", "product121.jpg", 403.42000000000002, 19 },
                    { 122, 70, 3, 3, 1723791749.5483336, "Description for product 122", false, 0.0, 102, "Product 122", "product122.jpg", 90.810000000000002, 3 },
                    { 123, 46, 4, 4, 1723791749.5483341, "Description for product 123", false, 0.0, 142, "Product 123", "product123.jpg", 58.119999999999997, 18 },
                    { 124, 86, 5, 5, 1723791749.5483348, "Description for product 124", false, 0.0, 114, "Product 124", "product124.jpg", 684.58000000000004, 6 },
                    { 125, 63, 6, 6, 1723791749.5483356, "Description for product 125", false, 0.0, 69, "Product 125", "product125.jpg", 817.30999999999995, 8 },
                    { 126, 18, 7, 7, 1723791749.548336, "Description for product 126", false, 0.0, 99, "Product 126", "product126.jpg", 540.77999999999997, 2 },
                    { 127, 44, 8, 8, 1723791749.5483367, "Description for product 127", false, 0.0, 70, "Product 127", "product127.jpg", 396.49000000000001, 8 },
                    { 128, 91, 9, 9, 1723791749.5483375, "Description for product 128", false, 0.0, 186, "Product 128", "product128.jpg", 418.60000000000002, 2 },
                    { 129, 32, 10, 10, 1723791749.5483379, "Description for product 129", false, 0.0, 40, "Product 129", "product129.jpg", 772.92999999999995, 16 },
                    { 130, 84, 11, 11, 1723791749.5483389, "Description for product 130", false, 0.0, 127, "Product 130", "product130.jpg", 358.0, 2 },
                    { 131, 8, 12, 12, 1723791749.548342, "Description for product 131", false, 0.0, 101, "Product 131", "product131.jpg", 787.47000000000003, 1 },
                    { 132, 26, 13, 13, 1723791749.5483427, "Description for product 132", false, 0.0, 87, "Product 132", "product132.jpg", 647.25999999999999, 6 },
                    { 133, 59, 14, 14, 1723791749.5483437, "Description for product 133", false, 0.0, 77, "Product 133", "product133.jpg", 372.13, 19 },
                    { 134, 28, 15, 15, 1723791749.5483441, "Description for product 134", false, 0.0, 177, "Product 134", "product134.jpg", 771.16999999999996, 1 },
                    { 135, 27, 16, 16, 1723791749.5483449, "Description for product 135", false, 0.0, 52, "Product 135", "product135.jpg", 246.43000000000001, 11 },
                    { 136, 15, 17, 17, 1723791749.5483456, "Description for product 136", false, 0.0, 134, "Product 136", "product136.jpg", 55.759999999999998, 10 },
                    { 137, 15, 18, 18, 1723791749.548346, "Description for product 137", false, 0.0, 83, "Product 137", "product137.jpg", 126.62, 11 },
                    { 138, 74, 19, 19, 1723791749.5483468, "Description for product 138", false, 0.0, 57, "Product 138", "product138.jpg", 149.84999999999999, 16 },
                    { 139, 56, 20, 20, 1723791749.5483477, "Description for product 139", false, 0.0, 26, "Product 139", "product139.jpg", 699.41999999999996, 12 },
                    { 140, 15, 21, 1, 1723791749.5483479, "Description for product 140", false, 0.0, 157, "Product 140", "product140.jpg", 22.050000000000001, 15 },
                    { 141, 76, 22, 2, 1723791749.5483489, "Description for product 141", false, 0.0, 124, "Product 141", "product141.jpg", 294.57999999999998, 17 },
                    { 142, 54, 23, 3, 1723791749.5483494, "Description for product 142", false, 0.0, 141, "Product 142", "product142.jpg", 614.34000000000003, 7 },
                    { 143, 82, 24, 4, 1723791749.5483501, "Description for product 143", false, 0.0, 139, "Product 143", "product143.jpg", 706.25999999999999, 17 },
                    { 144, 76, 25, 5, 1723791749.5483506, "Description for product 144", false, 0.0, 101, "Product 144", "product144.jpg", 246.28, 12 },
                    { 145, 45, 26, 6, 1723791749.5483537, "Description for product 145", false, 0.0, 35, "Product 145", "product145.jpg", 436.00999999999999, 14 },
                    { 146, 18, 27, 7, 1723791749.5483544, "Description for product 146", false, 0.0, 123, "Product 146", "product146.jpg", 462.56, 7 },
                    { 147, 42, 28, 8, 1723791749.5483551, "Description for product 147", false, 0.0, 147, "Product 147", "product147.jpg", 499.50999999999999, 17 },
                    { 148, 88, 29, 9, 1723791749.5483556, "Description for product 148", false, 0.0, 108, "Product 148", "product148.jpg", 138.83000000000001, 12 },
                    { 149, 24, 30, 10, 1723791749.5483563, "Description for product 149", false, 0.0, 152, "Product 149", "product149.jpg", 831.91999999999996, 8 },
                    { 150, 98, 31, 11, 1723791749.548357, "Description for product 150", false, 0.0, 62, "Product 150", "product150.jpg", 182.24000000000001, 16 },
                    { 151, 55, 32, 12, 1723791749.5483575, "Description for product 151", false, 0.0, 153, "Product 151", "product151.jpg", 214.59999999999999, 11 },
                    { 152, 63, 33, 13, 1723791749.5483584, "Description for product 152", false, 0.0, 46, "Product 152", "product152.jpg", 872.69000000000005, 10 },
                    { 153, 32, 34, 14, 1723791749.5483589, "Description for product 153", false, 0.0, 122, "Product 153", "product153.jpg", 943.03999999999996, 10 },
                    { 154, 22, 35, 15, 1723791749.5483596, "Description for product 154", false, 0.0, 54, "Product 154", "product154.jpg", 662.23000000000002, 12 },
                    { 155, 96, 36, 16, 1723791749.5483601, "Description for product 155", false, 0.0, 178, "Product 155", "product155.jpg", 274.80000000000001, 5 },
                    { 156, 23, 37, 17, 1723791749.5483608, "Description for product 156", false, 0.0, 120, "Product 156", "product156.jpg", 672.08000000000004, 2 },
                    { 157, 15, 38, 18, 1723791749.5483613, "Description for product 157", false, 0.0, 123, "Product 157", "product157.jpg", 204.72999999999999, 3 },
                    { 158, 39, 39, 19, 1723791749.548362, "Description for product 158", false, 0.0, 71, "Product 158", "product158.jpg", 421.70999999999998, 16 },
                    { 159, 92, 40, 20, 1723791749.5483649, "Description for product 159", false, 0.0, 176, "Product 159", "product159.jpg", 520.25999999999999, 7 },
                    { 160, 36, 1, 1, 1723791749.5483656, "Description for product 160", false, 0.0, 90, "Product 160", "product160.jpg", 594.78999999999996, 19 },
                    { 161, 35, 2, 2, 1723791749.5483663, "Description for product 161", false, 0.0, 154, "Product 161", "product161.jpg", 90.420000000000002, 2 },
                    { 162, 61, 3, 3, 1723791749.5483668, "Description for product 162", false, 0.0, 98, "Product 162", "product162.jpg", 350.47000000000003, 2 },
                    { 163, 95, 4, 4, 1723791749.5483675, "Description for product 163", false, 0.0, 113, "Product 163", "product163.jpg", 900.38, 2 },
                    { 164, 33, 5, 5, 1723791749.5483682, "Description for product 164", false, 0.0, 112, "Product 164", "product164.jpg", 390.79000000000002, 9 },
                    { 165, 97, 6, 6, 1723791749.5483687, "Description for product 165", false, 0.0, 158, "Product 165", "product165.jpg", 274.5, 14 },
                    { 166, 23, 7, 7, 1723791749.5483694, "Description for product 166", false, 0.0, 113, "Product 166", "product166.jpg", 528.21000000000004, 16 },
                    { 167, 88, 8, 8, 1723791749.5483699, "Description for product 167", false, 0.0, 73, "Product 167", "product167.jpg", 72.939999999999998, 10 },
                    { 168, 89, 9, 9, 1723791749.5483706, "Description for product 168", false, 0.0, 162, "Product 168", "product168.jpg", 539.25, 15 },
                    { 169, 63, 10, 10, 1723791749.5483713, "Description for product 169", false, 0.0, 156, "Product 169", "product169.jpg", 785.87, 5 },
                    { 170, 51, 11, 11, 1723791749.548372, "Description for product 170", false, 0.0, 95, "Product 170", "product170.jpg", 115.29000000000001, 15 },
                    { 171, 70, 12, 12, 1723791749.5483725, "Description for product 171", false, 0.0, 94, "Product 171", "product171.jpg", 140.90000000000001, 1 },
                    { 172, 32, 13, 13, 1723791749.5483732, "Description for product 172", false, 0.0, 26, "Product 172", "product172.jpg", 493.67000000000002, 9 },
                    { 173, 89, 14, 14, 1723791749.5483739, "Description for product 173", false, 0.0, 66, "Product 173", "product173.jpg", 247.75, 5 },
                    { 174, 40, 15, 15, 1723791749.5483768, "Description for product 174", false, 0.0, 146, "Product 174", "product174.jpg", 931.52999999999997, 3 },
                    { 175, 40, 16, 16, 1723791749.5483775, "Description for product 175", false, 0.0, 98, "Product 175", "product175.jpg", 382.68000000000001, 18 },
                    { 176, 4, 17, 17, 1723791749.5483785, "Description for product 176", false, 0.0, 34, "Product 176", "product176.jpg", 579.50999999999999, 12 },
                    { 177, 80, 18, 18, 1723791749.5483787, "Description for product 177", false, 0.0, 42, "Product 177", "product177.jpg", 300.80000000000001, 2 },
                    { 178, 92, 19, 19, 1723791749.5483797, "Description for product 178", false, 0.0, 87, "Product 178", "product178.jpg", 597.25, 1 },
                    { 179, 51, 20, 20, 1723791749.5483801, "Description for product 179", false, 0.0, 165, "Product 179", "product179.jpg", 867.87, 17 },
                    { 180, 78, 21, 1, 1723791749.5483809, "Description for product 180", false, 0.0, 169, "Product 180", "product180.jpg", 801.22000000000003, 3 },
                    { 181, 88, 22, 2, 1723791749.5483816, "Description for product 181", false, 0.0, 114, "Product 181", "product181.jpg", 706.38999999999999, 9 },
                    { 182, 69, 23, 3, 1723791749.5483823, "Description for product 182", false, 0.0, 101, "Product 182", "product182.jpg", 21.710000000000001, 12 },
                    { 183, 71, 24, 4, 1723791749.5483828, "Description for product 183", false, 0.0, 172, "Product 183", "product183.jpg", 739.52999999999997, 18 },
                    { 184, 89, 25, 5, 1723791749.5483835, "Description for product 184", false, 0.0, 106, "Product 184", "product184.jpg", 777.0, 6 },
                    { 185, 33, 26, 6, 1723791749.548384, "Description for product 185", false, 0.0, 123, "Product 185", "product185.jpg", 542.92999999999995, 10 },
                    { 186, 67, 27, 7, 1723791749.5483849, "Description for product 186", false, 0.0, 30, "Product 186", "product186.jpg", 391.13, 11 },
                    { 187, 78, 28, 8, 1723791749.5483851, "Description for product 187", false, 0.0, 87, "Product 187", "product187.jpg", 491.52999999999997, 11 },
                    { 188, 83, 29, 9, 1723791749.5483885, "Description for product 188", false, 0.0, 135, "Product 188", "product188.jpg", 133.03999999999999, 10 },
                    { 189, 67, 30, 10, 1723791749.5483887, "Description for product 189", false, 0.0, 147, "Product 189", "product189.jpg", 470.01999999999998, 2 },
                    { 190, 94, 31, 11, 1723791749.5483897, "Description for product 190", false, 0.0, 163, "Product 190", "product190.jpg", 318.13999999999999, 12 },
                    { 191, 48, 32, 12, 1723791749.5483899, "Description for product 191", false, 0.0, 31, "Product 191", "product191.jpg", 621.98000000000002, 4 },
                    { 192, 79, 33, 13, 1723791749.5483909, "Description for product 192", false, 0.0, 111, "Product 192", "product192.jpg", 666.57000000000005, 17 },
                    { 193, 24, 34, 14, 1723791749.5483913, "Description for product 193", false, 0.0, 173, "Product 193", "product193.jpg", 817.63999999999999, 4 },
                    { 194, 52, 35, 15, 1723791749.5483921, "Description for product 194", false, 0.0, 71, "Product 194", "product194.jpg", 977.48000000000002, 7 },
                    { 195, 32, 36, 16, 1723791749.5483925, "Description for product 195", false, 0.0, 167, "Product 195", "product195.jpg", 789.58000000000004, 2 },
                    { 196, 38, 37, 17, 1723791749.5483932, "Description for product 196", false, 0.0, 42, "Product 196", "product196.jpg", 119.7, 7 },
                    { 197, 75, 38, 18, 1723791749.548394, "Description for product 197", false, 0.0, 91, "Product 197", "product197.jpg", 490.69, 15 },
                    { 198, 32, 39, 19, 1723791749.5483947, "Description for product 198", false, 0.0, 195, "Product 198", "product198.jpg", 811.90999999999997, 14 },
                    { 199, 55, 40, 20, 1723791749.5483952, "Description for product 199", false, 0.0, 148, "Product 199", "product199.jpg", 371.82999999999998, 7 },
                    { 200, 75, 1, 1, 1723791749.5483961, "Description for product 200", false, 0.0, 114, "Product 200", "product200.jpg", 721.94000000000005, 5 },
                    { 201, 65, 2, 2, 1723791749.5483966, "Description for product 201", false, 0.0, 189, "Product 201", "product201.jpg", 520.09000000000003, 1 },
                    { 202, 86, 3, 3, 1723791749.5483987, "Description for product 202", false, 0.0, 158, "Product 202", "product202.jpg", 820.58000000000004, 2 },
                    { 203, 47, 4, 4, 1723791749.5483997, "Description for product 203", false, 0.0, 84, "Product 203", "product203.jpg", 46.259999999999998, 14 },
                    { 204, 88, 5, 5, 1723791749.5483999, "Description for product 204", false, 0.0, 68, "Product 204", "product204.jpg", 167.08000000000001, 2 },
                    { 205, 43, 6, 6, 1723791749.5484009, "Description for product 205", false, 0.0, 124, "Product 205", "product205.jpg", 437.42000000000002, 2 },
                    { 206, 80, 7, 7, 1723791749.5484014, "Description for product 206", false, 0.0, 119, "Product 206", "product206.jpg", 842.36000000000001, 12 },
                    { 207, 17, 8, 8, 1723791749.5484021, "Description for product 207", false, 0.0, 105, "Product 207", "product207.jpg", 452.07999999999998, 3 },
                    { 208, 82, 9, 9, 1723791749.5484028, "Description for product 208", false, 0.0, 36, "Product 208", "product208.jpg", 634.71000000000004, 16 },
                    { 209, 25, 10, 10, 1723791749.5484033, "Description for product 209", false, 0.0, 151, "Product 209", "product209.jpg", 209.63999999999999, 16 },
                    { 210, 40, 11, 11, 1723791749.548404, "Description for product 210", false, 0.0, 51, "Product 210", "product210.jpg", 217.88, 12 },
                    { 211, 96, 12, 12, 1723791749.5484047, "Description for product 211", false, 0.0, 192, "Product 211", "product211.jpg", 226.84, 17 },
                    { 212, 41, 13, 13, 1723791749.5484052, "Description for product 212", false, 0.0, 70, "Product 212", "product212.jpg", 484.54000000000002, 14 },
                    { 213, 87, 14, 14, 1723791749.5484059, "Description for product 213", false, 0.0, 87, "Product 213", "product213.jpg", 302.67000000000002, 17 },
                    { 214, 33, 15, 15, 1723791749.5484068, "Description for product 214", false, 0.0, 146, "Product 214", "product214.jpg", 920.96000000000004, 16 },
                    { 215, 92, 16, 16, 1723791749.5484104, "Description for product 215", false, 0.0, 136, "Product 215", "product215.jpg", 822.44000000000005, 7 },
                    { 216, 47, 17, 17, 1723791749.5484109, "Description for product 216", false, 0.0, 60, "Product 216", "product216.jpg", 660.76999999999998, 1 },
                    { 217, 32, 18, 18, 1723791749.5484116, "Description for product 217", false, 0.0, 101, "Product 217", "product217.jpg", 636.63, 13 },
                    { 218, 14, 19, 19, 1723791749.5484123, "Description for product 218", false, 0.0, 161, "Product 218", "product218.jpg", 718.24000000000001, 9 },
                    { 219, 20, 20, 20, 1723791749.5484128, "Description for product 219", false, 0.0, 44, "Product 219", "product219.jpg", 835.88, 13 },
                    { 220, 26, 21, 1, 1723791749.5484135, "Description for product 220", false, 0.0, 105, "Product 220", "product220.jpg", 283.74000000000001, 12 },
                    { 221, 57, 22, 2, 1723791749.548414, "Description for product 221", false, 0.0, 150, "Product 221", "product221.jpg", 22.239999999999998, 15 },
                    { 222, 41, 23, 3, 1723791749.5484147, "Description for product 222", false, 0.0, 59, "Product 222", "product222.jpg", 949.91999999999996, 17 },
                    { 223, 18, 24, 4, 1723791749.5484157, "Description for product 223", false, 0.0, 199, "Product 223", "product223.jpg", 345.04000000000002, 18 },
                    { 224, 39, 25, 5, 1723791749.5484159, "Description for product 224", false, 0.0, 175, "Product 224", "product224.jpg", 789.05999999999995, 17 },
                    { 225, 32, 26, 6, 1723791749.5484169, "Description for product 225", false, 0.0, 170, "Product 225", "product225.jpg", 50.280000000000001, 18 },
                    { 226, 32, 27, 7, 1723791749.5484173, "Description for product 226", false, 0.0, 104, "Product 226", "product226.jpg", 806.66999999999996, 9 },
                    { 227, 83, 28, 8, 1723791749.548418, "Description for product 227", false, 0.0, 153, "Product 227", "product227.jpg", 878.34000000000003, 5 },
                    { 228, 6, 29, 9, 1723791749.5484188, "Description for product 228", false, 0.0, 38, "Product 228", "product228.jpg", 911.09000000000003, 8 },
                    { 229, 79, 30, 10, 1723791749.5484223, "Description for product 229", false, 0.0, 129, "Product 229", "product229.jpg", 605.83000000000004, 8 },
                    { 230, 61, 31, 11, 1723791749.5484233, "Description for product 230", false, 0.0, 43, "Product 230", "product230.jpg", 608.75, 12 },
                    { 231, 95, 32, 12, 1723791749.548424, "Description for product 231", false, 0.0, 186, "Product 231", "product231.jpg", 534.11000000000001, 4 },
                    { 232, 40, 33, 13, 1723791749.5484245, "Description for product 232", false, 0.0, 189, "Product 232", "product232.jpg", 443.01999999999998, 7 },
                    { 233, 69, 34, 14, 1723791749.5484252, "Description for product 233", false, 0.0, 115, "Product 233", "product233.jpg", 982.08000000000004, 6 },
                    { 234, 23, 35, 15, 1723791749.5484259, "Description for product 234", false, 0.0, 67, "Product 234", "product234.jpg", 14.300000000000001, 7 },
                    { 235, 35, 36, 16, 1723791749.5484264, "Description for product 235", false, 0.0, 58, "Product 235", "product235.jpg", 786.63999999999999, 9 },
                    { 236, 95, 37, 17, 1723791749.5484271, "Description for product 236", false, 0.0, 106, "Product 236", "product236.jpg", 470.63999999999999, 9 },
                    { 237, 43, 38, 18, 1723791749.5484278, "Description for product 237", false, 0.0, 29, "Product 237", "product237.jpg", 279.42000000000002, 16 },
                    { 238, 39, 39, 19, 1723791749.5484283, "Description for product 238", false, 0.0, 57, "Product 238", "product238.jpg", 74.480000000000004, 18 },
                    { 239, 47, 40, 20, 1723791749.5484293, "Description for product 239", false, 0.0, 191, "Product 239", "product239.jpg", 276.05000000000001, 1 },
                    { 240, 18, 1, 1, 1723791749.5484295, "Description for product 240", false, 0.0, 84, "Product 240", "product240.jpg", 526.29999999999995, 3 },
                    { 241, 88, 2, 2, 1723791749.5484304, "Description for product 241", false, 0.0, 189, "Product 241", "product241.jpg", 618.88999999999999, 16 },
                    { 242, 58, 3, 3, 1723791749.5484309, "Description for product 242", false, 0.0, 88, "Product 242", "product242.jpg", 426.86000000000001, 9 },
                    { 243, 53, 4, 4, 1723791749.548434, "Description for product 243", false, 0.0, 68, "Product 243", "product243.jpg", 229.66, 7 },
                    { 244, 9, 5, 5, 1723791749.5484345, "Description for product 244", false, 0.0, 194, "Product 244", "product244.jpg", 973.34000000000003, 16 },
                    { 245, 24, 6, 6, 1723791749.5484352, "Description for product 245", false, 0.0, 147, "Product 245", "product245.jpg", 254.22, 10 },
                    { 246, 70, 7, 7, 1723791749.5484357, "Description for product 246", false, 0.0, 150, "Product 246", "product246.jpg", 295.19999999999999, 12 },
                    { 247, 94, 8, 8, 1723791749.5484364, "Description for product 247", false, 0.0, 25, "Product 247", "product247.jpg", 746.27999999999997, 5 },
                    { 248, 42, 9, 9, 1723791749.5484371, "Description for product 248", false, 0.0, 183, "Product 248", "product248.jpg", 638.25999999999999, 1 },
                    { 249, 79, 10, 10, 1723791749.5484376, "Description for product 249", false, 0.0, 119, "Product 249", "product249.jpg", 427.58999999999997, 4 },
                    { 250, 48, 11, 11, 1723791749.5484383, "Description for product 250", false, 0.0, 52, "Product 250", "product250.jpg", 647.08000000000004, 14 },
                    { 251, 85, 12, 12, 1723791749.548439, "Description for product 251", false, 0.0, 47, "Product 251", "product251.jpg", 90.030000000000001, 1 },
                    { 252, 8, 13, 13, 1723791749.5484395, "Description for product 252", false, 0.0, 79, "Product 252", "product252.jpg", 477.23000000000002, 14 },
                    { 253, 59, 14, 14, 1723791749.5484405, "Description for product 253", false, 0.0, 196, "Product 253", "product253.jpg", 378.32999999999998, 17 },
                    { 254, 42, 15, 15, 1723791749.5484407, "Description for product 254", false, 0.0, 111, "Product 254", "product254.jpg", 868.0, 10 },
                    { 255, 56, 16, 16, 1723791749.5484416, "Description for product 255", false, 0.0, 96, "Product 255", "product255.jpg", 595.33000000000004, 13 },
                    { 256, 55, 17, 17, 1723791749.5484421, "Description for product 256", false, 0.0, 192, "Product 256", "product256.jpg", 236.55000000000001, 9 },
                    { 257, 48, 18, 18, 1723791749.5484452, "Description for product 257", false, 0.0, 148, "Product 257", "product257.jpg", 22.48, 2 },
                    { 258, 67, 19, 19, 1723791749.5484459, "Description for product 258", false, 0.0, 130, "Product 258", "product258.jpg", 683.69000000000005, 8 },
                    { 259, 24, 20, 20, 1723791749.5484467, "Description for product 259", false, 0.0, 22, "Product 259", "product259.jpg", 975.12, 3 },
                    { 260, 57, 21, 1, 1723791749.5484471, "Description for product 260", false, 0.0, 128, "Product 260", "product260.jpg", 799.19000000000005, 10 },
                    { 261, 71, 22, 2, 1723791749.5484481, "Description for product 261", false, 0.0, 66, "Product 261", "product261.jpg", 866.65999999999997, 9 },
                    { 262, 9, 23, 3, 1723791749.5484483, "Description for product 262", false, 0.0, 21, "Product 262", "product262.jpg", 248.22999999999999, 16 },
                    { 263, 15, 24, 4, 1723791749.5484493, "Description for product 263", false, 0.0, 110, "Product 263", "product263.jpg", 183.18000000000001, 16 },
                    { 264, 3, 25, 5, 1723791749.5484519, "Description for product 264", false, 0.0, 29, "Product 264", "product264.jpg", 528.69000000000005, 10 },
                    { 265, 25, 26, 6, 1723791749.5484529, "Description for product 265", false, 0.0, 70, "Product 265", "product265.jpg", 747.74000000000001, 19 },
                    { 266, 54, 27, 7, 1723791749.5484533, "Description for product 266", false, 0.0, 133, "Product 266", "product266.jpg", 105.95, 8 },
                    { 267, 12, 28, 8, 1723791749.548454, "Description for product 267", false, 0.0, 44, "Product 267", "product267.jpg", 573.26999999999998, 16 },
                    { 268, 2, 29, 9, 1723791749.5484548, "Description for product 268", false, 0.0, 188, "Product 268", "product268.jpg", 175.15000000000001, 12 },
                    { 269, 34, 30, 10, 1723791749.5484552, "Description for product 269", false, 0.0, 186, "Product 269", "product269.jpg", 710.72000000000003, 14 },
                    { 270, 1, 31, 11, 1723791749.548456, "Description for product 270", false, 0.0, 119, "Product 270", "product270.jpg", 484.22000000000003, 19 },
                    { 271, 3, 32, 12, 1723791749.5484567, "Description for product 271", false, 0.0, 57, "Product 271", "product271.jpg", 221.22, 7 },
                    { 272, 52, 33, 13, 1723791749.5484571, "Description for product 272", false, 0.0, 52, "Product 272", "product272.jpg", 220.02000000000001, 12 },
                    { 273, 69, 34, 14, 1723791749.5484579, "Description for product 273", false, 0.0, 163, "Product 273", "product273.jpg", 279.19, 14 },
                    { 274, 80, 35, 15, 1723791749.5484583, "Description for product 274", false, 0.0, 65, "Product 274", "product274.jpg", 438.82999999999998, 11 },
                    { 275, 9, 36, 16, 1723791749.5484591, "Description for product 275", false, 0.0, 60, "Product 275", "product275.jpg", 183.47999999999999, 9 },
                    { 276, 99, 37, 17, 1723791749.5484595, "Description for product 276", false, 0.0, 51, "Product 276", "product276.jpg", 854.71000000000004, 10 },
                    { 277, 81, 38, 18, 1723791749.5484605, "Description for product 277", false, 0.0, 33, "Product 277", "product277.jpg", 179.25, 2 },
                    { 278, 99, 39, 19, 1723791749.5484631, "Description for product 278", false, 0.0, 197, "Product 278", "product278.jpg", 667.23000000000002, 10 },
                    { 279, 59, 40, 20, 1723791749.5484641, "Description for product 279", false, 0.0, 77, "Product 279", "product279.jpg", 267.83999999999997, 11 },
                    { 280, 27, 1, 1, 1723791749.5484645, "Description for product 280", false, 0.0, 169, "Product 280", "product280.jpg", 942.72000000000003, 1 },
                    { 281, 72, 2, 2, 1723791749.5484653, "Description for product 281", false, 0.0, 30, "Product 281", "product281.jpg", 517.00999999999999, 7 },
                    { 282, 16, 3, 3, 1723791749.548466, "Description for product 282", false, 0.0, 61, "Product 282", "product282.jpg", 743.32000000000005, 11 },
                    { 283, 73, 4, 4, 1723791749.5484664, "Description for product 283", false, 0.0, 194, "Product 283", "product283.jpg", 823.21000000000004, 12 },
                    { 284, 70, 5, 5, 1723791749.5484672, "Description for product 284", false, 0.0, 50, "Product 284", "product284.jpg", 909.19000000000005, 5 },
                    { 285, 61, 6, 6, 1723791749.5484679, "Description for product 285", false, 0.0, 194, "Product 285", "product285.jpg", 530.85000000000002, 13 },
                    { 286, 8, 7, 7, 1723791749.5484684, "Description for product 286", false, 0.0, 45, "Product 286", "product286.jpg", 440.95999999999998, 12 },
                    { 287, 66, 8, 8, 1723791749.5484693, "Description for product 287", false, 0.0, 105, "Product 287", "product287.jpg", 160.88999999999999, 11 },
                    { 288, 89, 9, 9, 1723791749.5484698, "Description for product 288", false, 0.0, 42, "Product 288", "product288.jpg", 535.88999999999999, 3 },
                    { 289, 28, 10, 10, 1723791749.5484705, "Description for product 289", false, 0.0, 53, "Product 289", "product289.jpg", 111.83, 17 },
                    { 290, 15, 11, 11, 1723791749.5484712, "Description for product 290", false, 0.0, 66, "Product 290", "product290.jpg", 215.11000000000001, 13 },
                    { 291, 52, 12, 12, 1723791749.5484717, "Description for product 291", false, 0.0, 144, "Product 291", "product291.jpg", 990.63, 5 },
                    { 292, 30, 13, 13, 1723791749.5484748, "Description for product 292", false, 0.0, 42, "Product 292", "product292.jpg", 551.75999999999999, 11 },
                    { 293, 88, 14, 14, 1723791749.5484755, "Description for product 293", false, 0.0, 49, "Product 293", "product293.jpg", 852.00999999999999, 8 },
                    { 294, 12, 15, 15, 1723791749.5484762, "Description for product 294", false, 0.0, 33, "Product 294", "product294.jpg", 359.88999999999999, 17 },
                    { 295, 68, 16, 16, 1723791749.5484767, "Description for product 295", false, 0.0, 178, "Product 295", "product295.jpg", 789.67999999999995, 19 },
                    { 296, 71, 17, 17, 1723791749.5484776, "Description for product 296", false, 0.0, 55, "Product 296", "product296.jpg", 838.08000000000004, 8 },
                    { 297, 78, 18, 18, 1723791749.5484781, "Description for product 297", false, 0.0, 184, "Product 297", "product297.jpg", 547.19000000000005, 16 },
                    { 298, 4, 19, 19, 1723791749.5484788, "Description for product 298", false, 0.0, 27, "Product 298", "product298.jpg", 250.15000000000001, 15 },
                    { 299, 71, 20, 20, 1723791749.5484793, "Description for product 299", false, 0.0, 99, "Product 299", "product299.jpg", 232.53, 13 },
                    { 300, 64, 21, 1, 1723791749.54848, "Description for product 300", false, 0.0, 48, "Product 300", "product300.jpg", 147.72, 17 },
                    { 301, 64, 22, 2, 1723791749.5484807, "Description for product 301", false, 0.0, 137, "Product 301", "product301.jpg", 552.57000000000005, 7 },
                    { 302, 45, 23, 3, 1723791749.5484812, "Description for product 302", false, 0.0, 86, "Product 302", "product302.jpg", 1.5700000000000001, 11 },
                    { 303, 25, 24, 4, 1723791749.5484819, "Description for product 303", false, 0.0, 108, "Product 303", "product303.jpg", 148.06, 9 },
                    { 304, 62, 25, 5, 1723791749.5484827, "Description for product 304", false, 0.0, 49, "Product 304", "product304.jpg", 794.69000000000005, 5 },
                    { 305, 5, 26, 6, 1723791749.5484831, "Description for product 305", false, 0.0, 158, "Product 305", "product305.jpg", 636.42999999999995, 6 },
                    { 306, 55, 27, 7, 1723791749.5484853, "Description for product 306", false, 0.0, 45, "Product 306", "product306.jpg", 846.25999999999999, 3 },
                    { 307, 20, 28, 8, 1723791749.548486, "Description for product 307", false, 0.0, 155, "Product 307", "product307.jpg", 746.34000000000003, 16 },
                    { 308, 21, 29, 9, 1723791749.5484867, "Description for product 308", false, 0.0, 84, "Product 308", "product308.jpg", 908.15999999999997, 13 },
                    { 309, 6, 30, 10, 1723791749.5484872, "Description for product 309", false, 0.0, 71, "Product 309", "product309.jpg", 350.48000000000002, 3 },
                    { 310, 81, 31, 11, 1723791749.5484879, "Description for product 310", false, 0.0, 167, "Product 310", "product310.jpg", 69.870000000000005, 11 },
                    { 311, 48, 32, 12, 1723791749.5484884, "Description for product 311", false, 0.0, 29, "Product 311", "product311.jpg", 662.91999999999996, 3 },
                    { 312, 10, 33, 13, 1723791749.5484891, "Description for product 312", false, 0.0, 55, "Product 312", "product312.jpg", 211.0, 16 },
                    { 313, 60, 34, 14, 1723791749.5484896, "Description for product 313", false, 0.0, 103, "Product 313", "product313.jpg", 37.539999999999999, 5 },
                    { 314, 65, 35, 15, 1723791749.5484903, "Description for product 314", false, 0.0, 81, "Product 314", "product314.jpg", 632.75999999999999, 11 },
                    { 315, 84, 36, 16, 1723791749.5484908, "Description for product 315", false, 0.0, 173, "Product 315", "product315.jpg", 430.64999999999998, 2 },
                    { 316, 22, 37, 17, 1723791749.5484917, "Description for product 316", false, 0.0, 72, "Product 316", "product316.jpg", 734.27999999999997, 5 },
                    { 317, 94, 38, 18, 1723791749.5484922, "Description for product 317", false, 0.0, 193, "Product 317", "product317.jpg", 836.55999999999995, 11 },
                    { 318, 16, 39, 19, 1723791749.5484929, "Description for product 318", false, 0.0, 100, "Product 318", "product318.jpg", 888.28999999999996, 4 },
                    { 319, 21, 40, 20, 1723791749.5484934, "Description for product 319", false, 0.0, 144, "Product 319", "product319.jpg", 501.38, 4 },
                    { 320, 16, 1, 1, 1723791749.5484972, "Description for product 320", false, 0.0, 163, "Product 320", "product320.jpg", 788.58000000000004, 16 },
                    { 321, 50, 2, 2, 1723791749.5484979, "Description for product 321", false, 0.0, 51, "Product 321", "product321.jpg", 856.75999999999999, 15 },
                    { 322, 54, 3, 3, 1723791749.5484989, "Description for product 322", false, 0.0, 173, "Product 322", "product322.jpg", 480.06, 7 },
                    { 323, 32, 4, 4, 1723791749.5484991, "Description for product 323", false, 0.0, 185, "Product 323", "product323.jpg", 888.03999999999996, 12 },
                    { 324, 95, 5, 5, 1723791749.5485001, "Description for product 324", false, 0.0, 180, "Product 324", "product324.jpg", 933.03999999999996, 12 },
                    { 325, 52, 6, 6, 1723791749.5485005, "Description for product 325", false, 0.0, 130, "Product 325", "product325.jpg", 55.299999999999997, 18 },
                    { 326, 92, 7, 7, 1723791749.5485013, "Description for product 326", false, 0.0, 130, "Product 326", "product326.jpg", 194.80000000000001, 16 },
                    { 327, 19, 8, 8, 1723791749.5485017, "Description for product 327", false, 0.0, 56, "Product 327", "product327.jpg", 262.88999999999999, 12 },
                    { 328, 75, 9, 9, 1723791749.5485024, "Description for product 328", false, 0.0, 44, "Product 328", "product328.jpg", 310.08999999999997, 17 },
                    { 329, 90, 10, 10, 1723791749.5485032, "Description for product 329", false, 0.0, 96, "Product 329", "product329.jpg", 810.64999999999998, 14 },
                    { 330, 39, 11, 11, 1723791749.5485036, "Description for product 330", false, 0.0, 117, "Product 330", "product330.jpg", 356.20999999999998, 12 },
                    { 331, 36, 12, 12, 1723791749.5485044, "Description for product 331", false, 0.0, 118, "Product 331", "product331.jpg", 194.78999999999999, 3 },
                    { 332, 31, 13, 13, 1723791749.5485051, "Description for product 332", false, 0.0, 146, "Product 332", "product332.jpg", 269.50999999999999, 15 },
                    { 333, 17, 14, 14, 1723791749.5485055, "Description for product 333", false, 0.0, 81, "Product 333", "product333.jpg", 234.37, 3 },
                    { 334, 17, 15, 15, 1723791749.5485096, "Description for product 334", false, 0.0, 30, "Product 334", "product334.jpg", 79.390000000000001, 8 },
                    { 335, 29, 16, 16, 1723791749.5485103, "Description for product 335", false, 0.0, 61, "Product 335", "product335.jpg", 41.079999999999998, 3 },
                    { 336, 38, 17, 17, 1723791749.5485108, "Description for product 336", false, 0.0, 107, "Product 336", "product336.jpg", 229.63999999999999, 15 },
                    { 337, 19, 18, 18, 1723791749.5485115, "Description for product 337", false, 0.0, 37, "Product 337", "product337.jpg", 536.57000000000005, 16 },
                    { 338, 31, 19, 19, 1723791749.5485122, "Description for product 338", false, 0.0, 70, "Product 338", "product338.jpg", 62.460000000000001, 3 },
                    { 339, 41, 20, 20, 1723791749.5485127, "Description for product 339", false, 0.0, 148, "Product 339", "product339.jpg", 613.20000000000005, 11 },
                    { 340, 66, 21, 1, 1723791749.5485137, "Description for product 340", false, 0.0, 81, "Product 340", "product340.jpg", 157.13, 17 },
                    { 341, 31, 22, 2, 1723791749.5485139, "Description for product 341", false, 0.0, 26, "Product 341", "product341.jpg", 136.65000000000001, 15 },
                    { 342, 31, 23, 3, 1723791749.5485148, "Description for product 342", false, 0.0, 193, "Product 342", "product342.jpg", 528.85000000000002, 12 },
                    { 343, 59, 24, 4, 1723791749.5485153, "Description for product 343", false, 0.0, 149, "Product 343", "product343.jpg", 853.58000000000004, 18 },
                    { 344, 50, 25, 5, 1723791749.548516, "Description for product 344", false, 0.0, 178, "Product 344", "product344.jpg", 25.739999999999998, 6 },
                    { 345, 64, 26, 6, 1723791749.5485168, "Description for product 345", false, 0.0, 84, "Product 345", "product345.jpg", 903.34000000000003, 11 },
                    { 346, 18, 27, 7, 1723791749.5485175, "Description for product 346", false, 0.0, 27, "Product 346", "product346.jpg", 786.78999999999996, 7 },
                    { 347, 89, 28, 8, 1723791749.5485179, "Description for product 347", false, 0.0, 90, "Product 347", "product347.jpg", 677.74000000000001, 1 },
                    { 348, 74, 29, 9, 1723791749.5485213, "Description for product 348", false, 0.0, 59, "Product 348", "product348.jpg", 881.84000000000003, 5 },
                    { 349, 28, 30, 10, 1723791749.5485218, "Description for product 349", false, 0.0, 67, "Product 349", "product349.jpg", 311.05000000000001, 3 },
                    { 350, 38, 31, 11, 1723791749.5485225, "Description for product 350", false, 0.0, 76, "Product 350", "product350.jpg", 367.80000000000001, 3 },
                    { 351, 18, 32, 12, 1723791749.5485232, "Description for product 351", false, 0.0, 45, "Product 351", "product351.jpg", 202.68000000000001, 2 },
                    { 352, 72, 33, 13, 1723791749.5485237, "Description for product 352", false, 0.0, 24, "Product 352", "product352.jpg", 940.98000000000002, 4 },
                    { 353, 94, 34, 14, 1723791749.5485244, "Description for product 353", false, 0.0, 49, "Product 353", "product353.jpg", 585.03999999999996, 8 },
                    { 354, 66, 35, 15, 1723791749.5485251, "Description for product 354", false, 0.0, 150, "Product 354", "product354.jpg", 861.03999999999996, 3 },
                    { 355, 66, 36, 16, 1723791749.5485256, "Description for product 355", false, 0.0, 72, "Product 355", "product355.jpg", 854.24000000000001, 17 },
                    { 356, 5, 37, 17, 1723791749.5485263, "Description for product 356", false, 0.0, 45, "Product 356", "product356.jpg", 623.25999999999999, 10 },
                    { 357, 47, 38, 18, 1723791749.548527, "Description for product 357", false, 0.0, 26, "Product 357", "product357.jpg", 59.530000000000001, 10 },
                    { 358, 7, 39, 19, 1723791749.5485277, "Description for product 358", false, 0.0, 35, "Product 358", "product358.jpg", 991.80999999999995, 6 },
                    { 359, 66, 40, 20, 1723791749.5485284, "Description for product 359", false, 0.0, 107, "Product 359", "product359.jpg", 465.37, 9 },
                    { 360, 49, 1, 1, 1723791749.5485289, "Description for product 360", false, 0.0, 62, "Product 360", "product360.jpg", 755.57000000000005, 9 },
                    { 361, 85, 2, 2, 1723791749.5485296, "Description for product 361", false, 0.0, 44, "Product 361", "product361.jpg", 642.30999999999995, 12 },
                    { 362, 18, 3, 3, 1723791749.5485327, "Description for product 362", false, 0.0, 100, "Product 362", "product362.jpg", 490.76999999999998, 12 },
                    { 363, 24, 4, 4, 1723791749.5485334, "Description for product 363", false, 0.0, 91, "Product 363", "product363.jpg", 902.19000000000005, 4 },
                    { 364, 75, 5, 5, 1723791749.5485339, "Description for product 364", false, 0.0, 98, "Product 364", "product364.jpg", 431.76999999999998, 13 },
                    { 365, 3, 6, 6, 1723791749.5485349, "Description for product 365", false, 0.0, 175, "Product 365", "product365.jpg", 404.89999999999998, 14 },
                    { 366, 27, 7, 7, 1723791749.5485353, "Description for product 366", false, 0.0, 28, "Product 366", "product366.jpg", 784.15999999999997, 7 },
                    { 367, 14, 8, 8, 1723791749.5485361, "Description for product 367", false, 0.0, 132, "Product 367", "product367.jpg", 195.30000000000001, 19 },
                    { 368, 19, 9, 9, 1723791749.5485368, "Description for product 368", false, 0.0, 148, "Product 368", "product368.jpg", 729.24000000000001, 19 },
                    { 369, 90, 10, 10, 1723791749.5485375, "Description for product 369", false, 0.0, 86, "Product 369", "product369.jpg", 195.25, 3 },
                    { 370, 60, 11, 11, 1723791749.548538, "Description for product 370", false, 0.0, 188, "Product 370", "product370.jpg", 802.17999999999995, 18 },
                    { 371, 49, 12, 12, 1723791749.5485387, "Description for product 371", false, 0.0, 181, "Product 371", "product371.jpg", 827.40999999999997, 19 },
                    { 372, 7, 13, 13, 1723791749.5485392, "Description for product 372", false, 0.0, 188, "Product 372", "product372.jpg", 69.670000000000002, 13 },
                    { 373, 24, 14, 14, 1723791749.5485401, "Description for product 373", false, 0.0, 181, "Product 373", "product373.jpg", 162.59, 17 },
                    { 374, 88, 15, 15, 1723791749.5485404, "Description for product 374", false, 0.0, 31, "Product 374", "product374.jpg", 662.27999999999997, 10 },
                    { 375, 85, 16, 16, 1723791749.5485413, "Description for product 375", false, 0.0, 137, "Product 375", "product375.jpg", 270.93000000000001, 7 },
                    { 376, 46, 17, 17, 1723791749.5485439, "Description for product 376", false, 0.0, 183, "Product 376", "product376.jpg", 646.63, 7 },
                    { 377, 86, 18, 18, 1723791749.5485449, "Description for product 377", false, 0.0, 43, "Product 377", "product377.jpg", 343.64999999999998, 3 },
                    { 378, 70, 19, 19, 1723791749.5485454, "Description for product 378", false, 0.0, 183, "Product 378", "product378.jpg", 597.25999999999999, 9 },
                    { 379, 63, 20, 20, 1723791749.5485461, "Description for product 379", false, 0.0, 170, "Product 379", "product379.jpg", 555.20000000000005, 10 },
                    { 380, 55, 21, 1, 1723791749.5485468, "Description for product 380", false, 0.0, 32, "Product 380", "product380.jpg", 327.18000000000001, 9 },
                    { 381, 19, 22, 2, 1723791749.5485475, "Description for product 381", false, 0.0, 94, "Product 381", "product381.jpg", 825.88, 19 },
                    { 382, 25, 23, 3, 1723791749.548548, "Description for product 382", false, 0.0, 111, "Product 382", "product382.jpg", 43.380000000000003, 3 },
                    { 383, 44, 24, 4, 1723791749.5485487, "Description for product 383", false, 0.0, 65, "Product 383", "product383.jpg", 969.94000000000005, 17 },
                    { 384, 31, 25, 5, 1723791749.5485492, "Description for product 384", false, 0.0, 127, "Product 384", "product384.jpg", 931.82000000000005, 15 },
                    { 385, 69, 26, 6, 1723791749.5485499, "Description for product 385", false, 0.0, 57, "Product 385", "product385.jpg", 953.15999999999997, 18 },
                    { 386, 97, 27, 7, 1723791749.5485504, "Description for product 386", false, 0.0, 74, "Product 386", "product386.jpg", 893.74000000000001, 16 },
                    { 387, 83, 28, 8, 1723791749.5485511, "Description for product 387", false, 0.0, 55, "Product 387", "product387.jpg", 393.92000000000002, 19 },
                    { 388, 15, 29, 9, 1723791749.5485516, "Description for product 388", false, 0.0, 41, "Product 388", "product388.jpg", 348.18000000000001, 3 },
                    { 389, 54, 30, 10, 1723791749.5485525, "Description for product 389", false, 0.0, 98, "Product 389", "product389.jpg", 663.91999999999996, 13 },
                    { 390, 76, 31, 11, 1723791749.5485551, "Description for product 390", false, 0.0, 44, "Product 390", "product390.jpg", 410.10000000000002, 16 },
                    { 391, 15, 32, 12, 1723791749.5485561, "Description for product 391", false, 0.0, 117, "Product 391", "product391.jpg", 487.0, 5 },
                    { 392, 94, 33, 13, 1723791749.5485563, "Description for product 392", false, 0.0, 25, "Product 392", "product392.jpg", 217.72999999999999, 9 },
                    { 393, 39, 34, 14, 1723791749.5485573, "Description for product 393", false, 0.0, 169, "Product 393", "product393.jpg", 354.07999999999998, 17 },
                    { 394, 44, 35, 15, 1723791749.5485578, "Description for product 394", false, 0.0, 123, "Product 394", "product394.jpg", 139.66, 1 },
                    { 395, 67, 36, 16, 1723791749.5485585, "Description for product 395", false, 0.0, 152, "Product 395", "product395.jpg", 646.95000000000005, 12 },
                    { 396, 89, 37, 17, 1723791749.5485592, "Description for product 396", false, 0.0, 188, "Product 396", "product396.jpg", 214.44, 8 },
                    { 397, 9, 38, 18, 1723791749.5485597, "Description for product 397", false, 0.0, 128, "Product 397", "product397.jpg", 104.38, 17 },
                    { 398, 74, 39, 19, 1723791749.5485604, "Description for product 398", false, 0.0, 32, "Product 398", "product398.jpg", 751.80999999999995, 16 },
                    { 399, 89, 40, 20, 1723791749.5485611, "Description for product 399", false, 0.0, 84, "Product 399", "product399.jpg", 912.76999999999998, 17 },
                    { 400, 84, 1, 1, 1723791749.5485616, "Description for product 400", false, 0.0, 112, "Product 400", "product400.jpg", 912.26999999999998, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_CustomerId",
                table: "BasketItems",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BuyerId",
                table: "Orders",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
