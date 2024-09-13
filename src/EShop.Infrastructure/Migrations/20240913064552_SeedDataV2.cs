using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "b887ba33-21fd-4429-8380-34bbb9b7dcc1", "Administrator", "ADMINISTRATOR" },
                    { 2, "752caffa-53bf-484e-9709-3ab7eeae298a", "Customer", "CUSTOMER" },
                    { 3, "e09471d0-2db3-4a30-8b45-af53f7d0a6e1", "SalesManager", "SALESMANAGER" },
                    { 4, "90dc4ebb-fe55-4f9e-9760-f72ddeb3b57d", "StoreManager", "STOREMANAGER" },
                    { 5, "097495ca-9bdc-446b-a01d-4a09a408d7b8", "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AvatarUrl", "Code", "Created", "Description", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "", "APPLE", 1726209952.4393604, "", false, 0.0, "Apple" },
                    { 2, "", "SAMSUNG", 1726209952.4393609, "", false, 0.0, "Samsung" },
                    { 3, "", "MICROSOFT", 1726209952.4393611, "", false, 0.0, "Microsoft" },
                    { 4, "", "GOOGLE", 1726209952.4393611, "", false, 0.0, "Google" },
                    { 5, "", "AMAZON", 1726209952.4393611, "", false, 0.0, "Amazon" },
                    { 6, "", "FACEBOOK", 1726209952.4393611, "", false, 0.0, "Facebook" },
                    { 7, "", "INTEL", 1726209952.4393613, "", false, 0.0, "Intel" },
                    { 8, "", "IBM", 1726209952.4393616, "", false, 0.0, "IBM" },
                    { 9, "", "SONY", 1726209952.4393616, "", false, 0.0, "Sony" },
                    { 10, "", "DELL", 1726209952.4393618, "", false, 0.0, "Dell" },
                    { 11, "", "HP", 1726209952.439362, "", false, 0.0, "HP" },
                    { 12, "", "LG", 1726209952.439362, "", false, 0.0, "LG" },
                    { 13, "", "HUAWEI", 1726209952.439362, "", false, 0.0, "Huawei" },
                    { 14, "", "CISCO", 1726209952.4393623, "", false, 0.0, "Cisco" },
                    { 15, "", "ORACLE", 1726209952.4393623, "", false, 0.0, "Oracle" },
                    { 16, "", "NVIDIA", 1726209952.4393623, "", false, 0.0, "Nvidia" },
                    { 17, "", "AMD", 1726209952.4393623, "", false, 0.0, "AMD" },
                    { 18, "", "LENOVO", 1726209952.4393625, "", false, 0.0, "Lenovo" },
                    { 19, "", "ASUS", 1726209952.4393628, "", false, 0.0, "Asus" },
                    { 20, "", "ACER", 1726209952.4393628, "", false, 0.0, "Acer" },
                    { 21, "", "NIKE", 1726209952.4393628, "", false, 0.0, "Nike" },
                    { 22, "", "ADIDAS", 1726209952.439363, "", false, 0.0, "Adidas" },
                    { 23, "", "PUMA", 1726209952.4393632, "", false, 0.0, "Puma" },
                    { 24, "", "UA", 1726209952.4393632, "", false, 0.0, "Under Armour" },
                    { 25, "", "REEBOK", 1726209952.4393632, "", false, 0.0, "Reebok" },
                    { 26, "", "NB", 1726209952.4393635, "", false, 0.0, "New Balance" },
                    { 27, "", "ASICS", 1726209952.4393637, "", false, 0.0, "Asics" },
                    { 28, "", "CONV", 1726209952.4393637, "", false, 0.0, "Converse" },
                    { 29, "", "VANS", 1726209952.4393637, "", false, 0.0, "Vans" },
                    { 30, "", "SKETCH", 1726209952.4393637, "", false, 0.0, "Sketchers" },
                    { 31, "", "FILA", 1726209952.439364, "", false, 0.0, "Fila" },
                    { 32, "", "HM", 1726209952.439364, "", false, 0.0, "H&M" },
                    { 33, "", "ZARA", 1726209952.439364, "", false, 0.0, "Zara" },
                    { 34, "", "UNIQLO", 1726209952.4393642, "", false, 0.0, "Uniqlo" },
                    { 35, "", "GUCCI", 1726209952.4393644, "", false, 0.0, "Gucci" },
                    { 36, "", "LV", 1726209952.4393644, "", false, 0.0, "Louis Vuitton" },
                    { 37, "", "PRADA", 1726209952.4393644, "", false, 0.0, "Prada" },
                    { 38, "", "CHANEL", 1726209952.4393647, "", false, 0.0, "Chanel" },
                    { 39, "", "HERMES", 1726209952.4393649, "", false, 0.0, "Hermès" },
                    { 40, "", "BURBERRY", 1726209952.4393649, "", false, 0.0, "Burberry" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "Description", "IsDeleted", "LastModified", "Name", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "BEADING & JEWELRY MAKING", 1726209952.4333029, "Description for category Beading & Jewelry Making", false, 0.0, "Beading & Jewelry Making", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 2, "FABRIC DECORATING", 1726209952.4333313, "Description for category Fabric Decorating", false, 0.0, "Fabric Decorating", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 3, "KNITTING & CROCHET SUPPLIES", 1726209952.4333584, "Description for category Knitting & Crochet Supplies", false, 0.0, "Knitting & Crochet Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 4, "PRINTMAKING SUPPLIES", 1726209952.4333861, "Description for category Printmaking Supplies", false, 0.0, "Printmaking Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 5, "SCRAPBOOKING & STAMPING SUPPLIES", 1726209952.4334135, "Description for category Scrapbooking & Stamping Supplies", false, 0.0, "Scrapbooking & Stamping Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 6, "SEWING PRODUCTS", 1726209952.4334359, "Description for category Sewing Products", false, 0.0, "Sewing Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 7, "CRAFT & HOBBY FABRIC", 1726209952.4334605, "Description for category Craft & Hobby Fabric", false, 0.0, "Craft & Hobby Fabric", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 8, "NEEDLEWORK SUPPLIES", 1726209952.4334848, "Description for category Needlework Supplies", false, 0.0, "Needlework Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 9, "ARTS, CRAFTS & SEWING STORAGE", 1726209952.4335072, "Description for category Arts, Crafts & Sewing Storage", false, 0.0, "Arts, Crafts & Sewing Storage", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 10, "PAINTING, DRAWING & ART SUPPLIES", 1726209952.4335299, "Description for category Painting, Drawing & Art Supplies", false, 0.0, "Painting, Drawing & Art Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 11, "CRAFT SUPPLIES & MATERIALS", 1726209952.4335542, "Description for category Craft Supplies & Materials", false, 0.0, "Craft Supplies & Materials", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 12, "GIFT WRAPPING SUPPLIES", 1726209952.4335797, "Description for category Gift Wrapping Supplies", false, 0.0, "Gift Wrapping Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 13, "PARTY DECORATIONS", 1726209952.4336033, "Description for category Party Decorations", false, 0.0, "Party Decorations", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 14, "AUTOMOTIVE PAINT & PAINT SUPPLIES", 1726209952.4336298, "Description for category Automotive Paint & Paint Supplies", false, 0.0, "Automotive Paint & Paint Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 15, "HEAVY DUTY & COMMERCIAL VEHICLE EQUIPMENT", 1726209952.4336526, "Description for category Heavy Duty & Commercial Vehicle Equipment", false, 0.0, "Heavy Duty & Commercial Vehicle Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 16, "AUTOMOTIVE TIRES & WHEELS", 1726209952.4336741, "Description for category Automotive Tires & Wheels", false, 0.0, "Automotive Tires & Wheels", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 17, "AUTOMOTIVE TOOLS & EQUIPMENT", 1726209952.433701, "Description for category Automotive Tools & Equipment", false, 0.0, "Automotive Tools & Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 18, "AUTOMOTIVE PERFORMANCE PARTS & ACCESSORIES", 1726209952.4337232, "Description for category Automotive Performance Parts & Accessories", false, 0.0, "Automotive Performance Parts & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 19, "CAR CARE", 1726209952.4337461, "Description for category Car Care", false, 0.0, "Car Care", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 20, "OILS & FLUIDS", 1726209952.4337699, "Description for category Oils & Fluids", false, 0.0, "Oils & Fluids", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 21, "AUTOMOTIVE REPLACEMENT PARTS", 1726209952.4337921, "Description for category Automotive Replacement Parts", false, 0.0, "Automotive Replacement Parts", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 22, "LIGHTS, BULBS & INDICATORS", 1726209952.4338157, "Description for category Lights, Bulbs & Indicators", false, 0.0, "Lights, Bulbs & Indicators", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 23, "AUTOMOTIVE INTERIOR ACCESSORIES", 1726209952.4338408, "Description for category Automotive Interior Accessories", false, 0.0, "Automotive Interior Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 24, "AUTOMOTIVE EXTERIOR ACCESSORIES", 1726209952.4338679, "Description for category Automotive Exterior Accessories", false, 0.0, "Automotive Exterior Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 25, "AUTOMOTIVE ENTHUSIAST MERCHANDISE", 1726209952.4338915, "Description for category Automotive Enthusiast Merchandise", false, 0.0, "Automotive Enthusiast Merchandise", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 26, "CAR ELECTRONICS & ACCESSORIES", 1726209952.4339163, "Description for category Car Electronics & Accessories", false, 0.0, "Car Electronics & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 27, "RV PARTS & ACCESSORIES", 1726209952.4339387, "Description for category RV Parts & Accessories", false, 0.0, "RV Parts & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 28, "MOTORCYCLE & POWERSPORTS", 1726209952.4339619, "Description for category Motorcycle & Powersports", false, 0.0, "Motorcycle & Powersports", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 29, "BABY DIAPERING PRODUCTS", 1726209952.4339862, "Description for category Baby Diapering Products", false, 0.0, "Baby Diapering Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 30, "BABY & TODDLER FEEDING SUPPLIES", 1726209952.4340107, "Description for category Baby & Toddler Feeding Supplies", false, 0.0, "Baby & Toddler Feeding Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 31, "PREGNANCY & MATERNITY PRODUCTS", 1726209952.4340332, "Description for category Pregnancy & Maternity Products", false, 0.0, "Pregnancy & Maternity Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 32, "CHILD SAFETY CAR SEATS & ACCESSORIES", 1726209952.4340591, "Description for category Child Safety Car Seats & Accessories", false, 0.0, "Child Safety Car Seats & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 33, "BABY SAFETY PRODUCTS", 1726209952.4340832, "Description for category Baby Safety Products", false, 0.0, "Baby Safety Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 34, "TOILET TRAINING PRODUCTS", 1726209952.434108, "Description for category Toilet Training Products", false, 0.0, "Toilet Training Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 35, "BABY CARE PRODUCTS", 1726209952.4341311, "Description for category Baby Care Products", false, 0.0, "Baby Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 36, "BABY TRAVEL GEAR", 1726209952.4341524, "Description for category Baby Travel Gear", false, 0.0, "Baby Travel Gear", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 37, "BABY ACTIVITY & ENTERTAINMENT PRODUCTS", 1726209952.4341755, "Description for category Baby Activity & Entertainment Products", false, 0.0, "Baby Activity & Entertainment Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 38, "BABY GIFTS", 1726209952.4342046, "Description for category Baby Gifts", false, 0.0, "Baby Gifts", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 39, "BABY STATIONERY", 1726209952.4342284, "Description for category Baby Stationery", false, 0.0, "Baby Stationery", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 40, "NURSERY FURNITURE, BEDDING & DÉCOR", 1726209952.4342508, "Description for category Nursery Furniture, Bedding & Décor", false, 0.0, "Nursery Furniture, Bedding & Décor", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 41, "BABY", 1726209952.434274, "Description for category Baby", false, 0.0, "Baby", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 42, "BABY BOYS' CLOTHING & SHOES", 1726209952.4342968, "Description for category Baby Boys' Clothing & Shoes", false, 0.0, "Baby Boys' Clothing & Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 43, "BABY STROLLERS & ACCESSORIES", 1726209952.4343188, "Description for category Baby Strollers & Accessories", false, 0.0, "Baby Strollers & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 44, "BEAUTY & PERSONAL CARE", 1726209952.4343441, "Description for category Beauty & Personal Care", false, 0.0, "Beauty & Personal Care", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 45, "PERFUMES & FRAGRANCES", 1726209952.4343898, "Description for category Perfumes & Fragrances", false, 0.0, "Perfumes & Fragrances", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 46, "HAIR CARE PRODUCTS", 1726209952.4344099, "Description for category Hair Care Products", false, 0.0, "Hair Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 47, "MAKEUP", 1726209952.4344325, "Description for category Makeup", false, 0.0, "Makeup", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 48, "SKIN CARE PRODUCTS", 1726209952.4344535, "Description for category Skin Care Products", false, 0.0, "Skin Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 49, "BEAUTY TOOLS & ACCESSORIES", 1726209952.4344771, "Description for category Beauty Tools & Accessories", false, 0.0, "Beauty Tools & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 50, "FOOT, HAND & NAIL CARE PRODUCTS", 1726209952.4345007, "Description for category Foot, Hand & Nail Care Products", false, 0.0, "Foot, Hand & Nail Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 51, "PERSONAL CARE PRODUCTS", 1726209952.4345214, "Description for category Personal Care Products", false, 0.0, "Personal Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 52, "SHAVING & HAIR REMOVAL PRODUCTS", 1726209952.4345479, "Description for category Shaving & Hair Removal Products", false, 0.0, "Shaving & Hair Removal Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 53, "COMPUTER SERVERS", 1726209952.4345696, "Description for category Computer Servers", false, 0.0, "Computer Servers", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 54, "DATA STORAGE", 1726209952.434592, "Description for category Data Storage", false, 0.0, "Data Storage", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 55, "COMPUTER MONITORS", 1726209952.4346137, "Description for category Computer Monitors", false, 0.0, "Computer Monitors", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 56, "COMPUTERS & TABLETS", 1726209952.434638, "Description for category Computers & Tablets", false, 0.0, "Computers & Tablets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 57, "TABLET REPLACEMENT PARTS", 1726209952.4346609, "Description for category Tablet Replacement Parts", false, 0.0, "Tablet Replacement Parts", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 58, "COMPUTER NETWORKING", 1726209952.4346828, "Description for category Computer Networking", false, 0.0, "Computer Networking", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 59, "COMPUTER COMPONENTS", 1726209952.4347084, "Description for category Computer Components", false, 0.0, "Computer Components", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 60, "TABLET ACCESSORIES", 1726209952.4347303, "Description for category Tablet Accessories", false, 0.0, "Tablet Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 61, "LAPTOP ACCESSORIES", 1726209952.4347517, "Description for category Laptop Accessories", false, 0.0, "Laptop Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 62, "COMPUTER EXTERNAL COMPONENTS", 1726209952.4347804, "Description for category Computer External Components", false, 0.0, "Computer External Components", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 63, "WEARABLE TECHNOLOGY", 1726209952.4348028, "Description for category Wearable Technology", false, 0.0, "Wearable Technology", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 64, "TELEVISIONS & VIDEO PRODUCTS", 1726209952.4348238, "Description for category Televisions & Video Products", false, 0.0, "Televisions & Video Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 65, "GPS & NAVIGATION", 1726209952.4348476, "Description for category GPS & Navigation", false, 0.0, "GPS & Navigation", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 66, "HEADPHONES & EARBUDS", 1726209952.4348724, "Description for category Headphones & Earbuds", false, 0.0, "Headphones & Earbuds", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 67, "OFFICE ELECTRONICS", 1726209952.434896, "Description for category Office Electronics", false, 0.0, "Office Electronics", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 68, "PORTABLE AUDIO & VIDEO", 1726209952.4349177, "Description for category Portable Audio & Video", false, 0.0, "Portable Audio & Video", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 69, "EBOOK READERS & ACCESSORIES", 1726209952.4349425, "Description for category eBook Readers & Accessories", false, 0.0, "eBook Readers & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 70, "CELL PHONES & ACCESSORIES", 1726209952.4349656, "Description for category Cell Phones & Accessories", false, 0.0, "Cell Phones & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 71, "ACCESSORIES & SUPPLIES", 1726209952.4349873, "Description for category Accessories & Supplies", false, 0.0, "Accessories & Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 72, "VIDEO PROJECTORS", 1726209952.435014, "Description for category Video Projectors", false, 0.0, "Video Projectors", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 73, "VEHICLE ELECTRONICS", 1726209952.4350371, "Description for category Vehicle Electronics", false, 0.0, "Vehicle Electronics", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 74, "CAMERA & PHOTO", 1726209952.4350586, "Description for category Camera & Photo", false, 0.0, "Camera & Photo", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 75, "SECURITY & SURVEILLANCE EQUIPMENT", 1726209952.4350815, "Description for category Security & Surveillance Equipment", false, 0.0, "Security & Surveillance Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 76, "COMPUTERS", 1726209952.4351065, "Description for category Computers", false, 0.0, "Computers", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 77, "HOME AUDIO & THEATER PRODUCTS", 1726209952.4351287, "Description for category Home Audio & Theater Products", false, 0.0, "Home Audio & Theater Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 78, "VIDEO GAME CONSOLES & ACCESSORIES", 1726209952.4351499, "Description for category Video Game Consoles & Accessories", false, 0.0, "Video Game Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 79, "BOYS' CLOTHING", 1726209952.4351752, "Description for category Boys' Clothing", false, 0.0, "Boys' Clothing", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 80, "BOYS' ACCESSORIES", 1726209952.4351959, "Description for category Boys' Accessories", false, 0.0, "Boys' Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 81, "BOYS' JEWELRY", 1726209952.435219, "Description for category Boys' Jewelry", false, 0.0, "Boys' Jewelry", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 82, "BOYS' WATCHES", 1726209952.4352407, "Description for category Boys' Watches", false, 0.0, "Boys' Watches", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 83, "BOYS' SHOES", 1726209952.4352651, "Description for category Boys' Shoes", false, 0.0, "Boys' Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 84, "GIRLS' CLOTHING", 1726209952.4352877, "Description for category Girls' Clothing", false, 0.0, "Girls' Clothing", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 85, "GIRLS' ACCESSORIES", 1726209952.435312, "Description for category Girls' Accessories", false, 0.0, "Girls' Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 86, "GIRLS' JEWELRY", 1726209952.4353397, "Description for category Girls' Jewelry", false, 0.0, "Girls' Jewelry", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 87, "GIRLS' WATCHES", 1726209952.4353642, "Description for category Girls' Watches", false, 0.0, "Girls' Watches", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 88, "GIRLS' SHOES", 1726209952.4353907, "Description for category Girls' Shoes", false, 0.0, "Girls' Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 89, "GIRLS' SCHOOL UNIFORMS", 1726209952.435411, "Description for category Girls' School Uniforms", false, 0.0, "Girls' School Uniforms", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 90, "TRAVEL DUFFEL BAGS", 1726209952.4354317, "Description for category Travel Duffel Bags", false, 0.0, "Travel Duffel Bags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 91, "MESSENGER BAGS", 1726209952.4354577, "Description for category Messenger Bags", false, 0.0, "Messenger Bags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 92, "TRAVEL TOTE BAGS", 1726209952.4354792, "Description for category Travel Tote Bags", false, 0.0, "Travel Tote Bags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 93, "GARMENT BAGS", 1726209952.4355018, "Description for category Garment Bags", false, 0.0, "Garment Bags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 94, "LUGGAGE SETS", 1726209952.4355268, "Description for category Luggage Sets", false, 0.0, "Luggage Sets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 95, "SUITCASES", 1726209952.4355516, "Description for category Suitcases", false, 0.0, "Suitcases", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 96, "TRAVEL ACCESSORIES", 1726209952.4355772, "Description for category Travel Accessories", false, 0.0, "Travel Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 97, "RAIN UMBRELLAS", 1726209952.4355991, "Description for category Rain Umbrellas", false, 0.0, "Rain Umbrellas", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 98, "BACKPACKS", 1726209952.4356208, "Description for category Backpacks", false, 0.0, "Backpacks", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 99, "LUGGAGE", 1726209952.4356475, "Description for category Luggage", false, 0.0, "Luggage", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 100, "LAPTOP BAGS", 1726209952.4356694, "Description for category Laptop Bags", false, 0.0, "Laptop Bags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 101, "MEN'S CLOTHING", 1726209952.4356923, "Description for category Men's Clothing", false, 0.0, "Men's Clothing", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 102, "MEN'S ACCESSORIES", 1726209952.4357145, "Description for category Men's Accessories", false, 0.0, "Men's Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 103, "MEN'S WATCHES", 1726209952.4357388, "Description for category Men's Watches", false, 0.0, "Men's Watches", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 104, "MEN'S SHOES", 1726209952.4357619, "Description for category Men's Shoes", false, 0.0, "Men's Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 105, "WOMEN'S CLOTHING", 1726209952.4357841, "Description for category Women's Clothing", false, 0.0, "Women's Clothing", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 106, "WOMEN'S HANDBAGS", 1726209952.4358079, "Description for category Women's Handbags", false, 0.0, "Women's Handbags", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 107, "WOMEN'S ACCESSORIES", 1726209952.4358327, "Description for category Women's Accessories", false, 0.0, "Women's Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 108, "WOMEN'S WATCHES", 1726209952.4358549, "Description for category Women's Watches", false, 0.0, "Women's Watches", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 109, "WOMEN'S SHOES", 1726209952.4358778, "Description for category Women's Shoes", false, 0.0, "Women's Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 110, "WOMEN'S JEWELRY", 1726209952.4358997, "Description for category Women's Jewelry", false, 0.0, "Women's Jewelry", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 111, "KIDS' FURNITURE", 1726209952.4359269, "Description for category Kids' Furniture", false, 0.0, "Kids' Furniture", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 112, "GIFT CARDS", 1726209952.4359505, "Description for category Gift Cards", false, 0.0, "Gift Cards", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 113, "ORAL CARE PRODUCTS", 1726209952.4359725, "Description for category Oral Care Products", false, 0.0, "Oral Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 114, "VISION PRODUCTS", 1726209952.4359939, "Description for category Vision Products", false, 0.0, "Vision Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 115, "WELLNESS & RELAXATION PRODUCTS", 1726209952.4360204, "Description for category Wellness & Relaxation Products", false, 0.0, "Wellness & Relaxation Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 116, "BABY & CHILD CARE PRODUCTS", 1726209952.4360459, "Description for category Baby & Child Care Products", false, 0.0, "Baby & Child Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 117, "HOUSEHOLD SUPPLIES", 1726209952.4360688, "Description for category Household Supplies", false, 0.0, "Household Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 118, "HEALTH CARE PRODUCTS", 1726209952.4360929, "Description for category Health Care Products", false, 0.0, "Health Care Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 119, "DIET & SPORTS NUTRITION", 1726209952.4361155, "Description for category Diet & Sports Nutrition", false, 0.0, "Diet & Sports Nutrition", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 120, "HOME USE MEDICAL SUPPLIES & EQUIPMENT", 1726209952.4361386, "Description for category Home Use Medical Supplies & Equipment", false, 0.0, "Home Use Medical Supplies & Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 121, "SEXUAL WELLNESS PRODUCTS", 1726209952.4361649, "Description for category Sexual Wellness Products", false, 0.0, "Sexual Wellness Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 122, "HEALTH & HOUSEHOLD", 1726209952.4361863, "Description for category Health & Household", false, 0.0, "Health & Household", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 123, "SPORTS NUTRITION PRODUCTS", 1726209952.4362085, "Description for category Sports Nutrition Products", false, 0.0, "Sports Nutrition Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 124, "STATIONERY & GIFT WRAPPING SUPPLIES", 1726209952.4362321, "Description for category Stationery & Gift Wrapping Supplies", false, 0.0, "Stationery & Gift Wrapping Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 125, "COMMERCIAL DOOR PRODUCTS", 1726209952.4362552, "Description for category Commercial Door Products", false, 0.0, "Commercial Door Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 126, "POWER TRANSMISSION PRODUCTS", 1726209952.4362783, "Description for category Power Transmission Products", false, 0.0, "Power Transmission Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 127, "INDUSTRIAL MATERIALS", 1726209952.4363012, "Description for category Industrial Materials", false, 0.0, "Industrial Materials", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 128, "INDUSTRIAL HARDWARE", 1726209952.4363263, "Description for category Industrial Hardware", false, 0.0, "Industrial Hardware", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 129, "ABRASIVE & FINISHING PRODUCTS", 1726209952.4363551, "Description for category Abrasive & Finishing Products", false, 0.0, "Abrasive & Finishing Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 130, "INDUSTRIAL ADHESIVES, SEALANTS & LUBRICANTS", 1726209952.4364033, "Description for category Industrial Adhesives, Sealants & Lubricants", false, 0.0, "Industrial Adhesives, Sealants & Lubricants", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 131, "MATERIAL HANDLING PRODUCTS", 1726209952.4364326, "Description for category Material Handling Products", false, 0.0, "Material Handling Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 132, "TEST, MEASURE & INSPECT", 1726209952.4364607, "Description for category Test, Measure & Inspect", false, 0.0, "Test, Measure & Inspect", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 133, "INDUSTRIAL POWER & HAND TOOLS", 1726209952.4364853, "Description for category Industrial Power & Hand Tools", false, 0.0, "Industrial Power & Hand Tools", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 134, "HYDRAULICS, PNEUMATICS & PLUMBING", 1726209952.4365077, "Description for category Hydraulics, Pneumatics & Plumbing", false, 0.0, "Hydraulics, Pneumatics & Plumbing", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 135, "FILTRATION", 1726209952.4365351, "Description for category Filtration", false, 0.0, "Filtration", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 136, "ELECTRONIC COMPONENTS", 1726209952.4365575, "Description for category Electronic Components", false, 0.0, "Electronic Components", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 137, "LAB & SCIENTIFIC PRODUCTS", 1726209952.4365799, "Description for category Lab & Scientific Products", false, 0.0, "Lab & Scientific Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 138, "JANITORIAL & SANITATION SUPPLIES", 1726209952.4366047, "Description for category Janitorial & Sanitation Supplies", false, 0.0, "Janitorial & Sanitation Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 139, "OCCUPATIONAL HEALTH & SAFETY PRODUCTS", 1726209952.436626, "Description for category Occupational Health & Safety Products", false, 0.0, "Occupational Health & Safety Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 140, "CUTTING TOOLS", 1726209952.4366496, "Description for category Cutting Tools", false, 0.0, "Cutting Tools", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 141, "FASTENERS", 1726209952.4366744, "Description for category Fasteners", false, 0.0, "Fasteners", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 142, "SCIENCE EDUCATION SUPPLIES", 1726209952.4366975, "Description for category Science Education Supplies", false, 0.0, "Science Education Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 143, "FOOD SERVICE EQUIPMENT & SUPPLIES", 1726209952.4367199, "Description for category Food Service Equipment & Supplies", false, 0.0, "Food Service Equipment & Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 144, "ADDITIVE MANUFACTURING PRODUCTS", 1726209952.4367485, "Description for category Additive Manufacturing Products", false, 0.0, "Additive Manufacturing Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 145, "PROFESSIONAL MEDICAL SUPPLIES", 1726209952.4367712, "Description for category Professional Medical Supplies", false, 0.0, "Professional Medical Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 146, "PROFESSIONAL DENTAL SUPPLIES", 1726209952.4367936, "Description for category Professional Dental Supplies", false, 0.0, "Professional Dental Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 147, "PACKAGING & SHIPPING SUPPLIES", 1726209952.4368198, "Description for category Packaging & Shipping Supplies", false, 0.0, "Packaging & Shipping Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 148, "RETAIL STORE FIXTURES & EQUIPMENT", 1726209952.436842, "Description for category Retail Store Fixtures & Equipment", false, 0.0, "Retail Store Fixtures & Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 149, "INDUSTRIAL & SCIENTIFIC", 1726209952.436866, "Description for category Industrial & Scientific", false, 0.0, "Industrial & Scientific", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 150, "BATH PRODUCTS", 1726209952.4368918, "Description for category Bath Products", false, 0.0, "Bath Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 151, "BEDDING", 1726209952.4369142, "Description for category Bedding", false, 0.0, "Bedding", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 152, "HOME DÉCOR PRODUCTS", 1726209952.4369752, "Description for category Home Décor Products", false, 0.0, "Home Décor Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 153, "FURNITURE", 1726209952.4370008, "Description for category Furniture", false, 0.0, "Furniture", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 154, "HOUSEHOLD CLEANING SUPPLIES", 1726209952.4370279, "Description for category Household Cleaning Supplies", false, 0.0, "Household Cleaning Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 155, "SEASONAL DÉCOR", 1726209952.4370503, "Description for category Seasonal Décor", false, 0.0, "Seasonal Décor", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 156, "HOME LIGHTING & CEILING FANS", 1726209952.4370728, "Description for category Home Lighting & Ceiling Fans", false, 0.0, "Home Lighting & Ceiling Fans", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 157, "KITCHEN & DINING", 1726209952.4370964, "Description for category Kitchen & Dining", false, 0.0, "Kitchen & Dining", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 158, "HEATING, COOLING & AIR QUALITY", 1726209952.43712, "Description for category Heating, Cooling & Air Quality", false, 0.0, "Heating, Cooling & Air Quality", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 159, "KIDS' HOME STORE", 1726209952.4371471, "Description for category Kids' Home Store", false, 0.0, "Kids' Home Store", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 160, "HOME STORAGE & ORGANIZATION", 1726209952.4371684, "Description for category Home Storage & Organization", false, 0.0, "Home Storage & Organization", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 161, "WALL ART", 1726209952.4371912, "Description for category Wall Art", false, 0.0, "Wall Art", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 162, "VACUUM CLEANERS & FLOOR CARE", 1726209952.4372113, "Description for category Vacuum Cleaners & Floor Care", false, 0.0, "Vacuum Cleaners & Floor Care", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 163, "IRONING PRODUCTS", 1726209952.4372361, "Description for category Ironing Products", false, 0.0, "Ironing Products", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 164, "PARTY SUPPLIES", 1726209952.4372575, "Description for category Party Supplies", false, 0.0, "Party Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 165, "PET BIRD SUPPLIES", 1726209952.4372773, "Description for category Pet Bird Supplies", false, 0.0, "Pet Bird Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 166, "CAT SUPPLIES", 1726209952.4372993, "Description for category Cat Supplies", false, 0.0, "Cat Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 167, "DOG SUPPLIES", 1726209952.437324, "Description for category Dog Supplies", false, 0.0, "Dog Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 168, "FISH & AQUATIC PETS", 1726209952.4373548, "Description for category Fish & Aquatic Pets", false, 0.0, "Fish & Aquatic Pets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 169, "HORSE SUPPLIES", 1726209952.4373789, "Description for category Horse Supplies", false, 0.0, "Horse Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 170, "REPTILES & AMPHIBIAN SUPPLIES", 1726209952.4374008, "Description for category Reptiles & Amphibian Supplies", false, 0.0, "Reptiles & Amphibian Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 171, "SMALL ANIMAL SUPPLIES", 1726209952.4374266, "Description for category Small Animal Supplies", false, 0.0, "Small Animal Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 172, "SMART HOME: NEW SMART DEVICES", 1726209952.437449, "Description for category Smart Home: New Smart Devices", false, 0.0, "Smart Home: New Smart Devices", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 173, "SMART HOME: VOICE ASSISTANTS AND HUBS", 1726209952.4374745, "Description for category Smart Home: Voice Assistants and Hubs", false, 0.0, "Smart Home: Voice Assistants and Hubs", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 174, "SMART HOME: SMART LOCKS AND ENTRY", 1726209952.4374969, "Description for category Smart Home: Smart Locks and Entry", false, 0.0, "Smart Home: Smart Locks and Entry", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 175, "SMART HOME: HOME ENTERTAINMENT", 1726209952.4375184, "Description for category Smart Home: Home Entertainment", false, 0.0, "Smart Home: Home Entertainment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 176, "SMART HOME: WIFI AND NETWORKING", 1726209952.4375455, "Description for category Smart Home: WiFi and Networking", false, 0.0, "Smart Home: WiFi and Networking", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 177, "SMART HOME: SECURITY CAMERAS AND SYSTEMS", 1726209952.4375677, "Description for category Smart Home: Security Cameras and Systems", false, 0.0, "Smart Home: Security Cameras and Systems", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 178, "SMART HOME: LIGHTING", 1726209952.4375908, "Description for category Smart Home: Lighting", false, 0.0, "Smart Home: Lighting", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 179, "SMART HOME: PLUGS AND OUTLETS", 1726209952.4376159, "Description for category Smart Home: Plugs and Outlets", false, 0.0, "Smart Home: Plugs and Outlets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 180, "SMART HOME: VACUUMS AND MOPS", 1726209952.4376383, "Description for category Smart Home: Vacuums and Mops", false, 0.0, "Smart Home: Vacuums and Mops", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 181, "SMART HOME THERMOSTATS - COMPATIBILITY CHECKER", 1726209952.4376645, "Description for category Smart Home Thermostats - Compatibility Checker", false, 0.0, "Smart Home Thermostats - Compatibility Checker", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 182, "SMART HOME: LAWN AND GARDEN", 1726209952.4376869, "Description for category Smart Home: Lawn and Garden", false, 0.0, "Smart Home: Lawn and Garden", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 183, "SMART HOME: OTHER SOLUTIONS", 1726209952.4377131, "Description for category Smart Home: Other Solutions", false, 0.0, "Smart Home: Other Solutions", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 184, "SMART HOME - HEATING & COOLING", 1726209952.437737, "Description for category Smart Home - Heating & Cooling", false, 0.0, "Smart Home - Heating & Cooling", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 185, "SPORTS & FITNESS", 1726209952.4377587, "Description for category Sports & Fitness", false, 0.0, "Sports & Fitness", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 186, "OUTDOOR RECREATION", 1726209952.4377832, "Description for category Outdoor Recreation", false, 0.0, "Outdoor Recreation", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 187, "SPORTS & OUTDOORS", 1726209952.4378071, "Description for category Sports & Outdoors", false, 0.0, "Sports & Outdoors", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 188, "HOME APPLIANCES", 1726209952.4378293, "Description for category Home Appliances", false, 0.0, "Home Appliances", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 189, "PUMPS & PLUMBING EQUIPMENT", 1726209952.4378519, "Description for category Pumps & Plumbing Equipment", false, 0.0, "Pumps & Plumbing Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 190, "PAINT, WALL TREATMENTS & SUPPLIES", 1726209952.4378772, "Description for category Paint, Wall Treatments & Supplies", false, 0.0, "Paint, Wall Treatments & Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 191, "SAFETY & SECURITY", 1726209952.4379001, "Description for category Safety & Security", false, 0.0, "Safety & Security", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 192, "LIGHT BULBS", 1726209952.4379232, "Description for category Light Bulbs", false, 0.0, "Light Bulbs", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 193, "POWER TOOLS & HAND TOOLS", 1726209952.4379485, "Description for category Power Tools & Hand Tools", false, 0.0, "Power Tools & Hand Tools", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 194, "KITCHEN & BATH FIXTURES", 1726209952.4379716, "Description for category Kitchen & Bath Fixtures", false, 0.0, "Kitchen & Bath Fixtures", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 195, "LIGHTING & CEILING FANS", 1726209952.4379935, "Description for category Lighting & Ceiling Fans", false, 0.0, "Lighting & Ceiling Fans", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 196, "ELECTRICAL EQUIPMENT", 1726209952.4380178, "Description for category Electrical Equipment", false, 0.0, "Electrical Equipment", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 197, "HARDWARE", 1726209952.4380412, "Description for category Hardware", false, 0.0, "Hardware", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 198, "BUILDING SUPPLIES", 1726209952.4380624, "Description for category Building Supplies", false, 0.0, "Building Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 199, "MEASURING & LAYOUT", 1726209952.4380844, "Description for category Measuring & Layout", false, 0.0, "Measuring & Layout", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 200, "WELDING & SOLDERING", 1726209952.4381075, "Description for category Welding & Soldering", false, 0.0, "Welding & Soldering", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 201, "TOOLS & HOME IMPROVEMENT", 1726209952.4381287, "Description for category Tools & Home Improvement", false, 0.0, "Tools & Home Improvement", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 202, "KIDS' PARTY SUPPLIES", 1726209952.4381523, "Description for category Kids' Party Supplies", false, 0.0, "Kids' Party Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 203, "TOY FIGURES & PLAYSETS", 1726209952.4381735, "Description for category Toy Figures & Playsets", false, 0.0, "Toy Figures & Playsets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 204, "NOVELTY TOYS & AMUSEMENTS", 1726209952.4381976, "Description for category Novelty Toys & Amusements", false, 0.0, "Novelty Toys & Amusements", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 205, "ARTS & CRAFTS SUPPLIES", 1726209952.4382195, "Description for category Arts & Crafts Supplies", false, 0.0, "Arts & Crafts Supplies", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 206, "BUILDING TOYS", 1726209952.4382412, "Description for category Building Toys", false, 0.0, "Building Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 207, "DOLLS & ACCESSORIES", 1726209952.4382677, "Description for category Dolls & Accessories", false, 0.0, "Dolls & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 208, "KIDS' ELECTRONICS", 1726209952.4382892, "Description for category Kids' Electronics", false, 0.0, "Kids' Electronics", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 209, "GAMES & ACCESSORIES", 1726209952.4383132, "Description for category Games & Accessories", false, 0.0, "Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 210, "LEARNING & EDUCATION TOYS", 1726209952.4383421, "Description for category Learning & Education Toys", false, 0.0, "Learning & Education Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 211, "KIDS' DRESS UP & PRETEND PLAY", 1726209952.4383667, "Description for category Kids' Dress Up & Pretend Play", false, 0.0, "Kids' Dress Up & Pretend Play", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 212, "PUPPETS & PUPPET THEATERS", 1726209952.4383941, "Description for category Puppets & Puppet Theaters", false, 0.0, "Puppets & Puppet Theaters", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 213, "PUZZLES", 1726209952.4384165, "Description for category Puzzles", false, 0.0, "Puzzles", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 214, "SPORTS & OUTDOOR PLAY TOYS", 1726209952.4384396, "Description for category Sports & Outdoor Play Toys", false, 0.0, "Sports & Outdoor Play Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 215, "STUFFED ANIMALS & PLUSH TOYS", 1726209952.4384615, "Description for category Stuffed Animals & Plush Toys", false, 0.0, "Stuffed Animals & Plush Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 216, "BABY & TODDLER TOYS", 1726209952.4384863, "Description for category Baby & Toddler Toys", false, 0.0, "Baby & Toddler Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 217, "TRICYCLES, SCOOTERS & WAGONS", 1726209952.4385099, "Description for category Tricycles, Scooters & Wagons", false, 0.0, "Tricycles, Scooters & Wagons", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 218, "FINGER TOYS", 1726209952.4385321, "Description for category Finger Toys", false, 0.0, "Finger Toys", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 219, "TOY VEHICLE PLAYSETS", 1726209952.4385576, "Description for category Toy Vehicle Playsets", false, 0.0, "Toy Vehicle Playsets", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 220, "KIDS' PLAY TRAINS & TRAMS", 1726209952.4385796, "Description for category Kids' Play Trains & Trams", false, 0.0, "Kids' Play Trains & Trams", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 221, "KIDS' PLAY TRUCKS", 1726209952.438601, "Description for category Kids' Play Trucks", false, 0.0, "Kids' Play Trucks", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 222, "KIDS' PLAY CARS & RACE CARS", 1726209952.4386258, "Description for category Kids' Play Cars & Race Cars", false, 0.0, "Kids' Play Cars & Race Cars", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 223, "KIDS' PLAY BOATS", 1726209952.438648, "Description for category Kids' Play Boats", false, 0.0, "Kids' Play Boats", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 224, "KIDS' PLAY BUSES", 1726209952.4386709, "Description for category Kids' Play Buses", false, 0.0, "Kids' Play Buses", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 225, "KIDS' PLAY TRACTORS", 1726209952.4386928, "Description for category Kids' Play Tractors", false, 0.0, "Kids' Play Tractors", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 226, "SLOT CARS, RACE TRACKS & ACCESSORIES", 1726209952.4387412, "Description for category Slot Cars, Race Tracks & Accessories", false, 0.0, "Slot Cars, Race Tracks & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 227, "SONY PSP GAMES, CONSOLES & ACCESSORIES", 1726209952.4387643, "Description for category Sony PSP Games, Consoles & Accessories", false, 0.0, "Sony PSP Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 228, "NINTENDO DS GAMES, CONSOLES & ACCESSORIES", 1726209952.4387896, "Description for category Nintendo DS Games, Consoles & Accessories", false, 0.0, "Nintendo DS Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 229, "PLAYSTATION 3 GAMES, CONSOLES & ACCESSORIES", 1726209952.4388127, "Description for category PlayStation 3 Games, Consoles & Accessories", false, 0.0, "PlayStation 3 Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 230, "WII GAMES, CONSOLES & ACCESSORIES", 1726209952.4388368, "Description for category Wii Games, Consoles & Accessories", false, 0.0, "Wii Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 231, "XBOX 360 GAMES, CONSOLES & ACCESSORIES", 1726209952.4388618, "Description for category Xbox 360 Games, Consoles & Accessories", false, 0.0, "Xbox 360 Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 232, "MAC GAMES & ACCESSORIES", 1726209952.4388838, "Description for category Mac Games & Accessories", false, 0.0, "Mac Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 233, "NINTENDO 3DS & 2DS CONSOLES, GAMES & ACCESSORIES", 1726209952.4389105, "Description for category Nintendo 3DS & 2DS Consoles, Games & Accessories", false, 0.0, "Nintendo 3DS & 2DS Consoles, Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 234, "LEGACY SYSTEMS", 1726209952.4389324, "Description for category Legacy Systems", false, 0.0, "Legacy Systems", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 235, "PLAYSTATION VITA GAMES, CONSOLES & ACCESSORIES", 1726209952.4389565, "Description for category PlayStation Vita Games, Consoles & Accessories", false, 0.0, "PlayStation Vita Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 236, "WII U GAMES, CONSOLES & ACCESSORIES", 1726209952.4389813, "Description for category Wii U Games, Consoles & Accessories", false, 0.0, "Wii U Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 237, "PLAYSTATION 4 GAMES, CONSOLES & ACCESSORIES", 1726209952.4390056, "Description for category PlayStation 4 Games, Consoles & Accessories", false, 0.0, "PlayStation 4 Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 238, "XBOX ONE GAMES, CONSOLES & ACCESSORIES", 1726209952.4390283, "Description for category Xbox One Games, Consoles & Accessories", false, 0.0, "Xbox One Games, Consoles & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 239, "VIDEO GAMES", 1726209952.4390497, "Description for category Video Games", false, 0.0, "Video Games", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 240, "ONLINE VIDEO GAME SERVICES", 1726209952.439074, "Description for category Online Video Game Services", false, 0.0, "Online Video Game Services", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 241, "VIRTUAL REALITY HARDWARE & ACCESSORIES", 1726209952.4390972, "Description for category Virtual Reality Hardware & Accessories", false, 0.0, "Virtual Reality Hardware & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 242, "NINTENDO SWITCH CONSOLES, GAMES & ACCESSORIES", 1726209952.4391196, "Description for category Nintendo Switch Consoles, Games & Accessories", false, 0.0, "Nintendo Switch Consoles, Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 243, "PLAYSTATION 5 CONSOLES, GAMES & ACCESSORIES", 1726209952.4391451, "Description for category PlayStation 5 Consoles, Games & Accessories", false, 0.0, "PlayStation 5 Consoles, Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 244, "XBOX SERIES X & S CONSOLES, GAMES & ACCESSORIES", 1726209952.4391708, "Description for category Xbox Series X & S Consoles, Games & Accessories", false, 0.0, "Xbox Series X & S Consoles, Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 245, "PC GAMES & ACCESSORIES", 1726209952.4391985, "Description for category PC Games & Accessories", false, 0.0, "PC Games & Accessories", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 246, "BABY GIRLS' CLOTHING & SHOES", 1726209952.4392209, "Description for category Baby Girls' Clothing & Shoes", false, 0.0, "Baby Girls' Clothing & Shoes", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 247, "BOYS' SCHOOL UNIFORMS", 1726209952.4392436, "Description for category Boys' School Uniforms", false, 0.0, "Boys' School Uniforms", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" },
                    { 248, "TOYS & GAMES", 1726209952.4392664, "Description for category Toys & Games", false, 0.0, "Toys & Games", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n </svg>" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 248);
        }
    }
}
