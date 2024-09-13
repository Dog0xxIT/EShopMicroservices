using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "b685c015-c51e-4a34-a216-dd7fcdcbbc0a", "Administrator", "ADMINISTRATOR" },
                    { 2, "f96d755b-a4ff-466d-9808-2475048af207", "Customer", "CUSTOMER" },
                    { 3, "29001699-6ce9-4c03-9d09-a2c490cad67e", "SalesManager", "SALESMANAGER" },
                    { 4, "516f3d06-f9e8-41b8-8ae9-77d041386e8c", "StoreManager", "STOREMANAGER" },
                    { 5, "9f43eae8-6f15-4ed9-bb60-8a74a64f9eb0", "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "AvatarUrl", "Code", "Created", "Description", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "", "APPLE", 1725959934.4939983, "", false, 0.0, "Apple" },
                    { 2, "", "SAMSUNG", 1725959934.4939988, "", false, 0.0, "Samsung" },
                    { 3, "", "MICROSOFT", 1725959934.4939992, "", false, 0.0, "Microsoft" },
                    { 4, "", "GOOGLE", 1725959934.4939992, "", false, 0.0, "Google" },
                    { 5, "", "AMAZON", 1725959934.4939992, "", false, 0.0, "Amazon" },
                    { 6, "", "FACEBOOK", 1725959934.4939995, "", false, 0.0, "Facebook" },
                    { 7, "", "INTEL", 1725959934.4939995, "", false, 0.0, "Intel" },
                    { 8, "", "IBM", 1725959934.4939995, "", false, 0.0, "IBM" },
                    { 9, "", "SONY", 1725959934.4939997, "", false, 0.0, "Sony" },
                    { 10, "", "DELL", 1725959934.494, "", false, 0.0, "Dell" },
                    { 11, "", "HP", 1725959934.494, "", false, 0.0, "HP" },
                    { 12, "", "LG", 1725959934.494, "", false, 0.0, "LG" },
                    { 13, "", "HUAWEI", 1725959934.4940002, "", false, 0.0, "Huawei" },
                    { 14, "", "CISCO", 1725959934.4940004, "", false, 0.0, "Cisco" },
                    { 15, "", "ORACLE", 1725959934.4940004, "", false, 0.0, "Oracle" },
                    { 16, "", "NVIDIA", 1725959934.4940004, "", false, 0.0, "Nvidia" },
                    { 17, "", "AMD", 1725959934.4940007, "", false, 0.0, "AMD" },
                    { 18, "", "LENOVO", 1725959934.4940009, "", false, 0.0, "Lenovo" },
                    { 19, "", "ASUS", 1725959934.4940009, "", false, 0.0, "Asus" },
                    { 20, "", "ACER", 1725959934.4940009, "", false, 0.0, "Acer" },
                    { 21, "", "NIKE", 1725959934.4940012, "", false, 0.0, "Nike" },
                    { 22, "", "ADIDAS", 1725959934.4940012, "", false, 0.0, "Adidas" },
                    { 23, "", "PUMA", 1725959934.4940012, "", false, 0.0, "Puma" },
                    { 24, "", "UA", 1725959934.4940014, "", false, 0.0, "Under Armour" },
                    { 25, "", "REEBOK", 1725959934.4940016, "", false, 0.0, "Reebok" },
                    { 26, "", "NB", 1725959934.4940016, "", false, 0.0, "New Balance" },
                    { 27, "", "ASICS", 1725959934.4940016, "", false, 0.0, "Asics" },
                    { 28, "", "CONV", 1725959934.4940021, "", false, 0.0, "Converse" },
                    { 29, "", "VANS", 1725959934.4940021, "", false, 0.0, "Vans" },
                    { 30, "", "SKETCH", 1725959934.4940021, "", false, 0.0, "Sketchers" },
                    { 31, "", "FILA", 1725959934.4940021, "", false, 0.0, "Fila" },
                    { 32, "", "HM", 1725959934.4940023, "", false, 0.0, "H&M" },
                    { 33, "", "ZARA", 1725959934.4940023, "", false, 0.0, "Zara" },
                    { 34, "", "UNIQLO", 1725959934.4940023, "", false, 0.0, "Uniqlo" },
                    { 35, "", "GUCCI", 1725959934.4940026, "", false, 0.0, "Gucci" },
                    { 36, "", "LV", 1725959934.4940028, "", false, 0.0, "Louis Vuitton" },
                    { 37, "", "PRADA", 1725959934.4940028, "", false, 0.0, "Prada" },
                    { 38, "", "CHANEL", 1725959934.4940031, "", false, 0.0, "Chanel" },
                    { 39, "", "HERMES", 1725959934.4940033, "", false, 0.0, "Hermès" },
                    { 40, "", "BURBERRY", 1725959934.4940033, "", false, 0.0, "Burberry" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "Description", "ThumbnailUrl", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "COMP", 1725959934.4939716, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n        </svg>", false, 0.0, "Computers & Office" },
                    { 2, "COLL", 1725959934.4939725, "", "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M16.872 9.687 20 6.56 17.44 4 4 17.44 6.56 20 16.873 9.687Zm0 0-2.56-2.56M6 7v2m0 0v2m0-2H4m2 0h2m7 7v2m0 0v2m0-2h-2m2 0h2M8 4h.01v.01H8V4Zm2 2h.01v.01H10V6Zm2-2h.01v.01H12V4Zm8 8h.01v.01H20V12Zm-2 2h.01v.01H18V14Zm2 2h.01v.01H20V16Z\"></path>\r\n        </svg>", false, 0.0, "Collectibles & Toys" },
                    { 3, "BOOK", 1725959934.4939728, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M5 19V4a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1v13H7a2 2 0 0 0-2 2Zm0 0a2 2 0 0 0 2 2h12M9 3v14m7 0v4\"></path>\r\n        </svg>", false, 0.0, "Books" },
                    { 4, "FASH", 1725959934.4939728, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 10V6a3 3 0 0 1 3-3v0a3 3 0 0 1 3 3v4m3-2 .917 11.923A1 1 0 0 1 17.92 21H6.08a1 1 0 0 1-.997-1.077L6 8h12Z\"></path>\r\n        </svg>", false, 0.0, "Fashion & Clothes" },
                    { 5, "ELEC", 1725959934.493973, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 9a3 3 0 0 1 3-3m-2 15h4m0-3c0-4.1 4-4.9 4-9A6 6 0 1 0 6 9c0 4 4 5 4 9h4Z\"></path>\r\n        </svg>", false, 0.0, "Electronics" },
                    { 6, "FOOD", 1725959934.4939733, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M6 12c.263 0 .524-.06.767-.175a2 2 0 0 0 .65-.491c.186-.21.333-.46.433-.734.1-.274.15-.568.15-.864a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 12 9.736a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 16 9.736c0 .295.052.588.152.861s.248.521.434.73a2 2 0 0 0 .649.488 1.809 1.809 0 0 0 1.53 0 2.03 2.03 0 0 0 .65-.488c.185-.209.332-.457.433-.73.1-.273.152-.566.152-.861 0-.974-1.108-3.85-1.618-5.121A.983.983 0 0 0 17.466 4H6.456a.986.986 0 0 0-.93.645C5.045 5.962 4 8.905 4 9.736c.023.59.241 1.148.611 1.567.37.418.865.667 1.389.697Zm0 0c.328 0 .651-.091.94-.266A2.1 2.1 0 0 0 7.66 11h.681a2.1 2.1 0 0 0 .718.734c.29.175.613.266.942.266.328 0 .651-.091.94-.266.29-.174.537-.427.719-.734h.681a2.1 2.1 0 0 0 .719.734c.289.175.612.266.94.266.329 0 .652-.091.942-.266.29-.174.536-.427.718-.734h.681c.183.307.43.56.719.734.29.174.613.266.941.266a1.819 1.819 0 0 0 1.06-.351M6 12a1.766 1.766 0 0 1-1.163-.476M5 12v7a1 1 0 0 0 1 1h2v-5h3v5h7a1 1 0 0 0 1-1v-7m-5 3v2h2v-2h-2Z\"></path>\r\n        </svg>", false, 0.0, "Food & Groceries" },
                    { 7, "MUSC", 1725959934.4939733, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n       <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 9a3 3 0 0 1 3-3m-2 15h4m0-3c0-4.1 4-4.9 4-9A6 6 0 1 0 6 9c0 4 4 5 4 9h4Z\"></path>\r\n   </svg>", false, 0.0, "Music" },
                    { 8, "TVPJ", 1725959934.4939733, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n    <path stroke=\"currentColor\"\r\n          stroke-linecap=\"round\"\r\n          stroke-linejoin=\"round\"\r\n          stroke-width=\"2\"\r\n          d=\"M6 12c.263 0 .524-.06.767-.175a2 2 0 0 0 .65-.491c.186-.21.333-.46.433-.734.1-.274.15-.568.15-.864a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 12 9.736a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 16 9.736c0 .295.052.588.152.861s.248.521.434.73a2 2 0 0 0 .649.488 1.809 1.809 0 0 0 1.53 0 2.03 2.03 0 0 0 .65-.488c.185-.209.332-.457.433-.73.1-.273.152-.566.152-.861 0-.974-1.108-3.85-1.618-5.121A.983.983 0 0 0 17.466 4H6.456a.986.986 0 0 0-.93.645C5.045 5.962 4 8.905 4 9.736c.023.59.241 1.148.611 1.567.37.418.865.667 1.389.697Zm0 0c.328 0 .651-.091.94-.266A2.1 2.1 0 0 0 7.66 11h.681a2.1 2.1 0 0 0 .718.734c.29.175.613.266.942.266.328 0 .651-.091.94-.266.29-.174.537-.427.719-.734h.681a2.1 2.1 0 0 0 .719.734c.289.175.612.266.94.266.329 0 .652-.091.942-.266.29-.174.536-.427.718-.734h.681c.183.307.43.56.719.734.29.174.613.266.941.266a1.819 1.819 0 0 0 1.06-.351M6 12a1.766 1.766 0 0 1-1.163-.476M5 12v7a1 1 0 0 0 1 1h2v-5h3v5h7a1 1 0 0 0 1-1v-7m-5 3v2h2v-2h-2Z\"></path>\r\n</svg>", false, 0.0, "TVs & Projectors" },
                    { 9, "HEAL", 1725959934.4939735, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 16H5a1 1 0 0 1-1-1V5a1 1 0 0 1 1-1h14a1 1 0 0 1 1 1v1M9 12H4m8 8V9h8v11h-8Zm0 0H9m8-4a1 1 0 1 0-2 0 1 1 0 0 0 2 0Z\"></path>\r\n  </svg>", false, 0.0, "Health & Beauty" },
                    { 10, "HAIR", 1725959934.4939735, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15.041 13.862A4.999 4.999 0 0 1 17 17.831V21M7 3v3.169a5 5 0 0 0 1.891 3.916M17 3v3.169a5 5 0 0 1-2.428 4.288l-5.144 3.086A5 5 0 0 0 7 17.831V21M7 5h10M7.399 8h9.252M8 16h8.652M7 19h10\"></path>\r\n </svg>", false, 0.0, "Home Air Quality" },
                    { 11, "GAMC", 1725959934.4939735, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5\"></path>\r\n </svg>", false, 0.0, "Gaming Consoles" },
                    { 12, "CAR", 1725959934.4939737, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M14.079 6.839a3 3 0 0 0-4.255.1M13 20h1.083A3.916 3.916 0 0 0 18 16.083V9A6 6 0 1 0 6 9v7m7 4v-1a1 1 0 0 0-1-1h-1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1h1a1 1 0 0 0 1-1Zm-7-4v-6H5a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h1Zm12-6h1a2 2 0 0 1 2 2v2a2 2 0 0 1-2 2h-1v-6Z\" />\r\n </svg>", false, 0.0, "Car & Motorbike Accessories" },
                    { 13, "PHOT", 1725959934.493974, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M13 7h6l2 4m-8-4v8m0-8V6a1 1 0 0 0-1-1H4a1 1 0 0 0-1 1v9h2m8 0H9m4 0h2m4 0h2v-4m0 0h-5m3.5 5.5a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0Zm-10 0a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0Z\"></path>\r\n </svg>", false, 0.0, "Photo & Video Equipment" },
                    { 14, "SEC", 1725959934.493974, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 18V8a1 1 0 0 1 1-1h1.5l1.707-1.707A1 1 0 0 1 8.914 5h6.172a1 1 0 0 1 .707.293L17.5 7H19a1 1 0 0 1 1 1v10a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1Z\"></path>\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15 12a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z\"></path>\r\n  </svg>", false, 0.0, "Security & Wi-Fi Devices" },
                    { 15, "PERI", 1725959934.493974, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\"\r\n           stroke-linecap=\"round\"\r\n           stroke-linejoin=\"round\"\r\n           stroke-width=\"2\"\r\n           d=\"M21 12a28.076 28.076 0 0 1-1.091 9M7.231 4.37a8.994 8.994 0 0 1 12.88 3.73M2.958 15S3 14.577 3 12a8.949 8.949 0 0 1 1.735-5.307m12.84 3.088A5.98 5.98 0 0 1 18 12a30 30 0 0 1-.464 6.232M6 12a6 6 0 0 1 9.352-4.974M4 21a5.964 5.964 0 0 1 1.01-3.328 5.15 5.15 0 0 0 .786-1.926m8.66 2.486a13.96 13.96 0 0 1-.962 2.683M7.5 19.336C9 17.092 9 14.845 9 12a3 3 0 1 1 6 0c0 .749 0 1.521-.031 2.311M12 12c0 3 0 6-2 9\" />\r\n </svg>", false, 0.0, "Computer Peripherals" },
                    { 16, "PHON", 1725959934.4939744, "", " <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 8v4l3 3m6-3a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z\" />\r\n        </svg>", false, 0.0, "Phone Accessories" },
                    { 17, "WATCH", 1725959934.4939744, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 5a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1V5Zm16 14a1 1 0 0 1-1 1h-4a1 1 0 0 1-1-1v-2a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v2ZM4 13a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v6a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1v-6Zm16-2a1 1 0 0 1-1 1h-4a1 1 0 0 1-1-1V5a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v6Z\" />\r\n  </svg>", false, 0.0, "Watches" },
                    { 18, "PRNT", 1725959934.4939744, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M16.444 18H19a1 1 0 0 0 1-1v-5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v5a1 1 0 0 0 1 1h2.556M17 11V5a1 1 0 0 0-1-1H8a1 1 0 0 0-1 1v6h10ZM7 15h10v4a1 1 0 0 1-1 1H8a1 1 0 0 1-1-1v-4Z\" />\r\n        </svg>", false, 0.0, "Printers" },
                    { 19, "PROJ", 1725959934.4939747, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M19 4H5a1 1 0 0 0-1 1v14a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1Zm0 0-4 4m5 0H4m1 0 4-4m1 4 4-4m-4 7v6l4-3-4-3Z\" />\r\n        </svg>", false, 0.0, "Projectors" },
                    { 20, "SKIN", 1725959934.4939747, "", "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12.01 6.001C6.5 1 1 8 5.782 13.001L12.011 20l6.23-7C23 8 17.5 1 12.01 6.002Z\" />\r\n        </svg>", false, 0.0, "Skin Care Products" },
                    { 21, "PHOT", 1725959934.4939747, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 18V8a1 1 0 0 1 1-1h1.5l1.707-1.707A1 1 0 0 1 8.914 5h6.172a1 1 0 0 1 .707.293L17.5 7H19a1 1 0 0 1 1 1v10a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1Z\"></path>\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15 12a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z\"></path>\r\n        </svg>", false, 0.0, "Photo & Video" },
                    { 22, "OFFS", 1725959934.4939749, "", "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M10 12v1h4v-1m4 7H6a1 1 0 0 1-1-1V9h14v9a1 1 0 0 1-1 1ZM4 5h16a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V6a1 1 0 0 1 1-1Z\" />\r\n        </svg>", false, 0.0, "Office Supplies" },
                    { 23, "S&O", 1725959934.4939752, "", "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n    <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M10 12v1h4v-1m4 7H6a1 1 0 0 1-1-1V9h14v9a1 1 0 0 1-1 1ZM4 5h16a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V6a1 1 0 0 1 1-1Z\" />\r\n</svg>", false, 0.0, "Sports & Outdoors" },
                    { 24, "P&H", 1725959934.4939945, "", "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 7h.01m3.486 1.513h.01m-6.978 0h.01M6.99 12H7m9 4h2.706a1.957 1.957 0 0 0 1.883-1.325A9 9 0 1 0 3.043 12.89 9.1 9.1 0 0 0 8.2 20.1a8.62 8.62 0 0 0 3.769.9 2.013 2.013 0 0 0 2.03-2v-.857A2.036 2.036 0 0 1 16 16Z\"></path>\r\n        </svg>", false, 0.0, "Painting & Hobby" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Created", "Description", "Discount", "ImageUrl", "IsDeleted", "LastModified", "Name", "OtherAttributes", "Price", "Sku", "Summary" },
                values: new object[,]
                {
                    { 1, 2, 2, 1725959934.4940059, "Description for product 1", 0.0, "product1.jpg", false, 0.0, "Product 1", "", 668.86000000000001, "sku-1", "" },
                    { 2, 3, 3, 1725959934.4940135, "Description for product 2", 0.0, "product2.jpg", false, 0.0, "Product 2", "", 8.1999999999999993, "sku-2", "" },
                    { 3, 4, 4, 1725959934.494014, "Description for product 3", 0.0, "product3.jpg", false, 0.0, "Product 3", "", 578.08000000000004, "sku-3", "" },
                    { 4, 5, 5, 1725959934.4940145, "Description for product 4", 0.0, "product4.jpg", false, 0.0, "Product 4", "", 577.87, "sku-4", "" },
                    { 5, 6, 6, 1725959934.4940147, "Description for product 5", 0.0, "product5.jpg", false, 0.0, "Product 5", "", 272.31, "sku-5", "" },
                    { 6, 7, 7, 1725959934.4940157, "Description for product 6", 0.0, "product6.jpg", false, 0.0, "Product 6", "", 494.94999999999999, "sku-6", "" },
                    { 7, 8, 8, 1725959934.4940159, "Description for product 7", 0.0, "product7.jpg", false, 0.0, "Product 7", "", 226.30000000000001, "sku-7", "" },
                    { 8, 9, 9, 1725959934.4940197, "Description for product 8", 0.0, "product8.jpg", false, 0.0, "Product 8", "", 135.25999999999999, "sku-8", "" },
                    { 9, 10, 10, 1725959934.4940202, "Description for product 9", 0.0, "product9.jpg", false, 0.0, "Product 9", "", 340.29000000000002, "sku-9", "" },
                    { 10, 11, 11, 1725959934.4940207, "Description for product 10", 0.0, "product10.jpg", false, 0.0, "Product 10", "", 78.239999999999995, "sku-10", "" },
                    { 11, 12, 12, 1725959934.4940214, "Description for product 11", 0.0, "product11.jpg", false, 0.0, "Product 11", "", 955.73000000000002, "sku-11", "" },
                    { 12, 13, 13, 1725959934.4940219, "Description for product 12", 0.0, "product12.jpg", false, 0.0, "Product 12", "", 239.84999999999999, "sku-12", "" },
                    { 13, 14, 14, 1725959934.4940221, "Description for product 13", 0.0, "product13.jpg", false, 0.0, "Product 13", "", 699.57000000000005, "sku-13", "" },
                    { 14, 15, 15, 1725959934.4940228, "Description for product 14", 0.0, "product14.jpg", false, 0.0, "Product 14", "", 96.280000000000001, "sku-14", "" },
                    { 15, 16, 16, 1725959934.4940231, "Description for product 15", 0.0, "product15.jpg", false, 0.0, "Product 15", "", 657.29999999999995, "sku-15", "" },
                    { 16, 17, 17, 1725959934.4940233, "Description for product 16", 0.0, "product16.jpg", false, 0.0, "Product 16", "", 78.709999999999994, "sku-16", "" },
                    { 17, 18, 18, 1725959934.4940238, "Description for product 17", 0.0, "product17.jpg", false, 0.0, "Product 17", "", 590.33000000000004, "sku-17", "" },
                    { 18, 19, 19, 1725959934.4940245, "Description for product 18", 0.0, "product18.jpg", false, 0.0, "Product 18", "", 455.85000000000002, "sku-18", "" },
                    { 19, 20, 20, 1725959934.4940248, "Description for product 19", 0.0, "product19.jpg", false, 0.0, "Product 19", "", 233.81, "sku-19", "" },
                    { 20, 21, 1, 1725959934.4940252, "Description for product 20", 0.0, "product20.jpg", false, 0.0, "Product 20", "", 58.780000000000001, "sku-20", "" },
                    { 21, 22, 2, 1725959934.4940257, "Description for product 21", 0.0, "product21.jpg", false, 0.0, "Product 21", "", 267.95999999999998, "sku-21", "" },
                    { 22, 23, 3, 1725959934.4940259, "Description for product 22", 0.0, "product22.jpg", false, 0.0, "Product 22", "", 646.09000000000003, "sku-22", "" },
                    { 23, 24, 4, 1725959934.4940264, "Description for product 23", 0.0, "product23.jpg", false, 0.0, "Product 23", "", 406.01999999999998, "sku-23", "" },
                    { 24, 25, 5, 1725959934.4940269, "Description for product 24", 0.0, "product24.jpg", false, 0.0, "Product 24", "", 89.030000000000001, "sku-24", "" },
                    { 25, 26, 6, 1725959934.4940269, "Description for product 25", 0.0, "product25.jpg", false, 0.0, "Product 25", "", 390.25999999999999, "sku-25", "" },
                    { 26, 27, 7, 1725959934.4940276, "Description for product 26", 0.0, "product26.jpg", false, 0.0, "Product 26", "", 108.45999999999999, "sku-26", "" },
                    { 27, 28, 8, 1725959934.49403, "Description for product 27", 0.0, "product27.jpg", false, 0.0, "Product 27", "", 811.01999999999998, "sku-27", "" },
                    { 28, 29, 9, 1725959934.4940305, "Description for product 28", 0.0, "product28.jpg", false, 0.0, "Product 28", "", 774.42999999999995, "sku-28", "" },
                    { 29, 30, 10, 1725959934.4940307, "Description for product 29", 0.0, "product29.jpg", false, 0.0, "Product 29", "", 366.39999999999998, "sku-29", "" },
                    { 30, 31, 11, 1725959934.4940312, "Description for product 30", 0.0, "product30.jpg", false, 0.0, "Product 30", "", 350.49000000000001, "sku-30", "" },
                    { 31, 32, 12, 1725959934.4940317, "Description for product 31", 0.0, "product31.jpg", false, 0.0, "Product 31", "", 556.90999999999997, "sku-31", "" },
                    { 32, 33, 13, 1725959934.4940319, "Description for product 32", 0.0, "product32.jpg", false, 0.0, "Product 32", "", 981.59000000000003, "sku-32", "" },
                    { 33, 34, 14, 1725959934.4940324, "Description for product 33", 0.0, "product33.jpg", false, 0.0, "Product 33", "", 577.63999999999999, "sku-33", "" },
                    { 34, 35, 15, 1725959934.4940331, "Description for product 34", 0.0, "product34.jpg", false, 0.0, "Product 34", "", 790.95000000000005, "sku-34", "" },
                    { 35, 36, 16, 1725959934.4940331, "Description for product 35", 0.0, "product35.jpg", false, 0.0, "Product 35", "", 808.78999999999996, "sku-35", "" },
                    { 36, 37, 17, 1725959934.4940336, "Description for product 36", 0.0, "product36.jpg", false, 0.0, "Product 36", "", 229.50999999999999, "sku-36", "" },
                    { 37, 38, 18, 1725959934.4940341, "Description for product 37", 0.0, "product37.jpg", false, 0.0, "Product 37", "", 446.61000000000001, "sku-37", "" },
                    { 38, 39, 19, 1725959934.4940343, "Description for product 38", 0.0, "product38.jpg", false, 0.0, "Product 38", "", 756.90999999999997, "sku-38", "" },
                    { 39, 40, 20, 1725959934.4940348, "Description for product 39", 0.0, "product39.jpg", false, 0.0, "Product 39", "", 739.17999999999995, "sku-39", "" },
                    { 40, 1, 1, 1725959934.4940352, "Description for product 40", 0.0, "product40.jpg", false, 0.0, "Product 40", "", 447.33999999999997, "sku-40", "" },
                    { 41, 2, 2, 1725959934.4940355, "Description for product 41", 0.0, "product41.jpg", false, 0.0, "Product 41", "", 781.89999999999998, "sku-41", "" },
                    { 42, 3, 3, 1725959934.494036, "Description for product 42", 0.0, "product42.jpg", false, 0.0, "Product 42", "", 848.47000000000003, "sku-42", "" },
                    { 43, 4, 4, 1725959934.4940364, "Description for product 43", 0.0, "product43.jpg", false, 0.0, "Product 43", "", 200.55000000000001, "sku-43", "" },
                    { 44, 5, 5, 1725959934.4940369, "Description for product 44", 0.0, "product44.jpg", false, 0.0, "Product 44", "", 955.50999999999999, "sku-44", "" },
                    { 45, 6, 6, 1725959934.4940395, "Description for product 45", 0.0, "product45.jpg", false, 0.0, "Product 45", "", 0.32000000000000001, "sku-45", "" },
                    { 46, 7, 7, 1725959934.49404, "Description for product 46", 0.0, "product46.jpg", false, 0.0, "Product 46", "", 329.48000000000002, "sku-46", "" },
                    { 47, 8, 8, 1725959934.4940405, "Description for product 47", 0.0, "product47.jpg", false, 0.0, "Product 47", "", 900.20000000000005, "sku-47", "" },
                    { 48, 9, 9, 1725959934.4940407, "Description for product 48", 0.0, "product48.jpg", false, 0.0, "Product 48", "", 891.53999999999996, "sku-48", "" },
                    { 49, 10, 10, 1725959934.4940412, "Description for product 49", 0.0, "product49.jpg", false, 0.0, "Product 49", "", 903.88, "sku-49", "" },
                    { 50, 11, 11, 1725959934.4940417, "Description for product 50", 0.0, "product50.jpg", false, 0.0, "Product 50", "", 983.13, "sku-50", "" },
                    { 51, 12, 12, 1725959934.4940419, "Description for product 51", 0.0, "product51.jpg", false, 0.0, "Product 51", "", 314.56, "sku-51", "" },
                    { 52, 13, 13, 1725959934.4940424, "Description for product 52", 0.0, "product52.jpg", false, 0.0, "Product 52", "", 139.30000000000001, "sku-52", "" },
                    { 53, 14, 14, 1725959934.4940429, "Description for product 53", 0.0, "product53.jpg", false, 0.0, "Product 53", "", 965.28999999999996, "sku-53", "" },
                    { 54, 15, 15, 1725959934.4940431, "Description for product 54", 0.0, "product54.jpg", false, 0.0, "Product 54", "", 475.67000000000002, "sku-54", "" },
                    { 55, 16, 16, 1725959934.4940436, "Description for product 55", 0.0, "product55.jpg", false, 0.0, "Product 55", "", 11.1, "sku-55", "" },
                    { 56, 17, 17, 1725959934.4940441, "Description for product 56", 0.0, "product56.jpg", false, 0.0, "Product 56", "", 345.13999999999999, "sku-56", "" },
                    { 57, 18, 18, 1725959934.4940443, "Description for product 57", 0.0, "product57.jpg", false, 0.0, "Product 57", "", 712.78999999999996, "sku-57", "" },
                    { 58, 19, 19, 1725959934.4940448, "Description for product 58", 0.0, "product58.jpg", false, 0.0, "Product 58", "", 779.58000000000004, "sku-58", "" },
                    { 59, 20, 20, 1725959934.4940453, "Description for product 59", 0.0, "product59.jpg", false, 0.0, "Product 59", "", 183.84, "sku-59", "" },
                    { 60, 21, 1, 1725959934.4940455, "Description for product 60", 0.0, "product60.jpg", false, 0.0, "Product 60", "", 313.30000000000001, "sku-60", "" },
                    { 61, 22, 2, 1725959934.4940457, "Description for product 61", 0.0, "product61.jpg", false, 0.0, "Product 61", "", 440.35000000000002, "sku-61", "" },
                    { 62, 23, 3, 1725959934.4940464, "Description for product 62", 0.0, "product62.jpg", false, 0.0, "Product 62", "", 199.69999999999999, "sku-62", "" },
                    { 63, 24, 4, 1725959934.4940467, "Description for product 63", 0.0, "product63.jpg", false, 0.0, "Product 63", "", 138.40000000000001, "sku-63", "" },
                    { 64, 25, 5, 1725959934.4940469, "Description for product 64", 0.0, "product64.jpg", false, 0.0, "Product 64", "", 191.75, "sku-64", "" },
                    { 65, 26, 6, 1725959934.4940495, "Description for product 65", 0.0, "product65.jpg", false, 0.0, "Product 65", "", 504.73000000000002, "sku-65", "" },
                    { 66, 27, 7, 1725959934.49405, "Description for product 66", 0.0, "product66.jpg", false, 0.0, "Product 66", "", 384.88999999999999, "sku-66", "" },
                    { 67, 28, 8, 1725959934.4940505, "Description for product 67", 0.0, "product67.jpg", false, 0.0, "Product 67", "", 444.54000000000002, "sku-67", "" },
                    { 68, 29, 9, 1725959934.4940507, "Description for product 68", 0.0, "product68.jpg", false, 0.0, "Product 68", "", 271.25999999999999, "sku-68", "" },
                    { 69, 30, 10, 1725959934.4940512, "Description for product 69", 0.0, "product69.jpg", false, 0.0, "Product 69", "", 986.01999999999998, "sku-69", "" },
                    { 70, 31, 11, 1725959934.4940517, "Description for product 70", 0.0, "product70.jpg", false, 0.0, "Product 70", "", 967.83000000000004, "sku-70", "" },
                    { 71, 32, 12, 1725959934.4940519, "Description for product 71", 0.0, "product71.jpg", false, 0.0, "Product 71", "", 697.22000000000003, "sku-71", "" },
                    { 72, 33, 13, 1725959934.4940524, "Description for product 72", 0.0, "product72.jpg", false, 0.0, "Product 72", "", 405.29000000000002, "sku-72", "" },
                    { 73, 34, 14, 1725959934.4940529, "Description for product 73", 0.0, "product73.jpg", false, 0.0, "Product 73", "", 458.54000000000002, "sku-73", "" },
                    { 74, 35, 15, 1725959934.4940531, "Description for product 74", 0.0, "product74.jpg", false, 0.0, "Product 74", "", 363.67000000000002, "sku-74", "" },
                    { 75, 36, 16, 1725959934.4940536, "Description for product 75", 0.0, "product75.jpg", false, 0.0, "Product 75", "", 215.34999999999999, "sku-75", "" },
                    { 76, 37, 17, 1725959934.4940541, "Description for product 76", 0.0, "product76.jpg", false, 0.0, "Product 76", "", 193.30000000000001, "sku-76", "" },
                    { 77, 38, 18, 1725959934.4940543, "Description for product 77", 0.0, "product77.jpg", false, 0.0, "Product 77", "", 931.25999999999999, "sku-77", "" },
                    { 78, 39, 19, 1725959934.4940548, "Description for product 78", 0.0, "product78.jpg", false, 0.0, "Product 78", "", 884.89999999999998, "sku-78", "" },
                    { 79, 40, 20, 1725959934.4940553, "Description for product 79", 0.0, "product79.jpg", false, 0.0, "Product 79", "", 272.14999999999998, "sku-79", "" },
                    { 80, 1, 1, 1725959934.4940555, "Description for product 80", 0.0, "product80.jpg", false, 0.0, "Product 80", "", 669.88999999999999, "sku-80", "" },
                    { 81, 2, 2, 1725959934.494056, "Description for product 81", 0.0, "product81.jpg", false, 0.0, "Product 81", "", 800.62, "sku-81", "" },
                    { 82, 3, 3, 1725959934.4940584, "Description for product 82", 0.0, "product82.jpg", false, 0.0, "Product 82", "", 907.95000000000005, "sku-82", "" },
                    { 83, 4, 4, 1725959934.4940588, "Description for product 83", 0.0, "product83.jpg", false, 0.0, "Product 83", "", 189.22999999999999, "sku-83", "" },
                    { 84, 5, 5, 1725959934.4940591, "Description for product 84", 0.0, "product84.jpg", false, 0.0, "Product 84", "", 463.06999999999999, "sku-84", "" },
                    { 85, 6, 6, 1725959934.4940596, "Description for product 85", 0.0, "product85.jpg", false, 0.0, "Product 85", "", 624.55999999999995, "sku-85", "" },
                    { 86, 7, 7, 1725959934.49406, "Description for product 86", 0.0, "product86.jpg", false, 0.0, "Product 86", "", 407.97000000000003, "sku-86", "" },
                    { 87, 8, 8, 1725959934.4940605, "Description for product 87", 0.0, "product87.jpg", false, 0.0, "Product 87", "", 412.98000000000002, "sku-87", "" },
                    { 88, 9, 9, 1725959934.4940608, "Description for product 88", 0.0, "product88.jpg", false, 0.0, "Product 88", "", 551.97000000000003, "sku-88", "" },
                    { 89, 10, 10, 1725959934.4940612, "Description for product 89", 0.0, "product89.jpg", false, 0.0, "Product 89", "", 633.27999999999997, "sku-89", "" },
                    { 90, 11, 11, 1725959934.4940617, "Description for product 90", 0.0, "product90.jpg", false, 0.0, "Product 90", "", 718.95000000000005, "sku-90", "" },
                    { 91, 12, 12, 1725959934.4940619, "Description for product 91", 0.0, "product91.jpg", false, 0.0, "Product 91", "", 962.64999999999998, "sku-91", "" },
                    { 92, 13, 13, 1725959934.4940624, "Description for product 92", 0.0, "product92.jpg", false, 0.0, "Product 92", "", 298.69999999999999, "sku-92", "" },
                    { 93, 14, 14, 1725959934.4940627, "Description for product 93", 0.0, "product93.jpg", false, 0.0, "Product 93", "", 955.88, "sku-93", "" },
                    { 94, 15, 15, 1725959934.4940631, "Description for product 94", 0.0, "product94.jpg", false, 0.0, "Product 94", "", 764.51999999999998, "sku-94", "" },
                    { 95, 16, 16, 1725959934.4940634, "Description for product 95", 0.0, "product95.jpg", false, 0.0, "Product 95", "", 428.14999999999998, "sku-95", "" },
                    { 96, 17, 17, 1725959934.4940639, "Description for product 96", 0.0, "product96.jpg", false, 0.0, "Product 96", "", 649.38999999999999, "sku-96", "" },
                    { 97, 18, 18, 1725959934.4940641, "Description for product 97", 0.0, "product97.jpg", false, 0.0, "Product 97", "", 466.02999999999997, "sku-97", "" },
                    { 98, 19, 19, 1725959934.4940646, "Description for product 98", 0.0, "product98.jpg", false, 0.0, "Product 98", "", 242.30000000000001, "sku-98", "" },
                    { 99, 20, 20, 1725959934.494065, "Description for product 99", 0.0, "product99.jpg", false, 0.0, "Product 99", "", 249.77000000000001, "sku-99", "" },
                    { 100, 21, 1, 1725959934.4940653, "Description for product 100", 0.0, "product100.jpg", false, 0.0, "Product 100", "", 16.210000000000001, "sku-100", "" },
                    { 101, 22, 2, 1725959934.4940655, "Description for product 101", 0.0, "product101.jpg", false, 0.0, "Product 101", "", 375.73000000000002, "sku-101", "" },
                    { 102, 23, 3, 1725959934.4940681, "Description for product 102", 0.0, "product102.jpg", false, 0.0, "Product 102", "", 294.75, "sku-102", "" },
                    { 103, 24, 4, 1725959934.4940686, "Description for product 103", 0.0, "product103.jpg", false, 0.0, "Product 103", "", 930.35000000000002, "sku-103", "" },
                    { 104, 25, 5, 1725959934.4940691, "Description for product 104", 0.0, "product104.jpg", false, 0.0, "Product 104", "", 763.80999999999995, "sku-104", "" },
                    { 105, 26, 6, 1725959934.4940691, "Description for product 105", 0.0, "product105.jpg", false, 0.0, "Product 105", "", 385.27999999999997, "sku-105", "" },
                    { 106, 27, 7, 1725959934.4940698, "Description for product 106", 0.0, "product106.jpg", false, 0.0, "Product 106", "", 137.00999999999999, "sku-106", "" },
                    { 107, 28, 8, 1725959934.4940701, "Description for product 107", 0.0, "product107.jpg", false, 0.0, "Product 107", "", 681.45000000000005, "sku-107", "" },
                    { 108, 29, 9, 1725959934.4940703, "Description for product 108", 0.0, "product108.jpg", false, 0.0, "Product 108", "", 863.37, "sku-108", "" },
                    { 109, 30, 10, 1725959934.4940708, "Description for product 109", 0.0, "product109.jpg", false, 0.0, "Product 109", "", 777.32000000000005, "sku-109", "" },
                    { 110, 31, 11, 1725959934.4940715, "Description for product 110", 0.0, "product110.jpg", false, 0.0, "Product 110", "", 618.92999999999995, "sku-110", "" },
                    { 111, 32, 12, 1725959934.4940717, "Description for product 111", 0.0, "product111.jpg", false, 0.0, "Product 111", "", 97.609999999999999, "sku-111", "" },
                    { 112, 33, 13, 1725959934.494072, "Description for product 112", 0.0, "product112.jpg", false, 0.0, "Product 112", "", 337.55000000000001, "sku-112", "" },
                    { 113, 34, 14, 1725959934.4940724, "Description for product 113", 0.0, "product113.jpg", false, 0.0, "Product 113", "", 434.81999999999999, "sku-113", "" },
                    { 114, 35, 15, 1725959934.4940729, "Description for product 114", 0.0, "product114.jpg", false, 0.0, "Product 114", "", 421.87, "sku-114", "" },
                    { 115, 36, 16, 1725959934.4940732, "Description for product 115", 0.0, "product115.jpg", false, 0.0, "Product 115", "", 905.30999999999995, "sku-115", "" },
                    { 116, 37, 17, 1725959934.4940736, "Description for product 116", 0.0, "product116.jpg", false, 0.0, "Product 116", "", 134.27000000000001, "sku-116", "" },
                    { 117, 38, 18, 1725959934.4940741, "Description for product 117", 0.0, "product117.jpg", false, 0.0, "Product 117", "", 463.88999999999999, "sku-117", "" },
                    { 118, 39, 19, 1725959934.4940743, "Description for product 118", 0.0, "product118.jpg", false, 0.0, "Product 118", "", 428.81, "sku-118", "" },
                    { 119, 40, 20, 1725959934.4940748, "Description for product 119", 0.0, "product119.jpg", false, 0.0, "Product 119", "", 838.75, "sku-119", "" },
                    { 120, 1, 1, 1725959934.4940753, "Description for product 120", 0.0, "product120.jpg", false, 0.0, "Product 120", "", 929.87, "sku-120", "" },
                    { 121, 2, 2, 1725959934.4940767, "Description for product 121", 0.0, "product121.jpg", false, 0.0, "Product 121", "", 913.79999999999995, "sku-121", "" },
                    { 122, 3, 3, 1725959934.4940772, "Description for product 122", 0.0, "product122.jpg", false, 0.0, "Product 122", "", 759.19000000000005, "sku-122", "" },
                    { 123, 4, 4, 1725959934.4940777, "Description for product 123", 0.0, "product123.jpg", false, 0.0, "Product 123", "", 317.89999999999998, "sku-123", "" },
                    { 124, 5, 5, 1725959934.4940779, "Description for product 124", 0.0, "product124.jpg", false, 0.0, "Product 124", "", 872.92999999999995, "sku-124", "" },
                    { 125, 6, 6, 1725959934.4940784, "Description for product 125", 0.0, "product125.jpg", false, 0.0, "Product 125", "", 97.569999999999993, "sku-125", "" },
                    { 126, 7, 7, 1725959934.4940789, "Description for product 126", 0.0, "product126.jpg", false, 0.0, "Product 126", "", 918.04999999999995, "sku-126", "" },
                    { 127, 8, 8, 1725959934.4940791, "Description for product 127", 0.0, "product127.jpg", false, 0.0, "Product 127", "", 890.37, "sku-127", "" },
                    { 128, 9, 9, 1725959934.4940796, "Description for product 128", 0.0, "product128.jpg", false, 0.0, "Product 128", "", 286.16000000000003, "sku-128", "" },
                    { 129, 10, 10, 1725959934.4940798, "Description for product 129", 0.0, "product129.jpg", false, 0.0, "Product 129", "", 530.58000000000004, "sku-129", "" },
                    { 130, 11, 11, 1725959934.4940803, "Description for product 130", 0.0, "product130.jpg", false, 0.0, "Product 130", "", 723.40999999999997, "sku-130", "" },
                    { 131, 12, 12, 1725959934.4940808, "Description for product 131", 0.0, "product131.jpg", false, 0.0, "Product 131", "", 275.97000000000003, "sku-131", "" },
                    { 132, 13, 13, 1725959934.4940813, "Description for product 132", 0.0, "product132.jpg", false, 0.0, "Product 132", "", 165.53, "sku-132", "" },
                    { 133, 14, 14, 1725959934.4940815, "Description for product 133", 0.0, "product133.jpg", false, 0.0, "Product 133", "", 487.25, "sku-133", "" },
                    { 134, 15, 15, 1725959934.494082, "Description for product 134", 0.0, "product134.jpg", false, 0.0, "Product 134", "", 458.85000000000002, "sku-134", "" },
                    { 135, 16, 16, 1725959934.4940856, "Description for product 135", 0.0, "product135.jpg", false, 0.0, "Product 135", "", 60.68, "sku-135", "" },
                    { 136, 17, 17, 1725959934.494086, "Description for product 136", 0.0, "product136.jpg", false, 0.0, "Product 136", "", 461.30000000000001, "sku-136", "" },
                    { 137, 18, 18, 1725959934.4940865, "Description for product 137", 0.0, "product137.jpg", false, 0.0, "Product 137", "", 116.66, "sku-137", "" },
                    { 138, 19, 19, 1725959934.4940867, "Description for product 138", 0.0, "product138.jpg", false, 0.0, "Product 138", "", 100.73, "sku-138", "" },
                    { 139, 20, 20, 1725959934.4940872, "Description for product 139", 0.0, "product139.jpg", false, 0.0, "Product 139", "", 943.96000000000004, "sku-139", "" },
                    { 140, 21, 1, 1725959934.4940877, "Description for product 140", 0.0, "product140.jpg", false, 0.0, "Product 140", "", 395.61000000000001, "sku-140", "" },
                    { 141, 22, 2, 1725959934.4940879, "Description for product 141", 0.0, "product141.jpg", false, 0.0, "Product 141", "", 389.81, "sku-141", "" },
                    { 142, 23, 3, 1725959934.4940884, "Description for product 142", 0.0, "product142.jpg", false, 0.0, "Product 142", "", 668.98000000000002, "sku-142", "" },
                    { 143, 24, 4, 1725959934.4940889, "Description for product 143", 0.0, "product143.jpg", false, 0.0, "Product 143", "", 201.62, "sku-143", "" },
                    { 144, 25, 5, 1725959934.4940891, "Description for product 144", 0.0, "product144.jpg", false, 0.0, "Product 144", "", 874.23000000000002, "sku-144", "" },
                    { 145, 26, 6, 1725959934.4940894, "Description for product 145", 0.0, "product145.jpg", false, 0.0, "Product 145", "", 956.03999999999996, "sku-145", "" },
                    { 146, 27, 7, 1725959934.4940901, "Description for product 146", 0.0, "product146.jpg", false, 0.0, "Product 146", "", 146.13999999999999, "sku-146", "" },
                    { 147, 28, 8, 1725959934.4940903, "Description for product 147", 0.0, "product147.jpg", false, 0.0, "Product 147", "", 402.20999999999998, "sku-147", "" },
                    { 148, 29, 9, 1725959934.4940908, "Description for product 148", 0.0, "product148.jpg", false, 0.0, "Product 148", "", 747.19000000000005, "sku-148", "" },
                    { 149, 30, 10, 1725959934.494091, "Description for product 149", 0.0, "product149.jpg", false, 0.0, "Product 149", "", 683.13999999999999, "sku-149", "" },
                    { 150, 31, 11, 1725959934.4940915, "Description for product 150", 0.0, "product150.jpg", false, 0.0, "Product 150", "", 678.32000000000005, "sku-150", "" },
                    { 151, 32, 12, 1725959934.494092, "Description for product 151", 0.0, "product151.jpg", false, 0.0, "Product 151", "", 433.05000000000001, "sku-151", "" },
                    { 152, 33, 13, 1725959934.4940922, "Description for product 152", 0.0, "product152.jpg", false, 0.0, "Product 152", "", 604.89999999999998, "sku-152", "" },
                    { 153, 34, 14, 1725959934.4940927, "Description for product 153", 0.0, "product153.jpg", false, 0.0, "Product 153", "", 361.29000000000002, "sku-153", "" },
                    { 154, 35, 15, 1725959934.4940956, "Description for product 154", 0.0, "product154.jpg", false, 0.0, "Product 154", "", 317.39999999999998, "sku-154", "" },
                    { 155, 36, 16, 1725959934.494096, "Description for product 155", 0.0, "product155.jpg", false, 0.0, "Product 155", "", 802.51999999999998, "sku-155", "" },
                    { 156, 37, 17, 1725959934.4940965, "Description for product 156", 0.0, "product156.jpg", false, 0.0, "Product 156", "", 433.73000000000002, "sku-156", "" },
                    { 157, 38, 18, 1725959934.4940968, "Description for product 157", 0.0, "product157.jpg", false, 0.0, "Product 157", "", 962.48000000000002, "sku-157", "" },
                    { 158, 39, 19, 1725959934.4940972, "Description for product 158", 0.0, "product158.jpg", false, 0.0, "Product 158", "", 775.13, "sku-158", "" },
                    { 159, 40, 20, 1725959934.4940977, "Description for product 159", 0.0, "product159.jpg", false, 0.0, "Product 159", "", 174.84, "sku-159", "" },
                    { 160, 1, 1, 1725959934.4940979, "Description for product 160", 0.0, "product160.jpg", false, 0.0, "Product 160", "", 970.0, "sku-160", "" },
                    { 161, 2, 2, 1725959934.4940984, "Description for product 161", 0.0, "product161.jpg", false, 0.0, "Product 161", "", 758.95000000000005, "sku-161", "" },
                    { 162, 3, 3, 1725959934.4940989, "Description for product 162", 0.0, "product162.jpg", false, 0.0, "Product 162", "", 798.67999999999995, "sku-162", "" },
                    { 163, 4, 4, 1725959934.4940991, "Description for product 163", 0.0, "product163.jpg", false, 0.0, "Product 163", "", 292.93000000000001, "sku-163", "" },
                    { 164, 5, 5, 1725959934.4940996, "Description for product 164", 0.0, "product164.jpg", false, 0.0, "Product 164", "", 64.280000000000001, "sku-164", "" },
                    { 165, 6, 6, 1725959934.4941001, "Description for product 165", 0.0, "product165.jpg", false, 0.0, "Product 165", "", 482.19, "sku-165", "" },
                    { 166, 7, 7, 1725959934.4941003, "Description for product 166", 0.0, "product166.jpg", false, 0.0, "Product 166", "", 236.56, "sku-166", "" },
                    { 167, 8, 8, 1725959934.4941008, "Description for product 167", 0.0, "product167.jpg", false, 0.0, "Product 167", "", 349.60000000000002, "sku-167", "" },
                    { 168, 9, 9, 1725959934.4941013, "Description for product 168", 0.0, "product168.jpg", false, 0.0, "Product 168", "", 301.44999999999999, "sku-168", "" },
                    { 169, 10, 10, 1725959934.4941015, "Description for product 169", 0.0, "product169.jpg", false, 0.0, "Product 169", "", 378.51999999999998, "sku-169", "" },
                    { 170, 11, 11, 1725959934.494102, "Description for product 170", 0.0, "product170.jpg", false, 0.0, "Product 170", "", 89.010000000000005, "sku-170", "" },
                    { 171, 12, 12, 1725959934.4941025, "Description for product 171", 0.0, "product171.jpg", false, 0.0, "Product 171", "", 595.47000000000003, "sku-171", "" },
                    { 172, 13, 13, 1725959934.4941027, "Description for product 172", 0.0, "product172.jpg", false, 0.0, "Product 172", "", 129.37, "sku-172", "" },
                    { 173, 14, 14, 1725959934.4941032, "Description for product 173", 0.0, "product173.jpg", false, 0.0, "Product 173", "", 976.17999999999995, "sku-173", "" },
                    { 174, 15, 15, 1725959934.4941056, "Description for product 174", 0.0, "product174.jpg", false, 0.0, "Product 174", "", 230.31, "sku-174", "" },
                    { 175, 16, 16, 1725959934.4941061, "Description for product 175", 0.0, "product175.jpg", false, 0.0, "Product 175", "", 578.37, "sku-175", "" },
                    { 176, 17, 17, 1725959934.4941063, "Description for product 176", 0.0, "product176.jpg", false, 0.0, "Product 176", "", 395.51999999999998, "sku-176", "" },
                    { 177, 18, 18, 1725959934.4941068, "Description for product 177", 0.0, "product177.jpg", false, 0.0, "Product 177", "", 716.92999999999995, "sku-177", "" },
                    { 178, 19, 19, 1725959934.4941072, "Description for product 178", 0.0, "product178.jpg", false, 0.0, "Product 178", "", 678.77999999999997, "sku-178", "" },
                    { 179, 20, 20, 1725959934.4941075, "Description for product 179", 0.0, "product179.jpg", false, 0.0, "Product 179", "", 684.49000000000001, "sku-179", "" },
                    { 180, 21, 1, 1725959934.494108, "Description for product 180", 0.0, "product180.jpg", false, 0.0, "Product 180", "", 136.03999999999999, "sku-180", "" },
                    { 181, 22, 2, 1725959934.4941084, "Description for product 181", 0.0, "product181.jpg", false, 0.0, "Product 181", "", 74.129999999999995, "sku-181", "" },
                    { 182, 23, 3, 1725959934.4941089, "Description for product 182", 0.0, "product182.jpg", false, 0.0, "Product 182", "", 567.92999999999995, "sku-182", "" },
                    { 183, 24, 4, 1725959934.4941092, "Description for product 183", 0.0, "product183.jpg", false, 0.0, "Product 183", "", 325.73000000000002, "sku-183", "" },
                    { 184, 25, 5, 1725959934.4941096, "Description for product 184", 0.0, "product184.jpg", false, 0.0, "Product 184", "", 219.31999999999999, "sku-184", "" },
                    { 185, 26, 6, 1725959934.4941099, "Description for product 185", 0.0, "product185.jpg", false, 0.0, "Product 185", "", 47.009999999999998, "sku-185", "" },
                    { 186, 27, 7, 1725959934.4941103, "Description for product 186", 0.0, "product186.jpg", false, 0.0, "Product 186", "", 555.88999999999999, "sku-186", "" },
                    { 187, 28, 8, 1725959934.4941108, "Description for product 187", 0.0, "product187.jpg", false, 0.0, "Product 187", "", 331.36000000000001, "sku-187", "" },
                    { 188, 29, 9, 1725959934.4941113, "Description for product 188", 0.0, "product188.jpg", false, 0.0, "Product 188", "", 605.0, "sku-188", "" },
                    { 189, 30, 10, 1725959934.4941113, "Description for product 189", 0.0, "product189.jpg", false, 0.0, "Product 189", "", 60.539999999999999, "sku-189", "" },
                    { 190, 31, 11, 1725959934.494112, "Description for product 190", 0.0, "product190.jpg", false, 0.0, "Product 190", "", 938.09000000000003, "sku-190", "" },
                    { 191, 32, 12, 1725959934.4941125, "Description for product 191", 0.0, "product191.jpg", false, 0.0, "Product 191", "", 434.44, "sku-191", "" },
                    { 192, 33, 13, 1725959934.4941127, "Description for product 192", 0.0, "product192.jpg", false, 0.0, "Product 192", "", 34.380000000000003, "sku-192", "" },
                    { 193, 34, 14, 1725959934.4941151, "Description for product 193", 0.0, "product193.jpg", false, 0.0, "Product 193", "", 729.82000000000005, "sku-193", "" },
                    { 194, 35, 15, 1725959934.4941156, "Description for product 194", 0.0, "product194.jpg", false, 0.0, "Product 194", "", 961.49000000000001, "sku-194", "" },
                    { 195, 36, 16, 1725959934.4941161, "Description for product 195", 0.0, "product195.jpg", false, 0.0, "Product 195", "", 586.33000000000004, "sku-195", "" },
                    { 196, 37, 17, 1725959934.4941163, "Description for product 196", 0.0, "product196.jpg", false, 0.0, "Product 196", "", 238.68000000000001, "sku-196", "" },
                    { 197, 38, 18, 1725959934.4941168, "Description for product 197", 0.0, "product197.jpg", false, 0.0, "Product 197", "", 121.98, "sku-197", "" },
                    { 198, 39, 19, 1725959934.4941173, "Description for product 198", 0.0, "product198.jpg", false, 0.0, "Product 198", "", 953.82000000000005, "sku-198", "" },
                    { 199, 40, 20, 1725959934.4941175, "Description for product 199", 0.0, "product199.jpg", false, 0.0, "Product 199", "", 842.70000000000005, "sku-199", "" },
                    { 200, 1, 1, 1725959934.494118, "Description for product 200", 0.0, "product200.jpg", false, 0.0, "Product 200", "", 689.87, "sku-200", "" },
                    { 201, 2, 2, 1725959934.4941182, "Description for product 201", 0.0, "product201.jpg", false, 0.0, "Product 201", "", 533.69000000000005, "sku-201", "" },
                    { 202, 3, 3, 1725959934.4941187, "Description for product 202", 0.0, "product202.jpg", false, 0.0, "Product 202", "", 40.960000000000001, "sku-202", "" },
                    { 203, 4, 4, 1725959934.4941189, "Description for product 203", 0.0, "product203.jpg", false, 0.0, "Product 203", "", 658.01999999999998, "sku-203", "" },
                    { 204, 5, 5, 1725959934.4941194, "Description for product 204", 0.0, "product204.jpg", false, 0.0, "Product 204", "", 412.62, "sku-204", "" },
                    { 205, 6, 6, 1725959934.4941196, "Description for product 205", 0.0, "product205.jpg", false, 0.0, "Product 205", "", 544.70000000000005, "sku-205", "" },
                    { 206, 7, 7, 1725959934.4941201, "Description for product 206", 0.0, "product206.jpg", false, 0.0, "Product 206", "", 169.75, "sku-206", "" },
                    { 207, 8, 8, 1725959934.4941204, "Description for product 207", 0.0, "product207.jpg", false, 0.0, "Product 207", "", 970.13999999999999, "sku-207", "" },
                    { 208, 9, 9, 1725959934.4941208, "Description for product 208", 0.0, "product208.jpg", false, 0.0, "Product 208", "", 384.18000000000001, "sku-208", "" },
                    { 209, 10, 10, 1725959934.4941213, "Description for product 209", 0.0, "product209.jpg", false, 0.0, "Product 209", "", 146.94, "sku-209", "" },
                    { 210, 11, 11, 1725959934.4941218, "Description for product 210", 0.0, "product210.jpg", false, 0.0, "Product 210", "", 529.38, "sku-210", "" },
                    { 211, 12, 12, 1725959934.4941223, "Description for product 211", 0.0, "product211.jpg", false, 0.0, "Product 211", "", 212.31999999999999, "sku-211", "" },
                    { 212, 13, 13, 1725959934.4941249, "Description for product 212", 0.0, "product212.jpg", false, 0.0, "Product 212", "", 204.43000000000001, "sku-212", "" },
                    { 213, 14, 14, 1725959934.4941251, "Description for product 213", 0.0, "product213.jpg", false, 0.0, "Product 213", "", 789.90999999999997, "sku-213", "" },
                    { 214, 15, 15, 1725959934.4941256, "Description for product 214", 0.0, "product214.jpg", false, 0.0, "Product 214", "", 190.47999999999999, "sku-214", "" },
                    { 215, 16, 16, 1725959934.4941261, "Description for product 215", 0.0, "product215.jpg", false, 0.0, "Product 215", "", 36.229999999999997, "sku-215", "" },
                    { 216, 17, 17, 1725959934.4941263, "Description for product 216", 0.0, "product216.jpg", false, 0.0, "Product 216", "", 130.78, "sku-216", "" },
                    { 217, 18, 18, 1725959934.4941268, "Description for product 217", 0.0, "product217.jpg", false, 0.0, "Product 217", "", 851.70000000000005, "sku-217", "" },
                    { 218, 19, 19, 1725959934.4941273, "Description for product 218", 0.0, "product218.jpg", false, 0.0, "Product 218", "", 711.65999999999997, "sku-218", "" },
                    { 219, 20, 20, 1725959934.4941275, "Description for product 219", 0.0, "product219.jpg", false, 0.0, "Product 219", "", 93.900000000000006, "sku-219", "" },
                    { 220, 21, 1, 1725959934.494128, "Description for product 220", 0.0, "product220.jpg", false, 0.0, "Product 220", "", 330.94999999999999, "sku-220", "" },
                    { 221, 22, 2, 1725959934.4941285, "Description for product 221", 0.0, "product221.jpg", false, 0.0, "Product 221", "", 365.20999999999998, "sku-221", "" },
                    { 222, 23, 3, 1725959934.4941287, "Description for product 222", 0.0, "product222.jpg", false, 0.0, "Product 222", "", 748.12, "sku-222", "" },
                    { 223, 24, 4, 1725959934.4941292, "Description for product 223", 0.0, "product223.jpg", false, 0.0, "Product 223", "", 89.75, "sku-223", "" },
                    { 224, 25, 5, 1725959934.4941297, "Description for product 224", 0.0, "product224.jpg", false, 0.0, "Product 224", "", 439.22000000000003, "sku-224", "" },
                    { 225, 26, 6, 1725959934.4941299, "Description for product 225", 0.0, "product225.jpg", false, 0.0, "Product 225", "", 186.53999999999999, "sku-225", "" },
                    { 226, 27, 7, 1725959934.4941304, "Description for product 226", 0.0, "product226.jpg", false, 0.0, "Product 226", "", 646.10000000000002, "sku-226", "" },
                    { 227, 28, 8, 1725959934.4941308, "Description for product 227", 0.0, "product227.jpg", false, 0.0, "Product 227", "", 824.67999999999995, "sku-227", "" },
                    { 228, 29, 9, 1725959934.4941311, "Description for product 228", 0.0, "product228.jpg", false, 0.0, "Product 228", "", 834.25, "sku-228", "" },
                    { 229, 30, 10, 1725959934.4941313, "Description for product 229", 0.0, "product229.jpg", false, 0.0, "Product 229", "", 598.75999999999999, "sku-229", "" },
                    { 230, 31, 11, 1725959934.494132, "Description for product 230", 0.0, "product230.jpg", false, 0.0, "Product 230", "", 143.71000000000001, "sku-230", "" },
                    { 231, 32, 12, 1725959934.4941323, "Description for product 231", 0.0, "product231.jpg", false, 0.0, "Product 231", "", 439.73000000000002, "sku-231", "" },
                    { 232, 33, 13, 1725959934.494148, "Description for product 232", 0.0, "product232.jpg", false, 0.0, "Product 232", "", 327.32999999999998, "sku-232", "" },
                    { 233, 34, 14, 1725959934.4941483, "Description for product 233", 0.0, "product233.jpg", false, 0.0, "Product 233", "", 234.55000000000001, "sku-233", "" },
                    { 234, 35, 15, 1725959934.4941487, "Description for product 234", 0.0, "product234.jpg", false, 0.0, "Product 234", "", 89.180000000000007, "sku-234", "" },
                    { 235, 36, 16, 1725959934.4941492, "Description for product 235", 0.0, "product235.jpg", false, 0.0, "Product 235", "", 398.19, "sku-235", "" },
                    { 236, 37, 17, 1725959934.4941494, "Description for product 236", 0.0, "product236.jpg", false, 0.0, "Product 236", "", 740.04999999999995, "sku-236", "" },
                    { 237, 38, 18, 1725959934.4941497, "Description for product 237", 0.0, "product237.jpg", false, 0.0, "Product 237", "", 350.02999999999997, "sku-237", "" },
                    { 238, 39, 19, 1725959934.4941502, "Description for product 238", 0.0, "product238.jpg", false, 0.0, "Product 238", "", 467.31999999999999, "sku-238", "" },
                    { 239, 40, 20, 1725959934.4941506, "Description for product 239", 0.0, "product239.jpg", false, 0.0, "Product 239", "", 568.54999999999995, "sku-239", "" },
                    { 240, 1, 1, 1725959934.4941509, "Description for product 240", 0.0, "product240.jpg", false, 0.0, "Product 240", "", 381.37, "sku-240", "" },
                    { 241, 2, 2, 1725959934.4941511, "Description for product 241", 0.0, "product241.jpg", false, 0.0, "Product 241", "", 89.109999999999999, "sku-241", "" },
                    { 242, 3, 3, 1725959934.4941518, "Description for product 242", 0.0, "product242.jpg", false, 0.0, "Product 242", "", 310.38, "sku-242", "" },
                    { 243, 4, 4, 1725959934.4941521, "Description for product 243", 0.0, "product243.jpg", false, 0.0, "Product 243", "", 110.83, "sku-243", "" },
                    { 244, 5, 5, 1725959934.4941523, "Description for product 244", 0.0, "product244.jpg", false, 0.0, "Product 244", "", 445.13999999999999, "sku-244", "" },
                    { 245, 6, 6, 1725959934.4941528, "Description for product 245", 0.0, "product245.jpg", false, 0.0, "Product 245", "", 914.25999999999999, "sku-245", "" },
                    { 246, 7, 7, 1725959934.4941533, "Description for product 246", 0.0, "product246.jpg", false, 0.0, "Product 246", "", 992.61000000000001, "sku-246", "" },
                    { 247, 8, 8, 1725959934.4941535, "Description for product 247", 0.0, "product247.jpg", false, 0.0, "Product 247", "", 199.31, "sku-247", "" },
                    { 248, 9, 9, 1725959934.494154, "Description for product 248", 0.0, "product248.jpg", false, 0.0, "Product 248", "", 894.19000000000005, "sku-248", "" },
                    { 249, 10, 10, 1725959934.4941545, "Description for product 249", 0.0, "product249.jpg", false, 0.0, "Product 249", "", 108.93000000000001, "sku-249", "" },
                    { 250, 11, 11, 1725959934.4941547, "Description for product 250", 0.0, "product250.jpg", false, 0.0, "Product 250", "", 428.31999999999999, "sku-250", "" },
                    { 251, 12, 12, 1725959934.4941573, "Description for product 251", 0.0, "product251.jpg", false, 0.0, "Product 251", "", 244.34, "sku-251", "" },
                    { 252, 13, 13, 1725959934.4941576, "Description for product 252", 0.0, "product252.jpg", false, 0.0, "Product 252", "", 90.959999999999994, "sku-252", "" },
                    { 253, 14, 14, 1725959934.494158, "Description for product 253", 0.0, "product253.jpg", false, 0.0, "Product 253", "", 591.61000000000001, "sku-253", "" },
                    { 254, 15, 15, 1725959934.4941585, "Description for product 254", 0.0, "product254.jpg", false, 0.0, "Product 254", "", 446.98000000000002, "sku-254", "" },
                    { 255, 16, 16, 1725959934.4941587, "Description for product 255", 0.0, "product255.jpg", false, 0.0, "Product 255", "", 817.50999999999999, "sku-255", "" },
                    { 256, 17, 17, 1725959934.4941592, "Description for product 256", 0.0, "product256.jpg", false, 0.0, "Product 256", "", 215.93000000000001, "sku-256", "" },
                    { 257, 18, 18, 1725959934.4941597, "Description for product 257", 0.0, "product257.jpg", false, 0.0, "Product 257", "", 603.99000000000001, "sku-257", "" },
                    { 258, 19, 19, 1725959934.4941604, "Description for product 258", 0.0, "product258.jpg", false, 0.0, "Product 258", "", 238.56, "sku-258", "" },
                    { 259, 20, 20, 1725959934.4941609, "Description for product 259", 0.0, "product259.jpg", false, 0.0, "Product 259", "", 765.05999999999995, "sku-259", "" },
                    { 260, 21, 1, 1725959934.4941609, "Description for product 260", 0.0, "product260.jpg", false, 0.0, "Product 260", "", 556.04999999999995, "sku-260", "" },
                    { 261, 22, 2, 1725959934.494163, "Description for product 261", 0.0, "product261.jpg", false, 0.0, "Product 261", "", 749.80999999999995, "sku-261", "" },
                    { 262, 23, 3, 1725959934.4941635, "Description for product 262", 0.0, "product262.jpg", false, 0.0, "Product 262", "", 366.94, "sku-262", "" },
                    { 263, 24, 4, 1725959934.494164, "Description for product 263", 0.0, "product263.jpg", false, 0.0, "Product 263", "", 516.80999999999995, "sku-263", "" },
                    { 264, 25, 5, 1725959934.4941642, "Description for product 264", 0.0, "product264.jpg", false, 0.0, "Product 264", "", 447.38, "sku-264", "" },
                    { 265, 26, 6, 1725959934.4941647, "Description for product 265", 0.0, "product265.jpg", false, 0.0, "Product 265", "", 132.52000000000001, "sku-265", "" },
                    { 266, 27, 7, 1725959934.4941652, "Description for product 266", 0.0, "product266.jpg", false, 0.0, "Product 266", "", 517.17999999999995, "sku-266", "" },
                    { 267, 28, 8, 1725959934.4941654, "Description for product 267", 0.0, "product267.jpg", false, 0.0, "Product 267", "", 379.85000000000002, "sku-267", "" },
                    { 268, 29, 9, 1725959934.4941659, "Description for product 268", 0.0, "product268.jpg", false, 0.0, "Product 268", "", 639.60000000000002, "sku-268", "" },
                    { 269, 30, 10, 1725959934.4941659, "Description for product 269", 0.0, "product269.jpg", false, 0.0, "Product 269", "", 571.96000000000004, "sku-269", "" },
                    { 270, 31, 11, 1725959934.4941666, "Description for product 270", 0.0, "product270.jpg", false, 0.0, "Product 270", "", 29.690000000000001, "sku-270", "" },
                    { 271, 32, 12, 1725959934.4941671, "Description for product 271", 0.0, "product271.jpg", false, 0.0, "Product 271", "", 230.13, "sku-271", "" },
                    { 272, 33, 13, 1725959934.4941671, "Description for product 272", 0.0, "product272.jpg", false, 0.0, "Product 272", "", 305.70999999999998, "sku-272", "" },
                    { 273, 34, 14, 1725959934.4941676, "Description for product 273", 0.0, "product273.jpg", false, 0.0, "Product 273", "", 51.68, "sku-273", "" },
                    { 274, 35, 15, 1725959934.494168, "Description for product 274", 0.0, "product274.jpg", false, 0.0, "Product 274", "", 473.27999999999997, "sku-274", "" },
                    { 275, 36, 16, 1725959934.4941683, "Description for product 275", 0.0, "product275.jpg", false, 0.0, "Product 275", "", 892.79999999999995, "sku-275", "" },
                    { 276, 37, 17, 1725959934.4941688, "Description for product 276", 0.0, "product276.jpg", false, 0.0, "Product 276", "", 265.75, "sku-276", "" },
                    { 277, 38, 18, 1725959934.4941692, "Description for product 277", 0.0, "product277.jpg", false, 0.0, "Product 277", "", 156.47999999999999, "sku-277", "" },
                    { 278, 39, 19, 1725959934.4941697, "Description for product 278", 0.0, "product278.jpg", false, 0.0, "Product 278", "", 529.52999999999997, "sku-278", "" },
                    { 279, 40, 20, 1725959934.4941728, "Description for product 279", 0.0, "product279.jpg", false, 0.0, "Product 279", "", 593.39999999999998, "sku-279", "" },
                    { 280, 1, 1, 1725959934.4941733, "Description for product 280", 0.0, "product280.jpg", false, 0.0, "Product 280", "", 469.81999999999999, "sku-280", "" },
                    { 281, 2, 2, 1725959934.4941735, "Description for product 281", 0.0, "product281.jpg", false, 0.0, "Product 281", "", 7.04, "sku-281", "" },
                    { 282, 3, 3, 1725959934.494174, "Description for product 282", 0.0, "product282.jpg", false, 0.0, "Product 282", "", 147.61000000000001, "sku-282", "" },
                    { 283, 4, 4, 1725959934.4941745, "Description for product 283", 0.0, "product283.jpg", false, 0.0, "Product 283", "", 708.14999999999998, "sku-283", "" },
                    { 284, 5, 5, 1725959934.4941747, "Description for product 284", 0.0, "product284.jpg", false, 0.0, "Product 284", "", 209.34, "sku-284", "" },
                    { 285, 6, 6, 1725959934.4941752, "Description for product 285", 0.0, "product285.jpg", false, 0.0, "Product 285", "", 148.41, "sku-285", "" },
                    { 286, 7, 7, 1725959934.4941757, "Description for product 286", 0.0, "product286.jpg", false, 0.0, "Product 286", "", 877.40999999999997, "sku-286", "" },
                    { 287, 8, 8, 1725959934.4941759, "Description for product 287", 0.0, "product287.jpg", false, 0.0, "Product 287", "", 297.0, "sku-287", "" },
                    { 288, 9, 9, 1725959934.4941761, "Description for product 288", 0.0, "product288.jpg", false, 0.0, "Product 288", "", 668.36000000000001, "sku-288", "" },
                    { 289, 10, 10, 1725959934.4941766, "Description for product 289", 0.0, "product289.jpg", false, 0.0, "Product 289", "", 350.51999999999998, "sku-289", "" },
                    { 290, 11, 11, 1725959934.4941771, "Description for product 290", 0.0, "product290.jpg", false, 0.0, "Product 290", "", 571.97000000000003, "sku-290", "" },
                    { 291, 12, 12, 1725959934.4941773, "Description for product 291", 0.0, "product291.jpg", false, 0.0, "Product 291", "", 218.31, "sku-291", "" },
                    { 292, 13, 13, 1725959934.4941778, "Description for product 292", 0.0, "product292.jpg", false, 0.0, "Product 292", "", 249.31999999999999, "sku-292", "" },
                    { 293, 14, 14, 1725959934.4941783, "Description for product 293", 0.0, "product293.jpg", false, 0.0, "Product 293", "", 537.59000000000003, "sku-293", "" },
                    { 294, 15, 15, 1725959934.4941785, "Description for product 294", 0.0, "product294.jpg", false, 0.0, "Product 294", "", 792.86000000000001, "sku-294", "" },
                    { 295, 16, 16, 1725959934.494179, "Description for product 295", 0.0, "product295.jpg", false, 0.0, "Product 295", "", 907.25999999999999, "sku-295", "" },
                    { 296, 17, 17, 1725959934.4941792, "Description for product 296", 0.0, "product296.jpg", false, 0.0, "Product 296", "", 749.87, "sku-296", "" },
                    { 297, 18, 18, 1725959934.4941795, "Description for product 297", 0.0, "product297.jpg", false, 0.0, "Product 297", "", 399.47000000000003, "sku-297", "" },
                    { 298, 19, 19, 1725959934.4941802, "Description for product 298", 0.0, "product298.jpg", false, 0.0, "Product 298", "", 545.26999999999998, "sku-298", "" },
                    { 299, 20, 20, 1725959934.4941835, "Description for product 299", 0.0, "product299.jpg", false, 0.0, "Product 299", "", 837.88999999999999, "sku-299", "" },
                    { 300, 21, 1, 1725959934.494184, "Description for product 300", 0.0, "product300.jpg", false, 0.0, "Product 300", "", 72.989999999999995, "sku-300", "" },
                    { 301, 22, 2, 1725959934.4941845, "Description for product 301", 0.0, "product301.jpg", false, 0.0, "Product 301", "", 139.28, "sku-301", "" },
                    { 302, 23, 3, 1725959934.4941847, "Description for product 302", 0.0, "product302.jpg", false, 0.0, "Product 302", "", 187.09, "sku-302", "" },
                    { 303, 24, 4, 1725959934.4941852, "Description for product 303", 0.0, "product303.jpg", false, 0.0, "Product 303", "", 687.53999999999996, "sku-303", "" },
                    { 304, 25, 5, 1725959934.4941857, "Description for product 304", 0.0, "product304.jpg", false, 0.0, "Product 304", "", 793.29999999999995, "sku-304", "" },
                    { 305, 26, 6, 1725959934.4941859, "Description for product 305", 0.0, "product305.jpg", false, 0.0, "Product 305", "", 905.5, "sku-305", "" },
                    { 306, 27, 7, 1725959934.4941864, "Description for product 306", 0.0, "product306.jpg", false, 0.0, "Product 306", "", 665.13999999999999, "sku-306", "" },
                    { 307, 28, 8, 1725959934.4941869, "Description for product 307", 0.0, "product307.jpg", false, 0.0, "Product 307", "", 632.91999999999996, "sku-307", "" },
                    { 308, 29, 9, 1725959934.4941871, "Description for product 308", 0.0, "product308.jpg", false, 0.0, "Product 308", "", 426.41000000000003, "sku-308", "" },
                    { 309, 30, 10, 1725959934.4941874, "Description for product 309", 0.0, "product309.jpg", false, 0.0, "Product 309", "", 214.96000000000001, "sku-309", "" },
                    { 310, 31, 11, 1725959934.4941881, "Description for product 310", 0.0, "product310.jpg", false, 0.0, "Product 310", "", 551.60000000000002, "sku-310", "" },
                    { 311, 32, 12, 1725959934.4941883, "Description for product 311", 0.0, "product311.jpg", false, 0.0, "Product 311", "", 47.409999999999997, "sku-311", "" },
                    { 312, 33, 13, 1725959934.4941885, "Description for product 312", 0.0, "product312.jpg", false, 0.0, "Product 312", "", 634.01999999999998, "sku-312", "" },
                    { 313, 34, 14, 1725959934.494189, "Description for product 313", 0.0, "product313.jpg", false, 0.0, "Product 313", "", 571.89999999999998, "sku-313", "" },
                    { 314, 35, 15, 1725959934.4941895, "Description for product 314", 0.0, "product314.jpg", false, 0.0, "Product 314", "", 388.08999999999997, "sku-314", "" },
                    { 315, 36, 16, 1725959934.49419, "Description for product 315", 0.0, "product315.jpg", false, 0.0, "Product 315", "", 497.27999999999997, "sku-315", "" },
                    { 316, 37, 17, 1725959934.4941902, "Description for product 316", 0.0, "product316.jpg", false, 0.0, "Product 316", "", 22.109999999999999, "sku-316", "" },
                    { 317, 38, 18, 1725959934.4941907, "Description for product 317", 0.0, "product317.jpg", false, 0.0, "Product 317", "", 664.79999999999995, "sku-317", "" },
                    { 318, 39, 19, 1725959934.4941933, "Description for product 318", 0.0, "product318.jpg", false, 0.0, "Product 318", "", 904.73000000000002, "sku-318", "" },
                    { 319, 40, 20, 1725959934.4941936, "Description for product 319", 0.0, "product319.jpg", false, 0.0, "Product 319", "", 886.72000000000003, "sku-319", "" },
                    { 320, 1, 1, 1725959934.494194, "Description for product 320", 0.0, "product320.jpg", false, 0.0, "Product 320", "", 387.08999999999997, "sku-320", "" },
                    { 321, 2, 2, 1725959934.4941943, "Description for product 321", 0.0, "product321.jpg", false, 0.0, "Product 321", "", 303.32999999999998, "sku-321", "" },
                    { 322, 3, 3, 1725959934.4941947, "Description for product 322", 0.0, "product322.jpg", false, 0.0, "Product 322", "", 936.60000000000002, "sku-322", "" },
                    { 323, 4, 4, 1725959934.4941952, "Description for product 323", 0.0, "product323.jpg", false, 0.0, "Product 323", "", 782.82000000000005, "sku-323", "" },
                    { 324, 5, 5, 1725959934.4941955, "Description for product 324", 0.0, "product324.jpg", false, 0.0, "Product 324", "", 98.280000000000001, "sku-324", "" },
                    { 325, 6, 6, 1725959934.4941957, "Description for product 325", 0.0, "product325.jpg", false, 0.0, "Product 325", "", 613.19000000000005, "sku-325", "" },
                    { 326, 7, 7, 1725959934.4941964, "Description for product 326", 0.0, "product326.jpg", false, 0.0, "Product 326", "", 31.539999999999999, "sku-326", "" },
                    { 327, 8, 8, 1725959934.4941969, "Description for product 327", 0.0, "product327.jpg", false, 0.0, "Product 327", "", 478.06, "sku-327", "" },
                    { 328, 9, 9, 1725959934.4941969, "Description for product 328", 0.0, "product328.jpg", false, 0.0, "Product 328", "", 769.87, "sku-328", "" },
                    { 329, 10, 10, 1725959934.4941974, "Description for product 329", 0.0, "product329.jpg", false, 0.0, "Product 329", "", 965.20000000000005, "sku-329", "" },
                    { 330, 11, 11, 1725959934.4941981, "Description for product 330", 0.0, "product330.jpg", false, 0.0, "Product 330", "", 570.89999999999998, "sku-330", "" },
                    { 331, 12, 12, 1725959934.4941981, "Description for product 331", 0.0, "product331.jpg", false, 0.0, "Product 331", "", 781.42999999999995, "sku-331", "" },
                    { 332, 13, 13, 1725959934.4941986, "Description for product 332", 0.0, "product332.jpg", false, 0.0, "Product 332", "", 159.28999999999999, "sku-332", "" },
                    { 333, 14, 14, 1725959934.4941988, "Description for product 333", 0.0, "product333.jpg", false, 0.0, "Product 333", "", 439.02999999999997, "sku-333", "" },
                    { 334, 15, 15, 1725959934.4941995, "Description for product 334", 0.0, "product334.jpg", false, 0.0, "Product 334", "", 153.83000000000001, "sku-334", "" },
                    { 335, 16, 16, 1725959934.4941995, "Description for product 335", 0.0, "product335.jpg", false, 0.0, "Product 335", "", 462.06999999999999, "sku-335", "" },
                    { 336, 17, 17, 1725959934.4942, "Description for product 336", 0.0, "product336.jpg", false, 0.0, "Product 336", "", 681.53999999999996, "sku-336", "" },
                    { 337, 18, 18, 1725959934.4942005, "Description for product 337", 0.0, "product337.jpg", false, 0.0, "Product 337", "", 855.07000000000005, "sku-337", "" },
                    { 338, 19, 19, 1725959934.4942031, "Description for product 338", 0.0, "product338.jpg", false, 0.0, "Product 338", "", 778.13, "sku-338", "" },
                    { 339, 20, 20, 1725959934.4942031, "Description for product 339", 0.0, "product339.jpg", false, 0.0, "Product 339", "", 725.69000000000005, "sku-339", "" },
                    { 340, 21, 1, 1725959934.4942036, "Description for product 340", 0.0, "product340.jpg", false, 0.0, "Product 340", "", 193.13, "sku-340", "" },
                    { 341, 22, 2, 1725959934.494204, "Description for product 341", 0.0, "product341.jpg", false, 0.0, "Product 341", "", 508.82999999999998, "sku-341", "" },
                    { 342, 23, 3, 1725959934.4942043, "Description for product 342", 0.0, "product342.jpg", false, 0.0, "Product 342", "", 590.27999999999997, "sku-342", "" },
                    { 343, 24, 4, 1725959934.4942048, "Description for product 343", 0.0, "product343.jpg", false, 0.0, "Product 343", "", 357.47000000000003, "sku-343", "" },
                    { 344, 25, 5, 1725959934.4942052, "Description for product 344", 0.0, "product344.jpg", false, 0.0, "Product 344", "", 529.21000000000004, "sku-344", "" },
                    { 345, 26, 6, 1725959934.4942057, "Description for product 345", 0.0, "product345.jpg", false, 0.0, "Product 345", "", 751.04999999999995, "sku-345", "" },
                    { 346, 27, 7, 1725959934.494206, "Description for product 346", 0.0, "product346.jpg", false, 0.0, "Product 346", "", 146.44, "sku-346", "" },
                    { 347, 28, 8, 1725959934.4942064, "Description for product 347", 0.0, "product347.jpg", false, 0.0, "Product 347", "", 946.34000000000003, "sku-347", "" },
                    { 348, 29, 9, 1725959934.4942069, "Description for product 348", 0.0, "product348.jpg", false, 0.0, "Product 348", "", 176.40000000000001, "sku-348", "" },
                    { 349, 30, 10, 1725959934.4942071, "Description for product 349", 0.0, "product349.jpg", false, 0.0, "Product 349", "", 466.25999999999999, "sku-349", "" },
                    { 350, 31, 11, 1725959934.4942076, "Description for product 350", 0.0, "product350.jpg", false, 0.0, "Product 350", "", 674.94000000000005, "sku-350", "" },
                    { 351, 32, 12, 1725959934.4942081, "Description for product 351", 0.0, "product351.jpg", false, 0.0, "Product 351", "", 97.590000000000003, "sku-351", "" },
                    { 352, 33, 13, 1725959934.4942081, "Description for product 352", 0.0, "product352.jpg", false, 0.0, "Product 352", "", 811.01999999999998, "sku-352", "" },
                    { 353, 34, 14, 1725959934.4942086, "Description for product 353", 0.0, "product353.jpg", false, 0.0, "Product 353", "", 165.24000000000001, "sku-353", "" },
                    { 354, 35, 15, 1725959934.4942091, "Description for product 354", 0.0, "product354.jpg", false, 0.0, "Product 354", "", 213.44999999999999, "sku-354", "" },
                    { 355, 36, 16, 1725959934.4942093, "Description for product 355", 0.0, "product355.jpg", false, 0.0, "Product 355", "", 436.07999999999998, "sku-355", "" },
                    { 356, 37, 17, 1725959934.4942095, "Description for product 356", 0.0, "product356.jpg", false, 0.0, "Product 356", "", 367.64999999999998, "sku-356", "" },
                    { 357, 38, 18, 1725959934.4942119, "Description for product 357", 0.0, "product357.jpg", false, 0.0, "Product 357", "", 10.609999999999999, "sku-357", "" },
                    { 358, 39, 19, 1725959934.4942126, "Description for product 358", 0.0, "product358.jpg", false, 0.0, "Product 358", "", 492.85000000000002, "sku-358", "" },
                    { 359, 40, 20, 1725959934.4942129, "Description for product 359", 0.0, "product359.jpg", false, 0.0, "Product 359", "", 936.19000000000005, "sku-359", "" },
                    { 360, 1, 1, 1725959934.4942131, "Description for product 360", 0.0, "product360.jpg", false, 0.0, "Product 360", "", 712.85000000000002, "sku-360", "" },
                    { 361, 2, 2, 1725959934.4942136, "Description for product 361", 0.0, "product361.jpg", false, 0.0, "Product 361", "", 977.17999999999995, "sku-361", "" },
                    { 362, 3, 3, 1725959934.4942141, "Description for product 362", 0.0, "product362.jpg", false, 0.0, "Product 362", "", 475.31, "sku-362", "" },
                    { 363, 4, 4, 1725959934.4942143, "Description for product 363", 0.0, "product363.jpg", false, 0.0, "Product 363", "", 438.94999999999999, "sku-363", "" },
                    { 364, 5, 5, 1725959934.4942148, "Description for product 364", 0.0, "product364.jpg", false, 0.0, "Product 364", "", 710.07000000000005, "sku-364", "" },
                    { 365, 6, 6, 1725959934.4942153, "Description for product 365", 0.0, "product365.jpg", false, 0.0, "Product 365", "", 95.700000000000003, "sku-365", "" },
                    { 366, 7, 7, 1725959934.4942155, "Description for product 366", 0.0, "product366.jpg", false, 0.0, "Product 366", "", 168.02000000000001, "sku-366", "" },
                    { 367, 8, 8, 1725959934.494216, "Description for product 367", 0.0, "product367.jpg", false, 0.0, "Product 367", "", 269.64999999999998, "sku-367", "" },
                    { 368, 9, 9, 1725959934.4942164, "Description for product 368", 0.0, "product368.jpg", false, 0.0, "Product 368", "", 415.01999999999998, "sku-368", "" },
                    { 369, 10, 10, 1725959934.4942169, "Description for product 369", 0.0, "product369.jpg", false, 0.0, "Product 369", "", 143.77000000000001, "sku-369", "" },
                    { 370, 11, 11, 1725959934.4942172, "Description for product 370", 0.0, "product370.jpg", false, 0.0, "Product 370", "", 563.15999999999997, "sku-370", "" },
                    { 371, 12, 12, 1725959934.4942176, "Description for product 371", 0.0, "product371.jpg", false, 0.0, "Product 371", "", 584.42999999999995, "sku-371", "" },
                    { 372, 13, 13, 1725959934.4942181, "Description for product 372", 0.0, "product372.jpg", false, 0.0, "Product 372", "", 350.13999999999999, "sku-372", "" },
                    { 373, 14, 14, 1725959934.4942181, "Description for product 373", 0.0, "product373.jpg", false, 0.0, "Product 373", "", 170.69999999999999, "sku-373", "" },
                    { 374, 15, 15, 1725959934.4942188, "Description for product 374", 0.0, "product374.jpg", false, 0.0, "Product 374", "", 100.28, "sku-374", "" },
                    { 375, 16, 16, 1725959934.4942193, "Description for product 375", 0.0, "product375.jpg", false, 0.0, "Product 375", "", 343.33999999999997, "sku-375", "" },
                    { 376, 17, 17, 1725959934.4942214, "Description for product 376", 0.0, "product376.jpg", false, 0.0, "Product 376", "", 458.80000000000001, "sku-376", "" },
                    { 377, 18, 18, 1725959934.4942217, "Description for product 377", 0.0, "product377.jpg", false, 0.0, "Product 377", "", 21.120000000000001, "sku-377", "" },
                    { 378, 19, 19, 1725959934.4942222, "Description for product 378", 0.0, "product378.jpg", false, 0.0, "Product 378", "", 235.90000000000001, "sku-378", "" },
                    { 379, 20, 20, 1725959934.4942224, "Description for product 379", 0.0, "product379.jpg", false, 0.0, "Product 379", "", 969.38999999999999, "sku-379", "" },
                    { 380, 21, 1, 1725959934.4942229, "Description for product 380", 0.0, "product380.jpg", false, 0.0, "Product 380", "", 135.58000000000001, "sku-380", "" },
                    { 381, 22, 2, 1725959934.4942231, "Description for product 381", 0.0, "product381.jpg", false, 0.0, "Product 381", "", 904.67999999999995, "sku-381", "" },
                    { 382, 23, 3, 1725959934.4942236, "Description for product 382", 0.0, "product382.jpg", false, 0.0, "Product 382", "", 676.36000000000001, "sku-382", "" },
                    { 383, 24, 4, 1725959934.4942241, "Description for product 383", 0.0, "product383.jpg", false, 0.0, "Product 383", "", 526.39999999999998, "sku-383", "" },
                    { 384, 25, 5, 1725959934.4942243, "Description for product 384", 0.0, "product384.jpg", false, 0.0, "Product 384", "", 492.87, "sku-384", "" },
                    { 385, 26, 6, 1725959934.4942248, "Description for product 385", 0.0, "product385.jpg", false, 0.0, "Product 385", "", 204.72999999999999, "sku-385", "" },
                    { 386, 27, 7, 1725959934.4942253, "Description for product 386", 0.0, "product386.jpg", false, 0.0, "Product 386", "", 347.88999999999999, "sku-386", "" },
                    { 387, 28, 8, 1725959934.4942255, "Description for product 387", 0.0, "product387.jpg", false, 0.0, "Product 387", "", 737.27999999999997, "sku-387", "" },
                    { 388, 29, 9, 1725959934.494226, "Description for product 388", 0.0, "product388.jpg", false, 0.0, "Product 388", "", 101.8, "sku-388", "" },
                    { 389, 30, 10, 1725959934.4942262, "Description for product 389", 0.0, "product389.jpg", false, 0.0, "Product 389", "", 394.37, "sku-389", "" },
                    { 390, 31, 11, 1725959934.4942267, "Description for product 390", 0.0, "product390.jpg", false, 0.0, "Product 390", "", 93.75, "sku-390", "" },
                    { 391, 32, 12, 1725959934.4942269, "Description for product 391", 0.0, "product391.jpg", false, 0.0, "Product 391", "", 81.019999999999996, "sku-391", "" },
                    { 392, 33, 13, 1725959934.4942274, "Description for product 392", 0.0, "product392.jpg", false, 0.0, "Product 392", "", 179.86000000000001, "sku-392", "" },
                    { 393, 34, 14, 1725959934.4942279, "Description for product 393", 0.0, "product393.jpg", false, 0.0, "Product 393", "", 336.88, "sku-393", "" },
                    { 394, 35, 15, 1725959934.4942284, "Description for product 394", 0.0, "product394.jpg", false, 0.0, "Product 394", "", 211.68000000000001, "sku-394", "" },
                    { 395, 36, 16, 1725959934.4942286, "Description for product 395", 0.0, "product395.jpg", false, 0.0, "Product 395", "", 531.27999999999997, "sku-395", "" },
                    { 396, 37, 17, 1725959934.4942312, "Description for product 396", 0.0, "product396.jpg", false, 0.0, "Product 396", "", 35.439999999999998, "sku-396", "" },
                    { 397, 38, 18, 1725959934.4942315, "Description for product 397", 0.0, "product397.jpg", false, 0.0, "Product 397", "", 53.590000000000003, "sku-397", "" },
                    { 398, 39, 19, 1725959934.4942319, "Description for product 398", 0.0, "product398.jpg", false, 0.0, "Product 398", "", 893.20000000000005, "sku-398", "" },
                    { 399, 40, 20, 1725959934.4942324, "Description for product 399", 0.0, "product399.jpg", false, 0.0, "Product 399", "", 796.12, "sku-399", "" },
                    { 400, 1, 1, 1725959934.4942329, "Description for product 400", 0.0, "product400.jpg", false, 0.0, "Product 400", "", 466.5, "sku-400", "" }
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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 400);

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
        }
    }
}
