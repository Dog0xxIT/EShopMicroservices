using EShop.Application.Constants;
using EShop.Application.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.SeedData
{
    internal static class Seeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region IdentityRole

            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>
                {
                    Id = 1,
                    Name = RolesConstant.Administrator,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.Administrator.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 2,
                    Name = RolesConstant.Customer,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.Customer.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 3,
                    Name = RolesConstant.SalesManager,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.SalesManager.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 4,
                    Name = RolesConstant.StoreManager,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.StoreManager.ToUpper(),
                },
                new IdentityRole<int>
                {
                    Id = 5,
                    Name = RolesConstant.SystemAdministrator,
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    NormalizedName = RolesConstant.SystemAdministrator.ToUpper(),
                }
            );

            #endregion

            #region Category

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Computers & Office", Code = "COMP", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 15v5m-3 0h6M4 11h16M5 15h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v9a1 1 0 0 0 1 1Z\"></path>\r\n        </svg>" },

                new Category { Id = 2, Name = "Collectibles & Toys", Code = "COLL", Icon = "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M16.872 9.687 20 6.56 17.44 4 4 17.44 6.56 20 16.873 9.687Zm0 0-2.56-2.56M6 7v2m0 0v2m0-2H4m2 0h2m7 7v2m0 0v2m0-2h-2m2 0h2M8 4h.01v.01H8V4Zm2 2h.01v.01H10V6Zm2-2h.01v.01H12V4Zm8 8h.01v.01H20V12Zm-2 2h.01v.01H18V14Zm2 2h.01v.01H20V16Z\"></path>\r\n        </svg>" },

                new Category { Id = 3, Name = "Books", Code = "BOOK", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M5 19V4a1 1 0 0 1 1-1h12a1 1 0 0 1 1 1v13H7a2 2 0 0 0-2 2Zm0 0a2 2 0 0 0 2 2h12M9 3v14m7 0v4\"></path>\r\n        </svg>" },

                new Category { Id = 4, Name = "Fashion & Clothes", Code = "FASH", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 10V6a3 3 0 0 1 3-3v0a3 3 0 0 1 3 3v4m3-2 .917 11.923A1 1 0 0 1 17.92 21H6.08a1 1 0 0 1-.997-1.077L6 8h12Z\"></path>\r\n        </svg>" },
                new Category { Id = 5, Name = "Electronics", Code = "ELEC", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 9a3 3 0 0 1 3-3m-2 15h4m0-3c0-4.1 4-4.9 4-9A6 6 0 1 0 6 9c0 4 4 5 4 9h4Z\"></path>\r\n        </svg>" },

                new Category { Id = 6, Name = "Food & Groceries", Code = "FOOD", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M6 12c.263 0 .524-.06.767-.175a2 2 0 0 0 .65-.491c.186-.21.333-.46.433-.734.1-.274.15-.568.15-.864a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 12 9.736a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 16 9.736c0 .295.052.588.152.861s.248.521.434.73a2 2 0 0 0 .649.488 1.809 1.809 0 0 0 1.53 0 2.03 2.03 0 0 0 .65-.488c.185-.209.332-.457.433-.73.1-.273.152-.566.152-.861 0-.974-1.108-3.85-1.618-5.121A.983.983 0 0 0 17.466 4H6.456a.986.986 0 0 0-.93.645C5.045 5.962 4 8.905 4 9.736c.023.59.241 1.148.611 1.567.37.418.865.667 1.389.697Zm0 0c.328 0 .651-.091.94-.266A2.1 2.1 0 0 0 7.66 11h.681a2.1 2.1 0 0 0 .718.734c.29.175.613.266.942.266.328 0 .651-.091.94-.266.29-.174.537-.427.719-.734h.681a2.1 2.1 0 0 0 .719.734c.289.175.612.266.94.266.329 0 .652-.091.942-.266.29-.174.536-.427.718-.734h.681c.183.307.43.56.719.734.29.174.613.266.941.266a1.819 1.819 0 0 0 1.06-.351M6 12a1.766 1.766 0 0 1-1.163-.476M5 12v7a1 1 0 0 0 1 1h2v-5h3v5h7a1 1 0 0 0 1-1v-7m-5 3v2h2v-2h-2Z\"></path>\r\n        </svg>" },

                new Category { Id = 7, Name = "Music", Code = "MUSC", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n       <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 9a3 3 0 0 1 3-3m-2 15h4m0-3c0-4.1 4-4.9 4-9A6 6 0 1 0 6 9c0 4 4 5 4 9h4Z\"></path>\r\n   </svg>" },

                new Category { Id = 8, Name = "TVs & Projectors", Code = "TVPJ", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n    <path stroke=\"currentColor\"\r\n          stroke-linecap=\"round\"\r\n          stroke-linejoin=\"round\"\r\n          stroke-width=\"2\"\r\n          d=\"M6 12c.263 0 .524-.06.767-.175a2 2 0 0 0 .65-.491c.186-.21.333-.46.433-.734.1-.274.15-.568.15-.864a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 12 9.736a2.4 2.4 0 0 0 .586 1.591c.375.422.884.659 1.414.659.53 0 1.04-.237 1.414-.659A2.4 2.4 0 0 0 16 9.736c0 .295.052.588.152.861s.248.521.434.73a2 2 0 0 0 .649.488 1.809 1.809 0 0 0 1.53 0 2.03 2.03 0 0 0 .65-.488c.185-.209.332-.457.433-.73.1-.273.152-.566.152-.861 0-.974-1.108-3.85-1.618-5.121A.983.983 0 0 0 17.466 4H6.456a.986.986 0 0 0-.93.645C5.045 5.962 4 8.905 4 9.736c.023.59.241 1.148.611 1.567.37.418.865.667 1.389.697Zm0 0c.328 0 .651-.091.94-.266A2.1 2.1 0 0 0 7.66 11h.681a2.1 2.1 0 0 0 .718.734c.29.175.613.266.942.266.328 0 .651-.091.94-.266.29-.174.537-.427.719-.734h.681a2.1 2.1 0 0 0 .719.734c.289.175.612.266.94.266.329 0 .652-.091.942-.266.29-.174.536-.427.718-.734h.681c.183.307.43.56.719.734.29.174.613.266.941.266a1.819 1.819 0 0 0 1.06-.351M6 12a1.766 1.766 0 0 1-1.163-.476M5 12v7a1 1 0 0 0 1 1h2v-5h3v5h7a1 1 0 0 0 1-1v-7m-5 3v2h2v-2h-2Z\"></path>\r\n</svg>" },

                new Category { Id = 9, Name = "Health & Beauty", Code = "HEAL", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M9 16H5a1 1 0 0 1-1-1V5a1 1 0 0 1 1-1h14a1 1 0 0 1 1 1v1M9 12H4m8 8V9h8v11h-8Zm0 0H9m8-4a1 1 0 1 0-2 0 1 1 0 0 0 2 0Z\"></path>\r\n  </svg>" },

                new Category { Id = 10, Name = "Home Air Quality", Code = "HAIR", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15.041 13.862A4.999 4.999 0 0 1 17 17.831V21M7 3v3.169a5 5 0 0 0 1.891 3.916M17 3v3.169a5 5 0 0 1-2.428 4.288l-5.144 3.086A5 5 0 0 0 7 17.831V21M7 5h10M7.399 8h9.252M8 16h8.652M7 19h10\"></path>\r\n </svg>" },

                new Category { Id = 11, Name = "Gaming Consoles", Code = "GAMC", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"m4 12 8-8 8 8M6 10.5V19a1 1 0 0 0 1 1h3v-3a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1v3h3a1 1 0 0 0 1-1v-8.5\"></path>\r\n </svg>" },

                new Category { Id = 12, Name = "Car & Motorbike Accessories", Code = "CAR", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M14.079 6.839a3 3 0 0 0-4.255.1M13 20h1.083A3.916 3.916 0 0 0 18 16.083V9A6 6 0 1 0 6 9v7m7 4v-1a1 1 0 0 0-1-1h-1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1h1a1 1 0 0 0 1-1Zm-7-4v-6H5a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h1Zm12-6h1a2 2 0 0 1 2 2v2a2 2 0 0 1-2 2h-1v-6Z\" />\r\n </svg>" },

                new Category { Id = 13, Name = "Photo & Video Equipment", Code = "PHOT", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M13 7h6l2 4m-8-4v8m0-8V6a1 1 0 0 0-1-1H4a1 1 0 0 0-1 1v9h2m8 0H9m4 0h2m4 0h2v-4m0 0h-5m3.5 5.5a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0Zm-10 0a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0Z\"></path>\r\n </svg>" },

                new Category { Id = 14, Name = "Security & Wi-Fi Devices", Code = "SEC", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 18V8a1 1 0 0 1 1-1h1.5l1.707-1.707A1 1 0 0 1 8.914 5h6.172a1 1 0 0 1 .707.293L17.5 7H19a1 1 0 0 1 1 1v10a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1Z\"></path>\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15 12a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z\"></path>\r\n  </svg>" },

                new Category { Id = 15, Name = "Computer Peripherals", Code = "PERI", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n     <path stroke=\"currentColor\"\r\n           stroke-linecap=\"round\"\r\n           stroke-linejoin=\"round\"\r\n           stroke-width=\"2\"\r\n           d=\"M21 12a28.076 28.076 0 0 1-1.091 9M7.231 4.37a8.994 8.994 0 0 1 12.88 3.73M2.958 15S3 14.577 3 12a8.949 8.949 0 0 1 1.735-5.307m12.84 3.088A5.98 5.98 0 0 1 18 12a30 30 0 0 1-.464 6.232M6 12a6 6 0 0 1 9.352-4.974M4 21a5.964 5.964 0 0 1 1.01-3.328 5.15 5.15 0 0 0 .786-1.926m8.66 2.486a13.96 13.96 0 0 1-.962 2.683M7.5 19.336C9 17.092 9 14.845 9 12a3 3 0 1 1 6 0c0 .749 0 1.521-.031 2.311M12 12c0 3 0 6-2 9\" />\r\n </svg>" },

                new Category { Id = 16, Name = "Phone Accessories", Code = "PHON", Icon = " <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 8v4l3 3m6-3a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z\" />\r\n        </svg>" },

                new Category { Id = 17, Name = "Watches", Code = "WATCH", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n      <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 5a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1V5Zm16 14a1 1 0 0 1-1 1h-4a1 1 0 0 1-1-1v-2a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v2ZM4 13a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v6a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1v-6Zm16-2a1 1 0 0 1-1 1h-4a1 1 0 0 1-1-1V5a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v6Z\" />\r\n  </svg>" },

                new Category { Id = 18, Name = "Printers", Code = "PRNT", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M16.444 18H19a1 1 0 0 0 1-1v-5a1 1 0 0 0-1-1H5a1 1 0 0 0-1 1v5a1 1 0 0 0 1 1h2.556M17 11V5a1 1 0 0 0-1-1H8a1 1 0 0 0-1 1v6h10ZM7 15h10v4a1 1 0 0 1-1 1H8a1 1 0 0 1-1-1v-4Z\" />\r\n        </svg>" },

                new Category { Id = 19, Name = "Projectors", Code = "PROJ", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M19 4H5a1 1 0 0 0-1 1v14a1 1 0 0 0 1 1h14a1 1 0 0 0 1-1V5a1 1 0 0 0-1-1Zm0 0-4 4m5 0H4m1 0 4-4m1 4 4-4m-4 7v6l4-3-4-3Z\" />\r\n        </svg>" },

                new Category { Id = 20, Name = "Skin Care Products", Code = "SKIN", Icon = "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12.01 6.001C6.5 1 1 8 5.782 13.001L12.011 20l6.23-7C23 8 17.5 1 12.01 6.002Z\" />\r\n        </svg>" },

                new Category { Id = 21, Name = "Photo & Video", Code = "PHOT", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M4 18V8a1 1 0 0 1 1-1h1.5l1.707-1.707A1 1 0 0 1 8.914 5h6.172a1 1 0 0 1 .707.293L17.5 7H19a1 1 0 0 1 1 1v10a1 1 0 0 1-1 1H5a1 1 0 0 1-1-1Z\"></path>\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M15 12a3 3 0 1 1-6 0 3 3 0 0 1 6 0Z\"></path>\r\n        </svg>" },

                new Category { Id = 22, Name = "Office Supplies", Code = "OFFS", Icon = "  <svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M10 12v1h4v-1m4 7H6a1 1 0 0 1-1-1V9h14v9a1 1 0 0 1-1 1ZM4 5h16a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V6a1 1 0 0 1 1-1Z\" />\r\n        </svg>" },

                new Category { Id = 23, Name = "Sports & Outdoors", Code = "S&O", Icon = "<svg class=\"me-2 h-4 w-4 text-gray-900 shrink-0 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n    <path stroke=\"currentColor\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M10 12v1h4v-1m4 7H6a1 1 0 0 1-1-1V9h14v9a1 1 0 0 1-1 1ZM4 5h16a1 1 0 0 1 1 1v2a1 1 0 0 1-1 1H4a1 1 0 0 1-1-1V6a1 1 0 0 1 1-1Z\" />\r\n</svg>" },

                new Category { Id = 24, Name = "Painting & Hobby", Code = "P&H", Icon = "<svg class=\"me-2 h-4 w-4 shrink-0 text-gray-900 dark:text-white\" aria-hidden=\"true\" xmlns=\"http://www.w3.org/2000/svg\" width=\"24\" height=\"24\" fill=\"none\" viewBox=\"0 0 24 24\">\r\n          <path stroke=\"currentColor\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" d=\"M12 7h.01m3.486 1.513h.01m-6.978 0h.01M6.99 12H7m9 4h2.706a1.957 1.957 0 0 0 1.883-1.325A9 9 0 1 0 3.043 12.89 9.1 9.1 0 0 0 8.2 20.1a8.62 8.62 0 0 0 3.769.9 2.013 2.013 0 0 0 2.03-2v-.857A2.036 2.036 0 0 1 16 16Z\"></path>\r\n        </svg>" }
            );

            #endregion

            #region Brand

            modelBuilder.Entity<Brand>().HasData(
                 new Brand { Id = 1, Name = "Apple", Code = "APPLE", AvatarLink = "" },
                 new Brand { Id = 2, Name = "Samsung", Code = "SAMSUNG", AvatarLink = "" },
                 new Brand { Id = 3, Name = "Microsoft", Code = "MICROSOFT", AvatarLink = "" },
                 new Brand { Id = 4, Name = "Google", Code = "GOOGLE", AvatarLink = "" },
                 new Brand { Id = 5, Name = "Amazon", Code = "AMAZON", AvatarLink = "" },
                 new Brand { Id = 6, Name = "Facebook", Code = "FACEBOOK", AvatarLink = "" },
                 new Brand { Id = 7, Name = "Intel", Code = "INTEL", AvatarLink = "" },
                 new Brand { Id = 8, Name = "IBM", Code = "IBM", AvatarLink = "" },
                 new Brand { Id = 9, Name = "Sony", Code = "SONY", AvatarLink = "" },
                 new Brand { Id = 10, Name = "Dell", Code = "DELL", AvatarLink = "" },
                 new Brand { Id = 11, Name = "HP", Code = "HP", AvatarLink = "" },
                 new Brand { Id = 12, Name = "LG", Code = "LG", AvatarLink = "" },
                 new Brand { Id = 13, Name = "Huawei", Code = "HUAWEI", AvatarLink = "" },
                 new Brand { Id = 14, Name = "Cisco", Code = "CISCO", AvatarLink = "" },
                 new Brand { Id = 15, Name = "Oracle", Code = "ORACLE", AvatarLink = "" },
                 new Brand { Id = 16, Name = "Nvidia", Code = "NVIDIA", AvatarLink = "" },
                 new Brand { Id = 17, Name = "AMD", Code = "AMD", AvatarLink = "" },
                 new Brand { Id = 18, Name = "Lenovo", Code = "LENOVO", AvatarLink = "" },
                 new Brand { Id = 19, Name = "Asus", Code = "ASUS", AvatarLink = "" },
                 new Brand { Id = 20, Name = "Acer", Code = "ACER", AvatarLink = "" },
                 new Brand { Id = 21, Name = "Nike", Code = "NIKE", AvatarLink = "" },
                 new Brand { Id = 22, Name = "Adidas", Code = "ADIDAS", AvatarLink = "" },
                 new Brand { Id = 23, Name = "Puma", Code = "PUMA", AvatarLink = "" },
                 new Brand { Id = 24, Name = "Under Armour", Code = "UA", AvatarLink = "" },
                 new Brand { Id = 25, Name = "Reebok", Code = "REEBOK", AvatarLink = "" },
                 new Brand { Id = 26, Name = "New Balance", Code = "NB", AvatarLink = "" },
                 new Brand { Id = 27, Name = "Asics", Code = "ASICS", AvatarLink = "" },
                 new Brand { Id = 28, Name = "Converse", Code = "CONV", AvatarLink = "" },
                 new Brand { Id = 29, Name = "Vans", Code = "VANS", AvatarLink = "" },
                 new Brand { Id = 30, Name = "Sketchers", Code = "SKETCH", AvatarLink = "" },
                 new Brand { Id = 31, Name = "Fila", Code = "FILA", AvatarLink = "" },
                 new Brand { Id = 32, Name = "H&M", Code = "HM", AvatarLink = "" },
                 new Brand { Id = 33, Name = "Zara", Code = "ZARA", AvatarLink = "" },
                 new Brand { Id = 34, Name = "Uniqlo", Code = "UNIQLO", AvatarLink = "" },
                 new Brand { Id = 35, Name = "Gucci", Code = "GUCCI", AvatarLink = "" },
                 new Brand { Id = 36, Name = "Louis Vuitton", Code = "LV", AvatarLink = "" },
                 new Brand { Id = 37, Name = "Prada", Code = "PRADA", AvatarLink = "" },
                 new Brand { Id = 38, Name = "Chanel", Code = "CHANEL", AvatarLink = "" },
                 new Brand { Id = 39, Name = "Hermès", Code = "HERMES", AvatarLink = "" },
                 new Brand { Id = 40, Name = "Burberry", Code = "BURBERRY", AvatarLink = "" });
            #endregion

            #region Product

            var products = new List<Product>();
            for (var i = 1; i <= 400; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = Math.Round(new Random().NextDouble() * 1000, 2),
                    PictureFileName = $"product{i}.jpg",
                    CategoryId = (i % 20) + 1, // Assuming you have 20 categories
                    BrandId = (i % 40) + 1,    // Assuming you have 40 brands
                    AvailableStock = new Random().Next(1, 100),
                    RestockThreshold = new Random().Next(1, 20),
                    MaxStockThreshold = new Random().Next(20, 200)
                });
            }

            modelBuilder.Entity<Product>().HasData(products);

            #endregion
        }
    }
}
