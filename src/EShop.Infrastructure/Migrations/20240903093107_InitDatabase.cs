using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
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
                    { 1, "fab1c687-2e21-43a3-b791-83c6d02451ca", "Administrator", "ADMINISTRATOR" },
                    { 2, "b5d403e5-a70d-495f-ac9e-75595a138d45", "Customer", "CUSTOMER" },
                    { 3, "8c1ad43b-5982-4dff-9efe-a8791f78d380", "SalesManager", "SALESMANAGER" },
                    { 4, "d2420ee5-b129-46be-a1fd-81c9cd463965", "StoreManager", "STOREMANAGER" },
                    { 5, "5c9657cb-eceb-4c9c-9cdf-eb651bfd3225", "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "APPLE", 1725355865.9592681, false, 0.0, "Apple" },
                    { 2, "SAMSUNG", 1725355865.9592683, false, 0.0, "Samsung" },
                    { 3, "MICROSOFT", 1725355865.9592683, false, 0.0, "Microsoft" },
                    { 4, "GOOGLE", 1725355865.9592683, false, 0.0, "Google" },
                    { 5, "AMAZON", 1725355865.9592686, false, 0.0, "Amazon" },
                    { 6, "FACEBOOK", 1725355865.9592688, false, 0.0, "Facebook" },
                    { 7, "INTEL", 1725355865.9592688, false, 0.0, "Intel" },
                    { 8, "IBM", 1725355865.9592688, false, 0.0, "IBM" },
                    { 9, "SONY", 1725355865.9592688, false, 0.0, "Sony" },
                    { 10, "DELL", 1725355865.959269, false, 0.0, "Dell" },
                    { 11, "HP", 1725355865.9592693, false, 0.0, "HP" },
                    { 12, "LG", 1725355865.9592693, false, 0.0, "LG" },
                    { 13, "HUAWEI", 1725355865.9592693, false, 0.0, "Huawei" },
                    { 14, "CISCO", 1725355865.9592693, false, 0.0, "Cisco" },
                    { 15, "ORACLE", 1725355865.9592693, false, 0.0, "Oracle" },
                    { 16, "NVIDIA", 1725355865.9592695, false, 0.0, "Nvidia" },
                    { 17, "AMD", 1725355865.9592695, false, 0.0, "AMD" },
                    { 18, "LENOVO", 1725355865.9592695, false, 0.0, "Lenovo" },
                    { 19, "ASUS", 1725355865.9592695, false, 0.0, "Asus" },
                    { 20, "ACER", 1725355865.9592698, false, 0.0, "Acer" },
                    { 21, "NIKE", 1725355865.95927, false, 0.0, "Nike" },
                    { 22, "ADIDAS", 1725355865.95927, false, 0.0, "Adidas" },
                    { 23, "PUMA", 1725355865.95927, false, 0.0, "Puma" },
                    { 24, "UA", 1725355865.95927, false, 0.0, "Under Armour" },
                    { 25, "REEBOK", 1725355865.9592702, false, 0.0, "Reebok" },
                    { 26, "NB", 1725355865.9592705, false, 0.0, "New Balance" },
                    { 27, "ASICS", 1725355865.9592705, false, 0.0, "Asics" },
                    { 28, "CONV", 1725355865.9592705, false, 0.0, "Converse" },
                    { 29, "VANS", 1725355865.9592705, false, 0.0, "Vans" },
                    { 30, "SKETCH", 1725355865.9592707, false, 0.0, "Sketchers" },
                    { 31, "FILA", 1725355865.9592707, false, 0.0, "Fila" },
                    { 32, "HM", 1725355865.9592707, false, 0.0, "H&M" },
                    { 33, "ZARA", 1725355865.9592707, false, 0.0, "Zara" },
                    { 34, "UNIQLO", 1725355865.9592707, false, 0.0, "Uniqlo" },
                    { 35, "GUCCI", 1725355865.959271, false, 0.0, "Gucci" },
                    { 36, "LV", 1725355865.959271, false, 0.0, "Louis Vuitton" },
                    { 37, "PRADA", 1725355865.9592712, false, 0.0, "Prada" },
                    { 38, "CHANEL", 1725355865.9592712, false, 0.0, "Chanel" },
                    { 39, "HERMES", 1725355865.9592712, false, 0.0, "Hermès" },
                    { 40, "BURBERRY", 1725355865.9592714, false, 0.0, "Burberry" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "COMP", 1725355865.9592576, false, 0.0, "Computers & Office Supplies" },
                    { 2, "COLL", 1725355865.9592583, false, 0.0, "Collectibles & Toys" },
                    { 3, "BOOK", 1725355865.9592583, false, 0.0, "Books" },
                    { 4, "FASH", 1725355865.9592586, false, 0.0, "Fashion & Clothes" },
                    { 5, "ELEC", 1725355865.9592588, false, 0.0, "Electronics" },
                    { 6, "FOOD", 1725355865.9592588, false, 0.0, "Food & Groceries" },
                    { 7, "MUSC", 1725355865.9592588, false, 0.0, "Music" },
                    { 8, "TVPJ", 1725355865.9592588, false, 0.0, "TVs & Projectors" },
                    { 9, "HEAL", 1725355865.959259, false, 0.0, "Health & Beauty" },
                    { 10, "HAIR", 1725355865.9592593, false, 0.0, "Home Air Quality" },
                    { 11, "GAMC", 1725355865.9592593, false, 0.0, "Gaming Consoles" },
                    { 12, "CAR", 1725355865.9592593, false, 0.0, "Car & Motorbike Accessories" },
                    { 13, "PHOT", 1725355865.9592595, false, 0.0, "Photo & Video Equipment" },
                    { 14, "SEC", 1725355865.9592595, false, 0.0, "Security & Wi-Fi Devices" },
                    { 15, "PERI", 1725355865.9592595, false, 0.0, "Computer Peripherals" },
                    { 16, "PHON", 1725355865.9592595, false, 0.0, "Phone Accessories" },
                    { 17, "WATCH", 1725355865.9592595, false, 0.0, "Watches" },
                    { 18, "PRNT", 1725355865.9592597, false, 0.0, "Printers" },
                    { 19, "PROJ", 1725355865.9592636, false, 0.0, "Projectors" },
                    { 20, "SKIN", 1725355865.9592638, false, 0.0, "Skin Care Products" },
                    { 21, "PHOT", 1725355865.9592638, false, 0.0, "Photo & Video Equipment" },
                    { 22, "OFFS", 1725355865.959264, false, 0.0, "Office Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "BrandId", "CategoryId", "Created", "Description", "IsDeleted", "LastModified", "MaxStockThreshold", "Name", "PictureFileName", "Price", "RestockThreshold" },
                values: new object[,]
                {
                    { 1, 77, 2, 2, 1725355865.9592741, "Description for product 1", false, 0.0, 149, "Product 1", "product1.jpg", 604.54999999999995, 14 },
                    { 2, 23, 3, 3, 1725355865.9592831, "Description for product 2", false, 0.0, 169, "Product 2", "product2.jpg", 246.53999999999999, 12 },
                    { 3, 41, 4, 4, 1725355865.9592843, "Description for product 3", false, 0.0, 179, "Product 3", "product3.jpg", 816.71000000000004, 3 },
                    { 4, 85, 5, 5, 1725355865.959285, "Description for product 4", false, 0.0, 138, "Product 4", "product4.jpg", 697.15999999999997, 14 },
                    { 5, 32, 6, 6, 1725355865.9592855, "Description for product 5", false, 0.0, 94, "Product 5", "product5.jpg", 68.849999999999994, 18 },
                    { 6, 24, 7, 7, 1725355865.9592865, "Description for product 6", false, 0.0, 63, "Product 6", "product6.jpg", 817.32000000000005, 12 },
                    { 7, 49, 8, 8, 1725355865.9592893, "Description for product 7", false, 0.0, 107, "Product 7", "product7.jpg", 28.050000000000001, 10 },
                    { 8, 65, 9, 9, 1725355865.95929, "Description for product 8", false, 0.0, 45, "Product 8", "product8.jpg", 514.17999999999995, 2 },
                    { 9, 73, 10, 10, 1725355865.9592905, "Description for product 9", false, 0.0, 128, "Product 9", "product9.jpg", 701.01999999999998, 17 },
                    { 10, 37, 11, 11, 1725355865.9592915, "Description for product 10", false, 0.0, 155, "Product 10", "product10.jpg", 61.340000000000003, 4 },
                    { 11, 43, 12, 12, 1725355865.9592924, "Description for product 11", false, 0.0, 149, "Product 11", "product11.jpg", 126.95, 2 },
                    { 12, 85, 13, 13, 1725355865.9592929, "Description for product 12", false, 0.0, 144, "Product 12", "product12.jpg", 979.55999999999995, 10 },
                    { 13, 71, 14, 14, 1725355865.9592936, "Description for product 13", false, 0.0, 80, "Product 13", "product13.jpg", 299.10000000000002, 19 },
                    { 14, 41, 15, 15, 1725355865.9592943, "Description for product 14", false, 0.0, 142, "Product 14", "product14.jpg", 372.82999999999998, 12 },
                    { 15, 74, 16, 16, 1725355865.959295, "Description for product 15", false, 0.0, 68, "Product 15", "product15.jpg", 478.70999999999998, 10 },
                    { 16, 10, 17, 17, 1725355865.9592955, "Description for product 16", false, 0.0, 70, "Product 16", "product16.jpg", 291.30000000000001, 10 },
                    { 17, 85, 18, 18, 1725355865.9592962, "Description for product 17", false, 0.0, 92, "Product 17", "product17.jpg", 507.79000000000002, 8 },
                    { 18, 99, 19, 19, 1725355865.9592967, "Description for product 18", false, 0.0, 24, "Product 18", "product18.jpg", 998.17999999999995, 19 },
                    { 19, 47, 20, 20, 1725355865.9592977, "Description for product 19", false, 0.0, 128, "Product 19", "product19.jpg", 893.63999999999999, 9 },
                    { 20, 87, 21, 1, 1725355865.9592981, "Description for product 20", false, 0.0, 163, "Product 20", "product20.jpg", 541.62, 9 },
                    { 21, 29, 22, 2, 1725355865.9593024, "Description for product 21", false, 0.0, 103, "Product 21", "product21.jpg", 231.16, 1 },
                    { 22, 70, 23, 3, 1725355865.9593029, "Description for product 22", false, 0.0, 142, "Product 22", "product22.jpg", 227.71000000000001, 15 },
                    { 23, 95, 24, 4, 1725355865.9593036, "Description for product 23", false, 0.0, 87, "Product 23", "product23.jpg", 270.94, 1 },
                    { 24, 98, 25, 5, 1725355865.9593041, "Description for product 24", false, 0.0, 192, "Product 24", "product24.jpg", 539.32000000000005, 4 },
                    { 25, 77, 26, 6, 1725355865.9593048, "Description for product 25", false, 0.0, 35, "Product 25", "product25.jpg", 630.02999999999997, 4 },
                    { 26, 76, 27, 7, 1725355865.9593055, "Description for product 26", false, 0.0, 62, "Product 26", "product26.jpg", 671.39999999999998, 19 },
                    { 27, 52, 28, 8, 1725355865.959306, "Description for product 27", false, 0.0, 101, "Product 27", "product27.jpg", 701.95000000000005, 8 },
                    { 28, 14, 29, 9, 1725355865.9593067, "Description for product 28", false, 0.0, 51, "Product 28", "product28.jpg", 605.41999999999996, 18 },
                    { 29, 36, 30, 10, 1725355865.9593074, "Description for product 29", false, 0.0, 158, "Product 29", "product29.jpg", 319.25, 11 },
                    { 30, 6, 31, 11, 1725355865.9593079, "Description for product 30", false, 0.0, 93, "Product 30", "product30.jpg", 881.07000000000005, 9 },
                    { 31, 22, 32, 12, 1725355865.9593086, "Description for product 31", false, 0.0, 145, "Product 31", "product31.jpg", 270.32999999999998, 6 },
                    { 32, 85, 33, 13, 1725355865.9593091, "Description for product 32", false, 0.0, 67, "Product 32", "product32.jpg", 806.38999999999999, 10 },
                    { 33, 95, 34, 14, 1725355865.9593098, "Description for product 33", false, 0.0, 149, "Product 33", "product33.jpg", 588.00999999999999, 3 },
                    { 34, 50, 35, 15, 1725355865.9593129, "Description for product 34", false, 0.0, 164, "Product 34", "product34.jpg", 974.90999999999997, 15 },
                    { 35, 38, 36, 16, 1725355865.9593136, "Description for product 35", false, 0.0, 184, "Product 35", "product35.jpg", 648.90999999999997, 12 },
                    { 36, 33, 37, 17, 1725355865.9593143, "Description for product 36", false, 0.0, 108, "Product 36", "product36.jpg", 678.09000000000003, 8 },
                    { 37, 13, 38, 18, 1725355865.9593153, "Description for product 37", false, 0.0, 127, "Product 37", "product37.jpg", 419.19999999999999, 2 },
                    { 38, 87, 39, 19, 1725355865.9593158, "Description for product 38", false, 0.0, 86, "Product 38", "product38.jpg", 447.54000000000002, 10 },
                    { 39, 71, 40, 20, 1725355865.9593165, "Description for product 39", false, 0.0, 92, "Product 39", "product39.jpg", 98.219999999999999, 18 },
                    { 40, 62, 1, 1, 1725355865.959317, "Description for product 40", false, 0.0, 153, "Product 40", "product40.jpg", 661.5, 16 },
                    { 41, 5, 2, 2, 1725355865.9593177, "Description for product 41", false, 0.0, 97, "Product 41", "product41.jpg", 562.13, 13 },
                    { 42, 12, 3, 3, 1725355865.9593184, "Description for product 42", false, 0.0, 44, "Product 42", "product42.jpg", 688.53999999999996, 18 },
                    { 43, 81, 4, 4, 1725355865.9593189, "Description for product 43", false, 0.0, 113, "Product 43", "product43.jpg", 182.09999999999999, 6 },
                    { 44, 42, 5, 5, 1725355865.9593196, "Description for product 44", false, 0.0, 175, "Product 44", "product44.jpg", 234.21000000000001, 9 },
                    { 45, 17, 6, 6, 1725355865.9593201, "Description for product 45", false, 0.0, 107, "Product 45", "product45.jpg", 893.46000000000004, 6 },
                    { 46, 15, 7, 7, 1725355865.9593208, "Description for product 46", false, 0.0, 164, "Product 46", "product46.jpg", 798.13999999999999, 17 },
                    { 47, 84, 8, 8, 1725355865.9593215, "Description for product 47", false, 0.0, 54, "Product 47", "product47.jpg", 34.159999999999997, 2 },
                    { 48, 75, 9, 9, 1725355865.9593234, "Description for product 48", false, 0.0, 105, "Product 48", "product48.jpg", 925.74000000000001, 5 },
                    { 49, 80, 10, 10, 1725355865.9593239, "Description for product 49", false, 0.0, 120, "Product 49", "product49.jpg", 977.77999999999997, 3 },
                    { 50, 62, 11, 11, 1725355865.9593248, "Description for product 50", false, 0.0, 149, "Product 50", "product50.jpg", 787.28999999999996, 8 },
                    { 51, 11, 12, 12, 1725355865.9593253, "Description for product 51", false, 0.0, 196, "Product 51", "product51.jpg", 285.36000000000001, 19 },
                    { 52, 54, 13, 13, 1725355865.959326, "Description for product 52", false, 0.0, 153, "Product 52", "product52.jpg", 887.63999999999999, 16 },
                    { 53, 3, 14, 14, 1725355865.9593267, "Description for product 53", false, 0.0, 164, "Product 53", "product53.jpg", 391.67000000000002, 15 },
                    { 54, 90, 15, 15, 1725355865.9593272, "Description for product 54", false, 0.0, 92, "Product 54", "product54.jpg", 549.15999999999997, 15 },
                    { 55, 94, 16, 16, 1725355865.9593279, "Description for product 55", false, 0.0, 136, "Product 55", "product55.jpg", 441.16000000000003, 15 },
                    { 56, 72, 17, 17, 1725355865.9593284, "Description for product 56", false, 0.0, 43, "Product 56", "product56.jpg", 756.35000000000002, 9 },
                    { 57, 58, 18, 18, 1725355865.9593291, "Description for product 57", false, 0.0, 105, "Product 57", "product57.jpg", 958.89999999999998, 18 },
                    { 58, 91, 19, 19, 1725355865.9593298, "Description for product 58", false, 0.0, 147, "Product 58", "product58.jpg", 33.549999999999997, 1 },
                    { 59, 58, 20, 20, 1725355865.9593303, "Description for product 59", false, 0.0, 119, "Product 59", "product59.jpg", 237.41, 3 },
                    { 60, 24, 21, 1, 1725355865.959331, "Description for product 60", false, 0.0, 128, "Product 60", "product60.jpg", 992.64999999999998, 7 },
                    { 61, 38, 22, 2, 1725355865.9593315, "Description for product 61", false, 0.0, 98, "Product 61", "product61.jpg", 269.31, 4 },
                    { 62, 25, 23, 3, 1725355865.9593363, "Description for product 62", false, 0.0, 185, "Product 62", "product62.jpg", 87.090000000000003, 8 },
                    { 63, 87, 24, 4, 1725355865.9593372, "Description for product 63", false, 0.0, 176, "Product 63", "product63.jpg", 619.36000000000001, 10 },
                    { 64, 56, 25, 5, 1725355865.9593377, "Description for product 64", false, 0.0, 131, "Product 64", "product64.jpg", 396.12, 11 },
                    { 65, 51, 26, 6, 1725355865.9593384, "Description for product 65", false, 0.0, 22, "Product 65", "product65.jpg", 693.40999999999997, 16 },
                    { 66, 60, 27, 7, 1725355865.9593391, "Description for product 66", false, 0.0, 36, "Product 66", "product66.jpg", 135.86000000000001, 11 },
                    { 67, 77, 28, 8, 1725355865.9593399, "Description for product 67", false, 0.0, 33, "Product 67", "product67.jpg", 349.64999999999998, 12 },
                    { 68, 97, 29, 9, 1725355865.9593403, "Description for product 68", false, 0.0, 187, "Product 68", "product68.jpg", 398.66000000000003, 9 },
                    { 69, 65, 30, 10, 1725355865.9593413, "Description for product 69", false, 0.0, 78, "Product 69", "product69.jpg", 854.54999999999995, 19 },
                    { 70, 9, 31, 11, 1725355865.9593418, "Description for product 70", false, 0.0, 151, "Product 70", "product70.jpg", 279.29000000000002, 5 },
                    { 71, 91, 32, 12, 1725355865.9593425, "Description for product 71", false, 0.0, 90, "Product 71", "product71.jpg", 612.89999999999998, 4 },
                    { 72, 4, 33, 13, 1725355865.959343, "Description for product 72", false, 0.0, 47, "Product 72", "product72.jpg", 598.26999999999998, 15 },
                    { 73, 9, 34, 14, 1725355865.9593437, "Description for product 73", false, 0.0, 125, "Product 73", "product73.jpg", 999.49000000000001, 4 },
                    { 74, 61, 35, 15, 1725355865.9593475, "Description for product 74", false, 0.0, 146, "Product 74", "product74.jpg", 151.72999999999999, 6 },
                    { 75, 21, 36, 16, 1725355865.9593484, "Description for product 75", false, 0.0, 103, "Product 75", "product75.jpg", 529.23000000000002, 15 },
                    { 76, 3, 37, 17, 1725355865.9593489, "Description for product 76", false, 0.0, 188, "Product 76", "product76.jpg", 493.81999999999999, 2 },
                    { 77, 67, 38, 18, 1725355865.9593496, "Description for product 77", false, 0.0, 196, "Product 77", "product77.jpg", 389.93000000000001, 3 },
                    { 78, 11, 39, 19, 1725355865.9593503, "Description for product 78", false, 0.0, 145, "Product 78", "product78.jpg", 279.33999999999997, 12 },
                    { 79, 87, 40, 20, 1725355865.9593508, "Description for product 79", false, 0.0, 160, "Product 79", "product79.jpg", 607.20000000000005, 15 },
                    { 80, 85, 1, 1, 1725355865.9593515, "Description for product 80", false, 0.0, 186, "Product 80", "product80.jpg", 230.31999999999999, 9 },
                    { 81, 4, 2, 2, 1725355865.9593523, "Description for product 81", false, 0.0, 156, "Product 81", "product81.jpg", 473.45999999999998, 2 },
                    { 82, 46, 3, 3, 1725355865.9593527, "Description for product 82", false, 0.0, 195, "Product 82", "product82.jpg", 780.19000000000005, 2 },
                    { 83, 21, 4, 4, 1725355865.9593537, "Description for product 83", false, 0.0, 133, "Product 83", "product83.jpg", 866.39999999999998, 13 },
                    { 84, 30, 5, 5, 1725355865.9593542, "Description for product 84", false, 0.0, 157, "Product 84", "product84.jpg", 82.459999999999994, 19 },
                    { 85, 16, 6, 6, 1725355865.9593549, "Description for product 85", false, 0.0, 67, "Product 85", "product85.jpg", 897.0, 13 },
                    { 86, 91, 7, 7, 1725355865.9593556, "Description for product 86", false, 0.0, 129, "Product 86", "product86.jpg", 675.58000000000004, 5 },
                    { 87, 32, 8, 8, 1725355865.9593561, "Description for product 87", false, 0.0, 50, "Product 87", "product87.jpg", 145.69, 13 },
                    { 88, 11, 9, 9, 1725355865.9593568, "Description for product 88", false, 0.0, 54, "Product 88", "product88.jpg", 398.58999999999997, 15 },
                    { 89, 49, 10, 10, 1725355865.9593599, "Description for product 89", false, 0.0, 98, "Product 89", "product89.jpg", 766.22000000000003, 15 },
                    { 90, 79, 11, 11, 1725355865.9593604, "Description for product 90", false, 0.0, 64, "Product 90", "product90.jpg", 777.52999999999997, 2 },
                    { 91, 54, 12, 12, 1725355865.9593613, "Description for product 91", false, 0.0, 133, "Product 91", "product91.jpg", 806.16999999999996, 13 },
                    { 92, 40, 13, 13, 1725355865.9593618, "Description for product 92", false, 0.0, 194, "Product 92", "product92.jpg", 692.98000000000002, 7 },
                    { 93, 90, 14, 14, 1725355865.9593625, "Description for product 93", false, 0.0, 82, "Product 93", "product93.jpg", 768.89999999999998, 10 },
                    { 94, 34, 15, 15, 1725355865.959363, "Description for product 94", false, 0.0, 26, "Product 94", "product94.jpg", 11.85, 13 },
                    { 95, 20, 16, 16, 1725355865.9593637, "Description for product 95", false, 0.0, 92, "Product 95", "product95.jpg", 277.44, 4 },
                    { 96, 15, 17, 17, 1725355865.9593644, "Description for product 96", false, 0.0, 93, "Product 96", "product96.jpg", 570.22000000000003, 16 },
                    { 97, 57, 18, 18, 1725355865.9593649, "Description for product 97", false, 0.0, 108, "Product 97", "product97.jpg", 260.5, 14 },
                    { 98, 38, 19, 19, 1725355865.9593656, "Description for product 98", false, 0.0, 112, "Product 98", "product98.jpg", 914.28999999999996, 15 },
                    { 99, 59, 20, 20, 1725355865.9593661, "Description for product 99", false, 0.0, 22, "Product 99", "product99.jpg", 325.45999999999998, 2 },
                    { 100, 94, 21, 1, 1725355865.9593668, "Description for product 100", false, 0.0, 183, "Product 100", "product100.jpg", 282.47000000000003, 7 },
                    { 101, 64, 22, 2, 1725355865.9593675, "Description for product 101", false, 0.0, 111, "Product 101", "product101.jpg", 350.72000000000003, 17 },
                    { 102, 2, 23, 3, 1725355865.9593682, "Description for product 102", false, 0.0, 103, "Product 102", "product102.jpg", 568.40999999999997, 1 },
                    { 103, 87, 24, 4, 1725355865.9593711, "Description for product 103", false, 0.0, 67, "Product 103", "product103.jpg", 282.22000000000003, 16 },
                    { 104, 69, 25, 5, 1725355865.959372, "Description for product 104", false, 0.0, 174, "Product 104", "product104.jpg", 57.149999999999999, 6 },
                    { 105, 46, 26, 6, 1725355865.9593725, "Description for product 105", false, 0.0, 138, "Product 105", "product105.jpg", 926.96000000000004, 15 },
                    { 106, 58, 27, 7, 1725355865.9593732, "Description for product 106", false, 0.0, 102, "Product 106", "product106.jpg", 347.99000000000001, 1 },
                    { 107, 86, 28, 8, 1725355865.959374, "Description for product 107", false, 0.0, 184, "Product 107", "product107.jpg", 52.939999999999998, 12 },
                    { 108, 4, 29, 9, 1725355865.9593747, "Description for product 108", false, 0.0, 30, "Product 108", "product108.jpg", 21.800000000000001, 4 },
                    { 109, 82, 30, 10, 1725355865.9593751, "Description for product 109", false, 0.0, 154, "Product 109", "product109.jpg", 599.62, 17 },
                    { 110, 53, 31, 11, 1725355865.9593759, "Description for product 110", false, 0.0, 101, "Product 110", "product110.jpg", 492.49000000000001, 8 },
                    { 111, 18, 32, 12, 1725355865.9593763, "Description for product 111", false, 0.0, 96, "Product 111", "product111.jpg", 653.03999999999996, 14 },
                    { 112, 75, 33, 13, 1725355865.9593773, "Description for product 112", false, 0.0, 169, "Product 112", "product112.jpg", 609.51999999999998, 11 },
                    { 113, 39, 34, 14, 1725355865.9593775, "Description for product 113", false, 0.0, 143, "Product 113", "product113.jpg", 29.41, 12 },
                    { 114, 65, 35, 15, 1725355865.9593785, "Description for product 114", false, 0.0, 49, "Product 114", "product114.jpg", 252.58000000000001, 19 },
                    { 115, 80, 36, 16, 1725355865.959379, "Description for product 115", false, 0.0, 199, "Product 115", "product115.jpg", 875.30999999999995, 4 },
                    { 116, 84, 37, 17, 1725355865.9593797, "Description for product 116", false, 0.0, 127, "Product 116", "product116.jpg", 241.62, 17 },
                    { 117, 23, 38, 18, 1725355865.9593828, "Description for product 117", false, 0.0, 57, "Product 117", "product117.jpg", 294.38, 5 },
                    { 118, 7, 39, 19, 1725355865.9593835, "Description for product 118", false, 0.0, 113, "Product 118", "product118.jpg", 50.619999999999997, 5 },
                    { 119, 40, 40, 20, 1725355865.959384, "Description for product 119", false, 0.0, 119, "Product 119", "product119.jpg", 816.37, 10 },
                    { 120, 65, 1, 1, 1725355865.9593849, "Description for product 120", false, 0.0, 79, "Product 120", "product120.jpg", 411.98000000000002, 3 },
                    { 121, 54, 2, 2, 1725355865.9593854, "Description for product 121", false, 0.0, 44, "Product 121", "product121.jpg", 612.01999999999998, 4 },
                    { 122, 43, 3, 3, 1725355865.9593861, "Description for product 122", false, 0.0, 153, "Product 122", "product122.jpg", 996.27999999999997, 5 },
                    { 123, 45, 4, 4, 1725355865.9593866, "Description for product 123", false, 0.0, 129, "Product 123", "product123.jpg", 300.62, 18 },
                    { 124, 40, 5, 5, 1725355865.9593873, "Description for product 124", false, 0.0, 161, "Product 124", "product124.jpg", 101.72, 10 },
                    { 125, 88, 6, 6, 1725355865.959388, "Description for product 125", false, 0.0, 23, "Product 125", "product125.jpg", 857.61000000000001, 9 },
                    { 126, 29, 7, 7, 1725355865.9593885, "Description for product 126", false, 0.0, 159, "Product 126", "product126.jpg", 407.83999999999997, 1 },
                    { 127, 35, 8, 8, 1725355865.9593892, "Description for product 127", false, 0.0, 186, "Product 127", "product127.jpg", 754.87, 19 },
                    { 128, 37, 9, 9, 1725355865.9593897, "Description for product 128", false, 0.0, 32, "Product 128", "product128.jpg", 791.77999999999997, 10 },
                    { 129, 92, 10, 10, 1725355865.9593904, "Description for product 129", false, 0.0, 30, "Product 129", "product129.jpg", 972.84000000000003, 18 },
                    { 130, 6, 11, 11, 1725355865.9593935, "Description for product 130", false, 0.0, 24, "Product 130", "product130.jpg", 849.90999999999997, 18 },
                    { 131, 28, 12, 12, 1725355865.9593942, "Description for product 131", false, 0.0, 37, "Product 131", "product131.jpg", 884.66999999999996, 4 },
                    { 132, 63, 13, 13, 1725355865.9593947, "Description for product 132", false, 0.0, 121, "Product 132", "product132.jpg", 946.36000000000001, 4 },
                    { 133, 31, 14, 14, 1725355865.9593956, "Description for product 133", false, 0.0, 24, "Product 133", "product133.jpg", 360.33999999999997, 16 },
                    { 134, 68, 15, 15, 1725355865.9593961, "Description for product 134", false, 0.0, 180, "Product 134", "product134.jpg", 262.06999999999999, 4 },
                    { 135, 11, 16, 16, 1725355865.9593968, "Description for product 135", false, 0.0, 130, "Product 135", "product135.jpg", 627.63999999999999, 17 },
                    { 136, 86, 17, 17, 1725355865.9593973, "Description for product 136", false, 0.0, 168, "Product 136", "product136.jpg", 277.14999999999998, 7 },
                    { 137, 7, 18, 18, 1725355865.959398, "Description for product 137", false, 0.0, 129, "Product 137", "product137.jpg", 380.67000000000002, 17 },
                    { 138, 69, 19, 19, 1725355865.9593987, "Description for product 138", false, 0.0, 33, "Product 138", "product138.jpg", 238.43000000000001, 19 },
                    { 139, 40, 20, 20, 1725355865.9593992, "Description for product 139", false, 0.0, 177, "Product 139", "product139.jpg", 103.62, 18 },
                    { 140, 33, 21, 1, 1725355865.9593999, "Description for product 140", false, 0.0, 172, "Product 140", "product140.jpg", 680.48000000000002, 6 },
                    { 141, 96, 22, 2, 1725355865.959403, "Description for product 141", false, 0.0, 26, "Product 141", "product141.jpg", 600.78999999999996, 12 },
                    { 142, 69, 23, 3, 1725355865.9594035, "Description for product 142", false, 0.0, 194, "Product 142", "product142.jpg", 529.25, 3 },
                    { 143, 77, 24, 4, 1725355865.9594045, "Description for product 143", false, 0.0, 103, "Product 143", "product143.jpg", 19.920000000000002, 12 },
                    { 144, 66, 25, 5, 1725355865.9594047, "Description for product 144", false, 0.0, 89, "Product 144", "product144.jpg", 8.7100000000000009, 3 },
                    { 145, 94, 26, 6, 1725355865.9594057, "Description for product 145", false, 0.0, 150, "Product 145", "product145.jpg", 551.17999999999995, 7 },
                    { 146, 56, 27, 7, 1725355865.9594061, "Description for product 146", false, 0.0, 153, "Product 146", "product146.jpg", 529.13999999999999, 9 },
                    { 147, 76, 28, 8, 1725355865.9594069, "Description for product 147", false, 0.0, 110, "Product 147", "product147.jpg", 252.49000000000001, 19 },
                    { 148, 66, 29, 9, 1725355865.9594073, "Description for product 148", false, 0.0, 28, "Product 148", "product148.jpg", 997.14999999999998, 10 },
                    { 149, 28, 30, 10, 1725355865.959408, "Description for product 149", false, 0.0, 145, "Product 149", "product149.jpg", 934.0, 9 },
                    { 150, 69, 31, 11, 1725355865.9594088, "Description for product 150", false, 0.0, 26, "Product 150", "product150.jpg", 174.24000000000001, 7 },
                    { 151, 45, 32, 12, 1725355865.9594095, "Description for product 151", false, 0.0, 143, "Product 151", "product151.jpg", 605.62, 10 },
                    { 152, 55, 33, 13, 1725355865.95941, "Description for product 152", false, 0.0, 178, "Product 152", "product152.jpg", 458.27999999999997, 3 },
                    { 153, 85, 34, 14, 1725355865.9594107, "Description for product 153", false, 0.0, 146, "Product 153", "product153.jpg", 880.15999999999997, 9 },
                    { 154, 7, 35, 15, 1725355865.9594111, "Description for product 154", false, 0.0, 160, "Product 154", "product154.jpg", 68.659999999999997, 1 },
                    { 155, 67, 36, 16, 1725355865.9594133, "Description for product 155", false, 0.0, 111, "Product 155", "product155.jpg", 208.25999999999999, 16 },
                    { 156, 25, 37, 17, 1725355865.9594138, "Description for product 156", false, 0.0, 159, "Product 156", "product156.jpg", 395.0, 11 },
                    { 157, 38, 38, 18, 1725355865.9594145, "Description for product 157", false, 0.0, 112, "Product 157", "product157.jpg", 47.350000000000001, 14 },
                    { 158, 87, 39, 19, 1725355865.959415, "Description for product 158", false, 0.0, 114, "Product 158", "product158.jpg", 41.170000000000002, 2 },
                    { 159, 37, 40, 20, 1725355865.9594157, "Description for product 159", false, 0.0, 51, "Product 159", "product159.jpg", 12.789999999999999, 14 },
                    { 160, 23, 1, 1, 1725355865.9594164, "Description for product 160", false, 0.0, 164, "Product 160", "product160.jpg", 644.75999999999999, 8 },
                    { 161, 25, 2, 2, 1725355865.9594169, "Description for product 161", false, 0.0, 53, "Product 161", "product161.jpg", 771.48000000000002, 13 },
                    { 162, 81, 3, 3, 1725355865.9594176, "Description for product 162", false, 0.0, 124, "Product 162", "product162.jpg", 119.13, 16 },
                    { 163, 92, 4, 4, 1725355865.9594181, "Description for product 163", false, 0.0, 117, "Product 163", "product163.jpg", 154.25, 2 },
                    { 164, 16, 5, 5, 1725355865.9594188, "Description for product 164", false, 0.0, 87, "Product 164", "product164.jpg", 783.38999999999999, 17 },
                    { 165, 24, 6, 6, 1725355865.9594195, "Description for product 165", false, 0.0, 152, "Product 165", "product165.jpg", 757.09000000000003, 6 },
                    { 166, 54, 7, 7, 1725355865.95942, "Description for product 166", false, 0.0, 72, "Product 166", "product166.jpg", 176.19999999999999, 4 },
                    { 167, 25, 8, 8, 1725355865.9594207, "Description for product 167", false, 0.0, 44, "Product 167", "product167.jpg", 732.42999999999995, 9 },
                    { 168, 74, 9, 9, 1725355865.9594212, "Description for product 168", false, 0.0, 174, "Product 168", "product168.jpg", 442.55000000000001, 9 },
                    { 169, 29, 10, 10, 1725355865.9594245, "Description for product 169", false, 0.0, 112, "Product 169", "product169.jpg", 433.56, 16 },
                    { 170, 56, 11, 11, 1725355865.9594252, "Description for product 170", false, 0.0, 68, "Product 170", "product170.jpg", 926.76999999999998, 9 },
                    { 171, 74, 12, 12, 1725355865.9594259, "Description for product 171", false, 0.0, 92, "Product 171", "product171.jpg", 611.53999999999996, 2 },
                    { 172, 55, 13, 13, 1725355865.9594266, "Description for product 172", false, 0.0, 105, "Product 172", "product172.jpg", 336.06, 1 },
                    { 173, 55, 14, 14, 1725355865.9594271, "Description for product 173", false, 0.0, 89, "Product 173", "product173.jpg", 683.92999999999995, 12 },
                    { 174, 55, 15, 15, 1725355865.9594281, "Description for product 174", false, 0.0, 32, "Product 174", "product174.jpg", 89.629999999999995, 11 },
                    { 175, 27, 16, 16, 1725355865.9594283, "Description for product 175", false, 0.0, 123, "Product 175", "product175.jpg", 848.86000000000001, 18 },
                    { 176, 77, 17, 17, 1725355865.9594293, "Description for product 176", false, 0.0, 119, "Product 176", "product176.jpg", 891.87, 5 },
                    { 177, 38, 18, 18, 1725355865.9594295, "Description for product 177", false, 0.0, 113, "Product 177", "product177.jpg", 833.77999999999997, 13 },
                    { 178, 11, 19, 19, 1725355865.9594305, "Description for product 178", false, 0.0, 108, "Product 178", "product178.jpg", 850.75999999999999, 17 },
                    { 179, 9, 20, 20, 1725355865.9594307, "Description for product 179", false, 0.0, 133, "Product 179", "product179.jpg", 321.0, 13 },
                    { 180, 59, 21, 1, 1725355865.9594316, "Description for product 180", false, 0.0, 76, "Product 180", "product180.jpg", 849.36000000000001, 4 },
                    { 181, 94, 22, 2, 1725355865.9594321, "Description for product 181", false, 0.0, 176, "Product 181", "product181.jpg", 119.0, 3 },
                    { 182, 54, 23, 3, 1725355865.9594328, "Description for product 182", false, 0.0, 57, "Product 182", "product182.jpg", 463.62, 10 },
                    { 183, 7, 24, 4, 1725355865.9594381, "Description for product 183", false, 0.0, 77, "Product 183", "product183.jpg", 426.56, 14 },
                    { 184, 41, 25, 5, 1725355865.9594383, "Description for product 184", false, 0.0, 130, "Product 184", "product184.jpg", 64.209999999999994, 7 },
                    { 185, 13, 26, 6, 1725355865.9594393, "Description for product 185", false, 0.0, 144, "Product 185", "product185.jpg", 345.91000000000003, 6 },
                    { 186, 82, 27, 7, 1725355865.9594398, "Description for product 186", false, 0.0, 95, "Product 186", "product186.jpg", 432.85000000000002, 6 },
                    { 187, 20, 28, 8, 1725355865.9594405, "Description for product 187", false, 0.0, 123, "Product 187", "product187.jpg", 456.70999999999998, 3 },
                    { 188, 70, 29, 9, 1725355865.9594409, "Description for product 188", false, 0.0, 158, "Product 188", "product188.jpg", 177.31, 18 },
                    { 189, 55, 30, 10, 1725355865.9594417, "Description for product 189", false, 0.0, 61, "Product 189", "product189.jpg", 811.89999999999998, 4 },
                    { 190, 35, 31, 11, 1725355865.9594424, "Description for product 190", false, 0.0, 89, "Product 190", "product190.jpg", 769.10000000000002, 14 },
                    { 191, 10, 32, 12, 1725355865.9594429, "Description for product 191", false, 0.0, 83, "Product 191", "product191.jpg", 214.18000000000001, 16 },
                    { 192, 46, 33, 13, 1725355865.9594436, "Description for product 192", false, 0.0, 62, "Product 192", "product192.jpg", 443.81, 11 },
                    { 193, 48, 34, 14, 1725355865.959444, "Description for product 193", false, 0.0, 58, "Product 193", "product193.jpg", 880.28999999999996, 14 },
                    { 194, 14, 35, 15, 1725355865.9594448, "Description for product 194", false, 0.0, 198, "Product 194", "product194.jpg", 583.76999999999998, 3 },
                    { 195, 66, 36, 16, 1725355865.9594455, "Description for product 195", false, 0.0, 64, "Product 195", "product195.jpg", 138.63999999999999, 3 },
                    { 196, 5, 37, 17, 1725355865.959446, "Description for product 196", false, 0.0, 97, "Product 196", "product196.jpg", 18.68, 2 },
                    { 197, 30, 38, 18, 1725355865.9594488, "Description for product 197", false, 0.0, 196, "Product 197", "product197.jpg", 683.82000000000005, 5 },
                    { 198, 84, 39, 19, 1725355865.9594495, "Description for product 198", false, 0.0, 134, "Product 198", "product198.jpg", 414.18000000000001, 18 },
                    { 199, 83, 40, 20, 1725355865.9594502, "Description for product 199", false, 0.0, 131, "Product 199", "product199.jpg", 322.33999999999997, 13 },
                    { 200, 52, 1, 1, 1725355865.9594507, "Description for product 200", false, 0.0, 31, "Product 200", "product200.jpg", 620.65999999999997, 16 },
                    { 201, 25, 2, 2, 1725355865.9594517, "Description for product 201", false, 0.0, 164, "Product 201", "product201.jpg", 276.69, 14 },
                    { 202, 62, 3, 3, 1725355865.9594519, "Description for product 202", false, 0.0, 110, "Product 202", "product202.jpg", 251.46000000000001, 16 },
                    { 203, 75, 4, 4, 1725355865.9594529, "Description for product 203", false, 0.0, 118, "Product 203", "product203.jpg", 390.69999999999999, 19 },
                    { 204, 82, 5, 5, 1725355865.9594533, "Description for product 204", false, 0.0, 189, "Product 204", "product204.jpg", 314.62, 3 },
                    { 205, 29, 6, 6, 1725355865.9594541, "Description for product 205", false, 0.0, 165, "Product 205", "product205.jpg", 83.799999999999997, 14 },
                    { 206, 55, 7, 7, 1725355865.9594548, "Description for product 206", false, 0.0, 61, "Product 206", "product206.jpg", 464.80000000000001, 7 },
                    { 207, 4, 8, 8, 1725355865.9594553, "Description for product 207", false, 0.0, 85, "Product 207", "product207.jpg", 509.52999999999997, 15 },
                    { 208, 31, 9, 9, 1725355865.959456, "Description for product 208", false, 0.0, 146, "Product 208", "product208.jpg", 801.62, 1 },
                    { 209, 65, 10, 10, 1725355865.9594564, "Description for product 209", false, 0.0, 117, "Product 209", "product209.jpg", 491.64999999999998, 19 },
                    { 210, 99, 11, 11, 1725355865.9594572, "Description for product 210", false, 0.0, 131, "Product 210", "product210.jpg", 988.66999999999996, 8 },
                    { 211, 21, 12, 12, 1725355865.9594595, "Description for product 211", false, 0.0, 94, "Product 211", "product211.jpg", 282.49000000000001, 18 },
                    { 212, 36, 13, 13, 1725355865.9594605, "Description for product 212", false, 0.0, 143, "Product 212", "product212.jpg", 794.55999999999995, 10 },
                    { 213, 95, 14, 14, 1725355865.9594607, "Description for product 213", false, 0.0, 40, "Product 213", "product213.jpg", 646.01999999999998, 10 },
                    { 214, 10, 15, 15, 1725355865.9594617, "Description for product 214", false, 0.0, 114, "Product 214", "product214.jpg", 74.920000000000002, 6 },
                    { 215, 43, 16, 16, 1725355865.9594619, "Description for product 215", false, 0.0, 145, "Product 215", "product215.jpg", 493.50999999999999, 2 },
                    { 216, 62, 17, 17, 1725355865.9594629, "Description for product 216", false, 0.0, 185, "Product 216", "product216.jpg", 421.25, 16 },
                    { 217, 28, 18, 18, 1725355865.9594634, "Description for product 217", false, 0.0, 150, "Product 217", "product217.jpg", 707.75, 14 },
                    { 218, 67, 19, 19, 1725355865.9594641, "Description for product 218", false, 0.0, 109, "Product 218", "product218.jpg", 196.38, 16 },
                    { 219, 21, 20, 20, 1725355865.9594646, "Description for product 219", false, 0.0, 167, "Product 219", "product219.jpg", 246.97, 11 },
                    { 220, 67, 21, 1, 1725355865.9594653, "Description for product 220", false, 0.0, 148, "Product 220", "product220.jpg", 932.52999999999997, 18 },
                    { 221, 52, 22, 2, 1725355865.9594657, "Description for product 221", false, 0.0, 131, "Product 221", "product221.jpg", 844.40999999999997, 17 },
                    { 222, 72, 23, 3, 1725355865.9594665, "Description for product 222", false, 0.0, 132, "Product 222", "product222.jpg", 923.96000000000004, 3 },
                    { 223, 70, 24, 4, 1725355865.9594672, "Description for product 223", false, 0.0, 123, "Product 223", "product223.jpg", 910.80999999999995, 9 },
                    { 224, 98, 25, 5, 1725355865.9594676, "Description for product 224", false, 0.0, 132, "Product 224", "product224.jpg", 957.47000000000003, 8 },
                    { 225, 81, 26, 6, 1725355865.9594705, "Description for product 225", false, 0.0, 174, "Product 225", "product225.jpg", 666.72000000000003, 9 },
                    { 226, 50, 27, 7, 1725355865.959471, "Description for product 226", false, 0.0, 60, "Product 226", "product226.jpg", 515.52999999999997, 3 },
                    { 227, 53, 28, 8, 1725355865.9594717, "Description for product 227", false, 0.0, 86, "Product 227", "product227.jpg", 544.27999999999997, 7 },
                    { 228, 31, 29, 9, 1725355865.9594724, "Description for product 228", false, 0.0, 187, "Product 228", "product228.jpg", 751.39999999999998, 17 },
                    { 229, 42, 30, 10, 1725355865.9594729, "Description for product 229", false, 0.0, 90, "Product 229", "product229.jpg", 608.17999999999995, 17 },
                    { 230, 97, 31, 11, 1725355865.9594736, "Description for product 230", false, 0.0, 69, "Product 230", "product230.jpg", 439.52999999999997, 4 },
                    { 231, 93, 32, 12, 1725355865.9594741, "Description for product 231", false, 0.0, 42, "Product 231", "product231.jpg", 343.50999999999999, 13 },
                    { 232, 72, 33, 13, 1725355865.9594748, "Description for product 232", false, 0.0, 75, "Product 232", "product232.jpg", 961.42999999999995, 4 },
                    { 233, 20, 34, 14, 1725355865.9594755, "Description for product 233", false, 0.0, 66, "Product 233", "product233.jpg", 714.57000000000005, 7 },
                    { 234, 46, 35, 15, 1725355865.959476, "Description for product 234", false, 0.0, 60, "Product 234", "product234.jpg", 591.27999999999997, 19 },
                    { 235, 13, 36, 16, 1725355865.9594767, "Description for product 235", false, 0.0, 167, "Product 235", "product235.jpg", 449.56999999999999, 6 },
                    { 236, 17, 37, 17, 1725355865.9594772, "Description for product 236", false, 0.0, 174, "Product 236", "product236.jpg", 146.77000000000001, 4 },
                    { 237, 61, 38, 18, 1725355865.9594779, "Description for product 237", false, 0.0, 90, "Product 237", "product237.jpg", 575.74000000000001, 11 },
                    { 238, 89, 39, 19, 1725355865.9594784, "Description for product 238", false, 0.0, 79, "Product 238", "product238.jpg", 689.41999999999996, 18 },
                    { 239, 24, 40, 20, 1725355865.959481, "Description for product 239", false, 0.0, 127, "Product 239", "product239.jpg", 583.91999999999996, 13 },
                    { 240, 14, 1, 1, 1725355865.9594817, "Description for product 240", false, 0.0, 116, "Product 240", "product240.jpg", 635.67999999999995, 16 },
                    { 241, 23, 2, 2, 1725355865.9594824, "Description for product 241", false, 0.0, 153, "Product 241", "product241.jpg", 727.07000000000005, 17 },
                    { 242, 27, 3, 3, 1725355865.9594829, "Description for product 242", false, 0.0, 132, "Product 242", "product242.jpg", 834.70000000000005, 19 },
                    { 243, 38, 4, 4, 1725355865.9594836, "Description for product 243", false, 0.0, 199, "Product 243", "product243.jpg", 310.17000000000002, 10 },
                    { 244, 51, 5, 5, 1725355865.9594841, "Description for product 244", false, 0.0, 85, "Product 244", "product244.jpg", 751.14999999999998, 2 },
                    { 245, 26, 6, 6, 1725355865.9594848, "Description for product 245", false, 0.0, 34, "Product 245", "product245.jpg", 719.70000000000005, 9 },
                    { 246, 13, 7, 7, 1725355865.9594855, "Description for product 246", false, 0.0, 126, "Product 246", "product246.jpg", 777.46000000000004, 13 },
                    { 247, 10, 8, 8, 1725355865.959486, "Description for product 247", false, 0.0, 140, "Product 247", "product247.jpg", 98.680000000000007, 4 },
                    { 248, 93, 9, 9, 1725355865.9594867, "Description for product 248", false, 0.0, 96, "Product 248", "product248.jpg", 12.630000000000001, 16 },
                    { 249, 73, 10, 10, 1725355865.9594874, "Description for product 249", false, 0.0, 82, "Product 249", "product249.jpg", 626.84000000000003, 5 },
                    { 250, 14, 11, 11, 1725355865.9594879, "Description for product 250", false, 0.0, 139, "Product 250", "product250.jpg", 252.02000000000001, 11 },
                    { 251, 55, 12, 12, 1725355865.9594886, "Description for product 251", false, 0.0, 84, "Product 251", "product251.jpg", 305.55000000000001, 14 },
                    { 252, 41, 13, 13, 1725355865.9594891, "Description for product 252", false, 0.0, 44, "Product 252", "product252.jpg", 81.260000000000005, 17 },
                    { 253, 49, 14, 14, 1725355865.9594917, "Description for product 253", false, 0.0, 152, "Product 253", "product253.jpg", 606.89999999999998, 19 },
                    { 254, 74, 15, 15, 1725355865.9594924, "Description for product 254", false, 0.0, 31, "Product 254", "product254.jpg", 698.16999999999996, 5 },
                    { 255, 75, 16, 16, 1725355865.9594932, "Description for product 255", false, 0.0, 107, "Product 255", "product255.jpg", 892.05999999999995, 14 },
                    { 256, 30, 17, 17, 1725355865.9594936, "Description for product 256", false, 0.0, 53, "Product 256", "product256.jpg", 431.39999999999998, 17 },
                    { 257, 71, 18, 18, 1725355865.9594944, "Description for product 257", false, 0.0, 127, "Product 257", "product257.jpg", 564.54999999999995, 1 },
                    { 258, 62, 19, 19, 1725355865.9594953, "Description for product 258", false, 0.0, 102, "Product 258", "product258.jpg", 710.25, 2 },
                    { 259, 32, 20, 20, 1725355865.9594955, "Description for product 259", false, 0.0, 138, "Product 259", "product259.jpg", 494.42000000000002, 19 },
                    { 260, 28, 21, 1, 1725355865.9594977, "Description for product 260", false, 0.0, 155, "Product 260", "product260.jpg", 810.34000000000003, 18 },
                    { 261, 77, 22, 2, 1725355865.9594984, "Description for product 261", false, 0.0, 134, "Product 261", "product261.jpg", 830.25999999999999, 8 },
                    { 262, 94, 23, 3, 1725355865.9594989, "Description for product 262", false, 0.0, 186, "Product 262", "product262.jpg", 528.40999999999997, 3 },
                    { 263, 20, 24, 4, 1725355865.9594996, "Description for product 263", false, 0.0, 189, "Product 263", "product263.jpg", 660.88999999999999, 16 },
                    { 264, 80, 25, 5, 1725355865.9595003, "Description for product 264", false, 0.0, 104, "Product 264", "product264.jpg", 753.15999999999997, 16 },
                    { 265, 98, 26, 6, 1725355865.9595008, "Description for product 265", false, 0.0, 165, "Product 265", "product265.jpg", 516.51999999999998, 15 },
                    { 266, 23, 27, 7, 1725355865.9595015, "Description for product 266", false, 0.0, 175, "Product 266", "product266.jpg", 779.11000000000001, 2 },
                    { 267, 59, 28, 8, 1725355865.9595022, "Description for product 267", false, 0.0, 34, "Product 267", "product267.jpg", 705.78999999999996, 6 },
                    { 268, 17, 29, 9, 1725355865.9595027, "Description for product 268", false, 0.0, 99, "Product 268", "product268.jpg", 444.69, 3 },
                    { 269, 8, 30, 10, 1725355865.9595034, "Description for product 269", false, 0.0, 99, "Product 269", "product269.jpg", 246.25999999999999, 8 },
                    { 270, 22, 31, 11, 1725355865.9595039, "Description for product 270", false, 0.0, 93, "Product 270", "product270.jpg", 495.72000000000003, 9 },
                    { 271, 34, 32, 12, 1725355865.9595048, "Description for product 271", false, 0.0, 170, "Product 271", "product271.jpg", 848.00999999999999, 11 },
                    { 272, 55, 33, 13, 1725355865.9595051, "Description for product 272", false, 0.0, 42, "Product 272", "product272.jpg", 550.58000000000004, 13 },
                    { 273, 45, 34, 14, 1725355865.959506, "Description for product 273", false, 0.0, 156, "Product 273", "product273.jpg", 124.14, 2 },
                    { 274, 20, 35, 15, 1725355865.9595091, "Description for product 274", false, 0.0, 94, "Product 274", "product274.jpg", 947.34000000000003, 13 },
                    { 275, 42, 36, 16, 1725355865.9595101, "Description for product 275", false, 0.0, 131, "Product 275", "product275.jpg", 17.559999999999999, 15 },
                    { 276, 95, 37, 17, 1725355865.9595106, "Description for product 276", false, 0.0, 180, "Product 276", "product276.jpg", 735.46000000000004, 17 },
                    { 277, 3, 38, 18, 1725355865.9595113, "Description for product 277", false, 0.0, 162, "Product 277", "product277.jpg", 968.98000000000002, 17 },
                    { 278, 12, 39, 19, 1725355865.959512, "Description for product 278", false, 0.0, 169, "Product 278", "product278.jpg", 780.12, 9 },
                    { 279, 59, 40, 20, 1725355865.9595125, "Description for product 279", false, 0.0, 165, "Product 279", "product279.jpg", 953.65999999999997, 13 },
                    { 280, 45, 1, 1, 1725355865.9595132, "Description for product 280", false, 0.0, 116, "Product 280", "product280.jpg", 292.91000000000003, 10 },
                    { 281, 18, 2, 2, 1725355865.9595139, "Description for product 281", false, 0.0, 157, "Product 281", "product281.jpg", 103.56999999999999, 1 },
                    { 282, 65, 3, 3, 1725355865.9595144, "Description for product 282", false, 0.0, 98, "Product 282", "product282.jpg", 396.74000000000001, 17 },
                    { 283, 8, 4, 4, 1725355865.9595151, "Description for product 283", false, 0.0, 178, "Product 283", "product283.jpg", 734.17999999999995, 2 },
                    { 284, 8, 5, 5, 1725355865.9595156, "Description for product 284", false, 0.0, 89, "Product 284", "product284.jpg", 837.40999999999997, 13 },
                    { 285, 21, 6, 6, 1725355865.9595163, "Description for product 285", false, 0.0, 180, "Product 285", "product285.jpg", 311.14999999999998, 17 },
                    { 286, 69, 7, 7, 1725355865.9595168, "Description for product 286", false, 0.0, 173, "Product 286", "product286.jpg", 491.83999999999997, 3 },
                    { 287, 4, 8, 8, 1725355865.9595177, "Description for product 287", false, 0.0, 131, "Product 287", "product287.jpg", 347.92000000000002, 5 },
                    { 288, 93, 9, 9, 1725355865.9595208, "Description for product 288", false, 0.0, 128, "Product 288", "product288.jpg", 886.72000000000003, 18 },
                    { 289, 87, 10, 10, 1725355865.9595215, "Description for product 289", false, 0.0, 73, "Product 289", "product289.jpg", 289.97000000000003, 12 },
                    { 290, 68, 11, 11, 1725355865.959522, "Description for product 290", false, 0.0, 95, "Product 290", "product290.jpg", 44.039999999999999, 7 },
                    { 291, 44, 12, 12, 1725355865.9595227, "Description for product 291", false, 0.0, 141, "Product 291", "product291.jpg", 315.67000000000002, 16 },
                    { 292, 94, 13, 13, 1725355865.9595234, "Description for product 292", false, 0.0, 95, "Product 292", "product292.jpg", 270.26999999999998, 10 },
                    { 293, 50, 14, 14, 1725355865.9595239, "Description for product 293", false, 0.0, 75, "Product 293", "product293.jpg", 698.32000000000005, 19 },
                    { 294, 21, 15, 15, 1725355865.9595249, "Description for product 294", false, 0.0, 111, "Product 294", "product294.jpg", 5.0800000000000001, 13 },
                    { 295, 31, 16, 16, 1725355865.9595251, "Description for product 295", false, 0.0, 87, "Product 295", "product295.jpg", 427.19, 3 },
                    { 296, 95, 17, 17, 1725355865.9595261, "Description for product 296", false, 0.0, 156, "Product 296", "product296.jpg", 130.55000000000001, 18 },
                    { 297, 40, 18, 18, 1725355865.9595263, "Description for product 297", false, 0.0, 181, "Product 297", "product297.jpg", 292.32999999999998, 1 },
                    { 298, 80, 19, 19, 1725355865.9595273, "Description for product 298", false, 0.0, 64, "Product 298", "product298.jpg", 747.42999999999995, 16 },
                    { 299, 70, 20, 20, 1725355865.9595275, "Description for product 299", false, 0.0, 42, "Product 299", "product299.jpg", 381.23000000000002, 19 },
                    { 300, 68, 21, 1, 1725355865.9595284, "Description for product 300", false, 0.0, 122, "Product 300", "product300.jpg", 606.10000000000002, 10 },
                    { 301, 23, 22, 2, 1725355865.9595289, "Description for product 301", false, 0.0, 188, "Product 301", "product301.jpg", 616.65999999999997, 11 },
                    { 302, 22, 23, 3, 1725355865.9595315, "Description for product 302", false, 0.0, 171, "Product 302", "product302.jpg", 113.22, 1 },
                    { 303, 2, 24, 4, 1725355865.959532, "Description for product 303", false, 0.0, 41, "Product 303", "product303.jpg", 569.71000000000004, 6 },
                    { 304, 51, 25, 5, 1725355865.9595327, "Description for product 304", false, 0.0, 95, "Product 304", "product304.jpg", 123.65000000000001, 9 },
                    { 305, 57, 26, 6, 1725355865.9595335, "Description for product 305", false, 0.0, 195, "Product 305", "product305.jpg", 679.79999999999995, 11 },
                    { 306, 56, 27, 7, 1725355865.9595339, "Description for product 306", false, 0.0, 98, "Product 306", "product306.jpg", 390.25, 9 },
                    { 307, 10, 28, 8, 1725355865.9595349, "Description for product 307", false, 0.0, 102, "Product 307", "product307.jpg", 776.38999999999999, 5 },
                    { 308, 60, 29, 9, 1725355865.9595351, "Description for product 308", false, 0.0, 120, "Product 308", "product308.jpg", 123.15000000000001, 9 },
                    { 309, 44, 30, 10, 1725355865.9595361, "Description for product 309", false, 0.0, 24, "Product 309", "product309.jpg", 325.66000000000003, 11 },
                    { 310, 36, 31, 11, 1725355865.9595366, "Description for product 310", false, 0.0, 123, "Product 310", "product310.jpg", 421.07999999999998, 16 },
                    { 311, 38, 32, 12, 1725355865.9595373, "Description for product 311", false, 0.0, 57, "Product 311", "product311.jpg", 399.52999999999997, 14 },
                    { 312, 60, 33, 13, 1725355865.9595377, "Description for product 312", false, 0.0, 125, "Product 312", "product312.jpg", 317.76999999999998, 14 },
                    { 313, 58, 34, 14, 1725355865.9595385, "Description for product 313", false, 0.0, 155, "Product 313", "product313.jpg", 280.61000000000001, 4 },
                    { 314, 55, 35, 15, 1725355865.9595392, "Description for product 314", false, 0.0, 145, "Product 314", "product314.jpg", 962.23000000000002, 2 },
                    { 315, 67, 36, 16, 1725355865.9595397, "Description for product 315", false, 0.0, 63, "Product 315", "product315.jpg", 838.66999999999996, 15 },
                    { 316, 59, 37, 17, 1725355865.9595423, "Description for product 316", false, 0.0, 53, "Product 316", "product316.jpg", 304.22000000000003, 16 },
                    { 317, 88, 38, 18, 1725355865.9595428, "Description for product 317", false, 0.0, 42, "Product 317", "product317.jpg", 866.27999999999997, 11 },
                    { 318, 27, 39, 19, 1725355865.9595437, "Description for product 318", false, 0.0, 130, "Product 318", "product318.jpg", 264.45999999999998, 19 },
                    { 319, 80, 40, 20, 1725355865.9595439, "Description for product 319", false, 0.0, 165, "Product 319", "product319.jpg", 103.33, 18 },
                    { 320, 98, 1, 1, 1725355865.9595449, "Description for product 320", false, 0.0, 174, "Product 320", "product320.jpg", 677.04999999999995, 3 },
                    { 321, 81, 2, 2, 1725355865.9595454, "Description for product 321", false, 0.0, 112, "Product 321", "product321.jpg", 902.25, 9 },
                    { 322, 3, 3, 3, 1725355865.9595461, "Description for product 322", false, 0.0, 53, "Product 322", "product322.jpg", 54.659999999999997, 18 },
                    { 323, 62, 4, 4, 1725355865.9595468, "Description for product 323", false, 0.0, 50, "Product 323", "product323.jpg", 387.57999999999998, 6 },
                    { 324, 71, 5, 5, 1725355865.9595473, "Description for product 324", false, 0.0, 75, "Product 324", "product324.jpg", 610.03999999999996, 5 },
                    { 325, 72, 6, 6, 1725355865.959548, "Description for product 325", false, 0.0, 114, "Product 325", "product325.jpg", 473.48000000000002, 3 },
                    { 326, 58, 7, 7, 1725355865.9595487, "Description for product 326", false, 0.0, 91, "Product 326", "product326.jpg", 812.30999999999995, 14 },
                    { 327, 4, 8, 8, 1725355865.9595494, "Description for product 327", false, 0.0, 83, "Product 327", "product327.jpg", 942.13999999999999, 17 },
                    { 328, 20, 9, 9, 1725355865.9595499, "Description for product 328", false, 0.0, 186, "Product 328", "product328.jpg", 502.89999999999998, 2 },
                    { 329, 97, 10, 10, 1725355865.9595509, "Description for product 329", false, 0.0, 134, "Product 329", "product329.jpg", 15.32, 5 },
                    { 330, 51, 11, 11, 1725355865.9595532, "Description for product 330", false, 0.0, 182, "Product 330", "product330.jpg", 809.39999999999998, 8 },
                    { 331, 94, 12, 12, 1725355865.959554, "Description for product 331", false, 0.0, 157, "Product 331", "product331.jpg", 762.29999999999995, 9 },
                    { 332, 96, 13, 13, 1725355865.9595544, "Description for product 332", false, 0.0, 80, "Product 332", "product332.jpg", 934.65999999999997, 18 },
                    { 333, 5, 14, 14, 1725355865.9595551, "Description for product 333", false, 0.0, 150, "Product 333", "product333.jpg", 448.30000000000001, 17 },
                    { 334, 4, 15, 15, 1725355865.9595556, "Description for product 334", false, 0.0, 88, "Product 334", "product334.jpg", 285.12, 15 },
                    { 335, 19, 16, 16, 1725355865.9595563, "Description for product 335", false, 0.0, 29, "Product 335", "product335.jpg", 433.48000000000002, 6 },
                    { 336, 99, 17, 17, 1725355865.9595571, "Description for product 336", false, 0.0, 90, "Product 336", "product336.jpg", 638.25, 14 },
                    { 337, 68, 18, 18, 1725355865.9595575, "Description for product 337", false, 0.0, 67, "Product 337", "product337.jpg", 634.80999999999995, 5 },
                    { 338, 66, 19, 19, 1725355865.9595585, "Description for product 338", false, 0.0, 151, "Product 338", "product338.jpg", 176.46000000000001, 10 },
                    { 339, 67, 20, 20, 1725355865.9595587, "Description for product 339", false, 0.0, 35, "Product 339", "product339.jpg", 811.62, 2 },
                    { 340, 81, 21, 1, 1725355865.9595597, "Description for product 340", false, 0.0, 54, "Product 340", "product340.jpg", 845.77999999999997, 3 },
                    { 341, 99, 22, 2, 1725355865.9595599, "Description for product 341", false, 0.0, 130, "Product 341", "product341.jpg", 902.70000000000005, 2 },
                    { 342, 27, 23, 3, 1725355865.9595609, "Description for product 342", false, 0.0, 30, "Product 342", "product342.jpg", 734.63999999999999, 13 },
                    { 343, 26, 24, 4, 1725355865.9595613, "Description for product 343", false, 0.0, 191, "Product 343", "product343.jpg", 885.12, 6 },
                    { 344, 28, 25, 5, 1725355865.959564, "Description for product 344", false, 0.0, 146, "Product 344", "product344.jpg", 13.720000000000001, 14 },
                    { 345, 98, 26, 6, 1725355865.9595647, "Description for product 345", false, 0.0, 198, "Product 345", "product345.jpg", 35.649999999999999, 14 },
                    { 346, 11, 27, 7, 1725355865.9595652, "Description for product 346", false, 0.0, 193, "Product 346", "product346.jpg", 463.57999999999998, 18 },
                    { 347, 17, 28, 8, 1725355865.9595661, "Description for product 347", false, 0.0, 149, "Product 347", "product347.jpg", 433.04000000000002, 11 },
                    { 348, 93, 29, 9, 1725355865.9595664, "Description for product 348", false, 0.0, 104, "Product 348", "product348.jpg", 515.88, 13 },
                    { 349, 52, 30, 10, 1725355865.9595673, "Description for product 349", false, 0.0, 31, "Product 349", "product349.jpg", 523.77999999999997, 2 },
                    { 350, 34, 31, 11, 1725355865.9595678, "Description for product 350", false, 0.0, 91, "Product 350", "product350.jpg", 268.94999999999999, 5 },
                    { 351, 30, 32, 12, 1725355865.9595685, "Description for product 351", false, 0.0, 94, "Product 351", "product351.jpg", 628.38, 6 },
                    { 352, 74, 33, 13, 1725355865.959569, "Description for product 352", false, 0.0, 75, "Product 352", "product352.jpg", 180.66999999999999, 5 },
                    { 353, 10, 34, 14, 1725355865.9595697, "Description for product 353", false, 0.0, 135, "Product 353", "product353.jpg", 363.06999999999999, 12 },
                    { 354, 99, 35, 15, 1725355865.9595702, "Description for product 354", false, 0.0, 126, "Product 354", "product354.jpg", 451.91000000000003, 13 },
                    { 355, 73, 36, 16, 1725355865.9595709, "Description for product 355", false, 0.0, 91, "Product 355", "product355.jpg", 299.69999999999999, 3 },
                    { 356, 42, 37, 17, 1725355865.9595714, "Description for product 356", false, 0.0, 93, "Product 356", "product356.jpg", 244.93000000000001, 7 },
                    { 357, 63, 38, 18, 1725355865.9595721, "Description for product 357", false, 0.0, 60, "Product 357", "product357.jpg", 673.95000000000005, 7 },
                    { 358, 33, 39, 19, 1725355865.9595747, "Description for product 358", false, 0.0, 150, "Product 358", "product358.jpg", 512.76999999999998, 5 },
                    { 359, 26, 40, 20, 1725355865.9595754, "Description for product 359", false, 0.0, 112, "Product 359", "product359.jpg", 568.64999999999998, 10 },
                    { 360, 70, 1, 1, 1725355865.9595759, "Description for product 360", false, 0.0, 81, "Product 360", "product360.jpg", 414.29000000000002, 7 },
                    { 361, 37, 2, 2, 1725355865.9595768, "Description for product 361", false, 0.0, 179, "Product 361", "product361.jpg", 819.27999999999997, 18 },
                    { 362, 61, 3, 3, 1725355865.9595773, "Description for product 362", false, 0.0, 154, "Product 362", "product362.jpg", 931.88, 13 },
                    { 363, 28, 4, 4, 1725355865.959578, "Description for product 363", false, 0.0, 194, "Product 363", "product363.jpg", 680.5, 7 },
                    { 364, 50, 5, 5, 1725355865.9595788, "Description for product 364", false, 0.0, 113, "Product 364", "product364.jpg", 706.51999999999998, 10 },
                    { 365, 58, 6, 6, 1725355865.9595792, "Description for product 365", false, 0.0, 78, "Product 365", "product365.jpg", 41.270000000000003, 7 },
                    { 366, 31, 7, 7, 1725355865.9595799, "Description for product 366", false, 0.0, 163, "Product 366", "product366.jpg", 311.81999999999999, 13 },
                    { 367, 64, 8, 8, 1725355865.9595809, "Description for product 367", false, 0.0, 173, "Product 367", "product367.jpg", 71.790000000000006, 3 },
                    { 368, 55, 9, 9, 1725355865.9595814, "Description for product 368", false, 0.0, 178, "Product 368", "product368.jpg", 727.85000000000002, 4 },
                    { 369, 10, 10, 10, 1725355865.9595821, "Description for product 369", false, 0.0, 22, "Product 369", "product369.jpg", 4.3300000000000001, 2 },
                    { 370, 53, 11, 11, 1725355865.9595828, "Description for product 370", false, 0.0, 70, "Product 370", "product370.jpg", 426.69, 11 },
                    { 371, 89, 12, 12, 1725355865.9595833, "Description for product 371", false, 0.0, 54, "Product 371", "product371.jpg", 516.90999999999997, 15 },
                    { 372, 12, 13, 13, 1725355865.9595857, "Description for product 372", false, 0.0, 143, "Product 372", "product372.jpg", 920.63999999999999, 10 },
                    { 373, 37, 14, 14, 1725355865.9595861, "Description for product 373", false, 0.0, 159, "Product 373", "product373.jpg", 164.05000000000001, 3 },
                    { 374, 63, 15, 15, 1725355865.9595869, "Description for product 374", false, 0.0, 94, "Product 374", "product374.jpg", 322.93000000000001, 17 },
                    { 375, 95, 16, 16, 1725355865.9595876, "Description for product 375", false, 0.0, 102, "Product 375", "product375.jpg", 584.49000000000001, 4 },
                    { 376, 91, 17, 17, 1725355865.9595883, "Description for product 376", false, 0.0, 117, "Product 376", "product376.jpg", 177.56, 16 },
                    { 377, 9, 18, 18, 1725355865.9595888, "Description for product 377", false, 0.0, 153, "Product 377", "product377.jpg", 678.08000000000004, 2 },
                    { 378, 79, 19, 19, 1725355865.9595895, "Description for product 378", false, 0.0, 116, "Product 378", "product378.jpg", 852.0, 7 },
                    { 379, 98, 20, 20, 1725355865.95959, "Description for product 379", false, 0.0, 120, "Product 379", "product379.jpg", 388.26999999999998, 2 },
                    { 380, 79, 21, 1, 1725355865.9595909, "Description for product 380", false, 0.0, 96, "Product 380", "product380.jpg", 70.090000000000003, 14 },
                    { 381, 75, 22, 2, 1725355865.9595912, "Description for product 381", false, 0.0, 83, "Product 381", "product381.jpg", 580.16999999999996, 10 },
                    { 382, 17, 23, 3, 1725355865.9595921, "Description for product 382", false, 0.0, 69, "Product 382", "product382.jpg", 899.26999999999998, 18 },
                    { 383, 67, 24, 4, 1725355865.9595926, "Description for product 383", false, 0.0, 120, "Product 383", "product383.jpg", 277.79000000000002, 10 },
                    { 384, 31, 25, 5, 1725355865.9595933, "Description for product 384", false, 0.0, 114, "Product 384", "product384.jpg", 915.44000000000005, 19 },
                    { 385, 22, 26, 6, 1725355865.9595938, "Description for product 385", false, 0.0, 88, "Product 385", "product385.jpg", 517.09000000000003, 12 },
                    { 386, 6, 27, 7, 1725355865.9595993, "Description for product 386", false, 0.0, 98, "Product 386", "product386.jpg", 485.44, 16 },
                    { 387, 27, 28, 8, 1725355865.9595997, "Description for product 387", false, 0.0, 63, "Product 387", "product387.jpg", 403.93000000000001, 8 },
                    { 388, 11, 29, 9, 1725355865.9596004, "Description for product 388", false, 0.0, 28, "Product 388", "product388.jpg", 108.73, 12 },
                    { 389, 89, 30, 10, 1725355865.9596012, "Description for product 389", false, 0.0, 35, "Product 389", "product389.jpg", 150.78999999999999, 19 },
                    { 390, 20, 31, 11, 1725355865.9596016, "Description for product 390", false, 0.0, 91, "Product 390", "product390.jpg", 283.82999999999998, 4 },
                    { 391, 1, 32, 12, 1725355865.9596024, "Description for product 391", false, 0.0, 155, "Product 391", "product391.jpg", 120.97, 15 },
                    { 392, 69, 33, 13, 1725355865.9596031, "Description for product 392", false, 0.0, 25, "Product 392", "product392.jpg", 943.57000000000005, 13 },
                    { 393, 41, 34, 14, 1725355865.9596035, "Description for product 393", false, 0.0, 195, "Product 393", "product393.jpg", 714.83000000000004, 15 },
                    { 394, 65, 35, 15, 1725355865.9596043, "Description for product 394", false, 0.0, 80, "Product 394", "product394.jpg", 732.97000000000003, 11 },
                    { 395, 90, 36, 16, 1725355865.9596047, "Description for product 395", false, 0.0, 69, "Product 395", "product395.jpg", 869.01999999999998, 16 },
                    { 396, 80, 37, 17, 1725355865.9596055, "Description for product 396", false, 0.0, 72, "Product 396", "product396.jpg", 875.25, 14 },
                    { 397, 46, 38, 18, 1725355865.9596059, "Description for product 397", false, 0.0, 85, "Product 397", "product397.jpg", 207.78, 3 },
                    { 398, 54, 39, 19, 1725355865.9596066, "Description for product 398", false, 0.0, 54, "Product 398", "product398.jpg", 572.55999999999995, 6 },
                    { 399, 8, 40, 20, 1725355865.9596071, "Description for product 399", false, 0.0, 114, "Product 399", "product399.jpg", 270.82999999999998, 13 },
                    { 400, 34, 1, 1, 1725355865.9596105, "Description for product 400", false, 0.0, 58, "Product 400", "product400.jpg", 615.61000000000001, 14 }
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
