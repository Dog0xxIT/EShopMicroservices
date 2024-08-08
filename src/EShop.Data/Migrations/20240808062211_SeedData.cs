using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EShop.Data.Migrations
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
                    { 1, "0a1092a6-c53c-41e2-af75-f4e95bba5538", "Administrator", "ADMINISTRATOR" },
                    { 2, "27f50e08-77f9-4b45-9323-77319488c260", "Customer", "CUSTOMER" },
                    { 3, "bd2fc55b-90eb-4537-9bca-82b7b11ac9a7", "SalesManager", "SALESMANAGER" },
                    { 4, "70415097-d0b7-449b-a146-d0d7af7ddd0d", "StoreManager", "STOREMANAGER" },
                    { 5, "f66f4161-aef0-42a3-930b-c2fafaff9ea8", "SystemAdministrator", "SYSTEMADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "APPLE", 1723098131.318166, false, 0.0, "Apple" },
                    { 2, "SAMSUNG", 1723098131.318166, false, 0.0, "Samsung" },
                    { 3, "MICROSOFT", 1723098131.3181663, false, 0.0, "Microsoft" },
                    { 4, "GOOGLE", 1723098131.3181665, false, 0.0, "Google" },
                    { 5, "AMAZON", 1723098131.3181665, false, 0.0, "Amazon" },
                    { 6, "FACEBOOK", 1723098131.3181665, false, 0.0, "Facebook" },
                    { 7, "INTEL", 1723098131.3181665, false, 0.0, "Intel" },
                    { 8, "IBM", 1723098131.3181665, false, 0.0, "IBM" },
                    { 9, "SONY", 1723098131.3181667, false, 0.0, "Sony" },
                    { 10, "DELL", 1723098131.3181667, false, 0.0, "Dell" },
                    { 11, "HP", 1723098131.3181667, false, 0.0, "HP" },
                    { 12, "LG", 1723098131.3181667, false, 0.0, "LG" },
                    { 13, "HUAWEI", 1723098131.318167, false, 0.0, "Huawei" },
                    { 14, "CISCO", 1723098131.3181672, false, 0.0, "Cisco" },
                    { 15, "ORACLE", 1723098131.3181672, false, 0.0, "Oracle" },
                    { 16, "NVIDIA", 1723098131.3181672, false, 0.0, "Nvidia" },
                    { 17, "AMD", 1723098131.3181674, false, 0.0, "AMD" },
                    { 18, "LENOVO", 1723098131.3181674, false, 0.0, "Lenovo" },
                    { 19, "ASUS", 1723098131.3181677, false, 0.0, "Asus" },
                    { 20, "ACER", 1723098131.3181677, false, 0.0, "Acer" },
                    { 21, "NIKE", 1723098131.3181677, false, 0.0, "Nike" },
                    { 22, "ADIDAS", 1723098131.3181677, false, 0.0, "Adidas" },
                    { 23, "PUMA", 1723098131.3181679, false, 0.0, "Puma" },
                    { 24, "UA", 1723098131.3181679, false, 0.0, "Under Armour" },
                    { 25, "REEBOK", 1723098131.3181679, false, 0.0, "Reebok" },
                    { 26, "NB", 1723098131.3181679, false, 0.0, "New Balance" },
                    { 27, "ASICS", 1723098131.3181682, false, 0.0, "Asics" },
                    { 28, "CONV", 1723098131.3181684, false, 0.0, "Converse" },
                    { 29, "VANS", 1723098131.3181684, false, 0.0, "Vans" },
                    { 30, "SKETCH", 1723098131.3181684, false, 0.0, "Sketchers" },
                    { 31, "FILA", 1723098131.3181684, false, 0.0, "Fila" },
                    { 32, "HM", 1723098131.3181686, false, 0.0, "H&M" },
                    { 33, "ZARA", 1723098131.3181689, false, 0.0, "Zara" },
                    { 34, "UNIQLO", 1723098131.3181689, false, 0.0, "Uniqlo" },
                    { 35, "GUCCI", 1723098131.3181689, false, 0.0, "Gucci" },
                    { 36, "LV", 1723098131.3181689, false, 0.0, "Louis Vuitton" },
                    { 37, "PRADA", 1723098131.3181691, false, 0.0, "Prada" },
                    { 38, "CHANEL", 1723098131.3181691, false, 0.0, "Chanel" },
                    { 39, "HERMES", 1723098131.3181691, false, 0.0, "Hermès" },
                    { 40, "BURBERRY", 1723098131.3181691, false, 0.0, "Burberry" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Code", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, "ELEC", 1723098131.3181548, false, 0.0, "Electronics" },
                    { 2, "BOOK", 1723098131.3181555, false, 0.0, "Books" },
                    { 3, "CLTH", 1723098131.3181558, false, 0.0, "Clothing" },
                    { 4, "HOME", 1723098131.3181598, false, 0.0, "Home and Kitchen" },
                    { 5, "SPORT", 1723098131.3181601, false, 0.0, "Sports and Outdoors" },
                    { 6, "BEAUTY", 1723098131.3181601, false, 0.0, "Beauty and Personal Care" },
                    { 7, "TOYS", 1723098131.3181603, false, 0.0, "Toys and Games" },
                    { 8, "AUTO", 1723098131.3181603, false, 0.0, "Automotive" },
                    { 9, "GROCERY", 1723098131.3181603, false, 0.0, "Grocery and Gourmet Food" },
                    { 10, "HEALTH", 1723098131.3181603, false, 0.0, "Health and Household" },
                    { 11, "INDUST", 1723098131.3181603, false, 0.0, "Industrial and Scientific" },
                    { 12, "PET", 1723098131.3181603, false, 0.0, "Pet Supplies" },
                    { 13, "OFFICE", 1723098131.3181605, false, 0.0, "Office Products" },
                    { 14, "SOFT", 1723098131.3181608, false, 0.0, "Software" },
                    { 15, "GARDEN", 1723098131.3181608, false, 0.0, "Garden and Outdoor" },
                    { 16, "TOOLS", 1723098131.3181608, false, 0.0, "Tools and Home Improvement" },
                    { 17, "BABY", 1723098131.3181608, false, 0.0, "Baby" },
                    { 18, "MUSIC", 1723098131.318161, false, 0.0, "Musical Instruments" },
                    { 19, "ARTS", 1723098131.3181612, false, 0.0, "Arts, Crafts, and Sewing" },
                    { 20, "JEWEL", 1723098131.3181612, false, 0.0, "Jewelry" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "BrandId", "CategoryId", "Created", "Description", "IsDeleted", "LastModified", "MaxStockThreshold", "Name", "PictureFileName", "Price", "RestockThreshold" },
                values: new object[,]
                {
                    { 1, 77, 2, 2, 1723098131.3181725, "Description for product 1", false, 0.0, 198, "Product 1", "product1.jpg", 313.81, 17 },
                    { 2, 63, 3, 3, 1723098131.3181808, "Description for product 2", false, 0.0, 32, "Product 2", "product2.jpg", 46.759999999999998, 10 },
                    { 3, 72, 4, 4, 1723098131.3181815, "Description for product 3", false, 0.0, 44, "Product 3", "product3.jpg", 422.41000000000003, 7 },
                    { 4, 14, 5, 5, 1723098131.3181825, "Description for product 4", false, 0.0, 81, "Product 4", "product4.jpg", 885.42999999999995, 18 },
                    { 5, 1, 6, 6, 1723098131.3181829, "Description for product 5", false, 0.0, 114, "Product 5", "product5.jpg", 759.02999999999997, 5 },
                    { 6, 40, 7, 7, 1723098131.3181872, "Description for product 6", false, 0.0, 167, "Product 6", "product6.jpg", 476.50999999999999, 12 },
                    { 7, 91, 8, 8, 1723098131.318188, "Description for product 7", false, 0.0, 165, "Product 7", "product7.jpg", 470.38999999999999, 18 },
                    { 8, 18, 9, 9, 1723098131.3181887, "Description for product 8", false, 0.0, 144, "Product 8", "product8.jpg", 383.37, 18 },
                    { 9, 55, 10, 10, 1723098131.3181891, "Description for product 9", false, 0.0, 169, "Product 9", "product9.jpg", 491.35000000000002, 10 },
                    { 10, 42, 11, 11, 1723098131.3181901, "Description for product 10", false, 0.0, 55, "Product 10", "product10.jpg", 727.0, 6 },
                    { 11, 36, 12, 12, 1723098131.3181908, "Description for product 11", false, 0.0, 107, "Product 11", "product11.jpg", 262.08999999999997, 17 },
                    { 12, 19, 13, 13, 1723098131.3181913, "Description for product 12", false, 0.0, 129, "Product 12", "product12.jpg", 218.99000000000001, 8 },
                    { 13, 7, 14, 14, 1723098131.318192, "Description for product 13", false, 0.0, 30, "Product 13", "product13.jpg", 938.38999999999999, 2 },
                    { 14, 87, 15, 15, 1723098131.3181927, "Description for product 14", false, 0.0, 175, "Product 14", "product14.jpg", 241.06, 3 },
                    { 15, 98, 16, 16, 1723098131.3181932, "Description for product 15", false, 0.0, 60, "Product 15", "product15.jpg", 936.50999999999999, 16 },
                    { 16, 23, 17, 17, 1723098131.3181939, "Description for product 16", false, 0.0, 98, "Product 16", "product16.jpg", 899.85000000000002, 15 },
                    { 17, 49, 18, 18, 1723098131.3181946, "Description for product 17", false, 0.0, 58, "Product 17", "product17.jpg", 467.13999999999999, 19 },
                    { 18, 56, 19, 19, 1723098131.3181951, "Description for product 18", false, 0.0, 131, "Product 18", "product18.jpg", 105.48999999999999, 3 },
                    { 19, 32, 20, 20, 1723098131.3181975, "Description for product 19", false, 0.0, 32, "Product 19", "product19.jpg", 841.33000000000004, 16 },
                    { 20, 40, 21, 1, 1723098131.3181984, "Description for product 20", false, 0.0, 183, "Product 20", "product20.jpg", 961.71000000000004, 14 },
                    { 21, 17, 22, 2, 1723098131.3181989, "Description for product 21", false, 0.0, 96, "Product 21", "product21.jpg", 838.27999999999997, 7 },
                    { 22, 1, 23, 3, 1723098131.3181996, "Description for product 22", false, 0.0, 62, "Product 22", "product22.jpg", 407.31999999999999, 10 },
                    { 23, 2, 24, 4, 1723098131.3182001, "Description for product 23", false, 0.0, 98, "Product 23", "product23.jpg", 955.42999999999995, 8 },
                    { 24, 37, 25, 5, 1723098131.3182008, "Description for product 24", false, 0.0, 167, "Product 24", "product24.jpg", 569.03999999999996, 4 },
                    { 25, 49, 26, 6, 1723098131.3182015, "Description for product 25", false, 0.0, 117, "Product 25", "product25.jpg", 808.25999999999999, 12 },
                    { 26, 29, 27, 7, 1723098131.318202, "Description for product 26", false, 0.0, 155, "Product 26", "product26.jpg", 140.31999999999999, 9 },
                    { 27, 52, 28, 8, 1723098131.3182027, "Description for product 27", false, 0.0, 176, "Product 27", "product27.jpg", 693.88, 16 },
                    { 28, 42, 29, 9, 1723098131.3182032, "Description for product 28", false, 0.0, 178, "Product 28", "product28.jpg", 352.22000000000003, 16 },
                    { 29, 57, 30, 10, 1723098131.3182039, "Description for product 29", false, 0.0, 24, "Product 29", "product29.jpg", 411.55000000000001, 18 },
                    { 30, 63, 31, 11, 1723098131.3182046, "Description for product 30", false, 0.0, 44, "Product 30", "product30.jpg", 480.89999999999998, 9 },
                    { 31, 21, 32, 12, 1723098131.3182051, "Description for product 31", false, 0.0, 146, "Product 31", "product31.jpg", 180.81, 5 },
                    { 32, 21, 33, 13, 1723098131.3182058, "Description for product 32", false, 0.0, 111, "Product 32", "product32.jpg", 722.79999999999995, 2 },
                    { 33, 42, 34, 14, 1723098131.3182104, "Description for product 33", false, 0.0, 197, "Product 33", "product33.jpg", 295.45999999999998, 10 },
                    { 34, 98, 35, 15, 1723098131.3182113, "Description for product 34", false, 0.0, 60, "Product 34", "product34.jpg", 613.95000000000005, 5 },
                    { 35, 15, 36, 16, 1723098131.318212, "Description for product 35", false, 0.0, 197, "Product 35", "product35.jpg", 208.59, 18 },
                    { 36, 84, 37, 17, 1723098131.3182125, "Description for product 36", false, 0.0, 193, "Product 36", "product36.jpg", 948.72000000000003, 17 },
                    { 37, 60, 38, 18, 1723098131.3182132, "Description for product 37", false, 0.0, 115, "Product 37", "product37.jpg", 880.54999999999995, 13 },
                    { 38, 75, 39, 19, 1723098131.3182137, "Description for product 38", false, 0.0, 77, "Product 38", "product38.jpg", 780.96000000000004, 15 },
                    { 39, 88, 40, 20, 1723098131.3182144, "Description for product 39", false, 0.0, 27, "Product 39", "product39.jpg", 536.48000000000002, 4 },
                    { 40, 45, 1, 1, 1723098131.3182149, "Description for product 40", false, 0.0, 115, "Product 40", "product40.jpg", 154.21000000000001, 13 },
                    { 41, 19, 2, 2, 1723098131.3182156, "Description for product 41", false, 0.0, 194, "Product 41", "product41.jpg", 660.20000000000005, 4 },
                    { 42, 85, 3, 3, 1723098131.3182163, "Description for product 42", false, 0.0, 97, "Product 42", "product42.jpg", 722.00999999999999, 8 },
                    { 43, 75, 4, 4, 1723098131.3182168, "Description for product 43", false, 0.0, 104, "Product 43", "product43.jpg", 147.19999999999999, 15 },
                    { 44, 97, 5, 5, 1723098131.3182175, "Description for product 44", false, 0.0, 71, "Product 44", "product44.jpg", 989.96000000000004, 18 },
                    { 45, 69, 6, 6, 1723098131.3182182, "Description for product 45", false, 0.0, 155, "Product 45", "product45.jpg", 40.600000000000001, 2 },
                    { 46, 68, 7, 7, 1723098131.3182223, "Description for product 46", false, 0.0, 153, "Product 46", "product46.jpg", 326.01999999999998, 2 },
                    { 47, 60, 8, 8, 1723098131.3182232, "Description for product 47", false, 0.0, 187, "Product 47", "product47.jpg", 970.37, 8 },
                    { 48, 86, 9, 9, 1723098131.3182237, "Description for product 48", false, 0.0, 85, "Product 48", "product48.jpg", 570.75, 5 },
                    { 49, 60, 10, 10, 1723098131.3182244, "Description for product 49", false, 0.0, 157, "Product 49", "product49.jpg", 149.68000000000001, 13 },
                    { 50, 20, 11, 11, 1723098131.3182251, "Description for product 50", false, 0.0, 195, "Product 50", "product50.jpg", 309.68000000000001, 12 },
                    { 51, 27, 12, 12, 1723098131.3182256, "Description for product 51", false, 0.0, 60, "Product 51", "product51.jpg", 929.50999999999999, 19 },
                    { 52, 19, 13, 13, 1723098131.3182263, "Description for product 52", false, 0.0, 157, "Product 52", "product52.jpg", 949.91999999999996, 10 },
                    { 53, 43, 14, 14, 1723098131.3182271, "Description for product 53", false, 0.0, 31, "Product 53", "product53.jpg", 49.740000000000002, 16 },
                    { 54, 23, 15, 15, 1723098131.3182275, "Description for product 54", false, 0.0, 182, "Product 54", "product54.jpg", 919.02999999999997, 15 },
                    { 55, 46, 16, 16, 1723098131.3182282, "Description for product 55", false, 0.0, 105, "Product 55", "product55.jpg", 520.50999999999999, 11 },
                    { 56, 12, 17, 17, 1723098131.3182287, "Description for product 56", false, 0.0, 79, "Product 56", "product56.jpg", 575.80999999999995, 3 },
                    { 57, 74, 18, 18, 1723098131.3182297, "Description for product 57", false, 0.0, 190, "Product 57", "product57.jpg", 552.62, 2 },
                    { 58, 75, 19, 19, 1723098131.3182299, "Description for product 58", false, 0.0, 79, "Product 58", "product58.jpg", 916.63999999999999, 12 },
                    { 59, 54, 20, 20, 1723098131.3182309, "Description for product 59", false, 0.0, 152, "Product 59", "product59.jpg", 527.39999999999998, 10 },
                    { 60, 83, 21, 1, 1723098131.3182313, "Description for product 60", false, 0.0, 27, "Product 60", "product60.jpg", 265.18000000000001, 2 },
                    { 61, 77, 22, 2, 1723098131.3182349, "Description for product 61", false, 0.0, 86, "Product 61", "product61.jpg", 559.54999999999995, 17 },
                    { 62, 88, 23, 3, 1723098131.3182356, "Description for product 62", false, 0.0, 81, "Product 62", "product62.jpg", 111.05, 2 },
                    { 63, 64, 24, 4, 1723098131.3182364, "Description for product 63", false, 0.0, 165, "Product 63", "product63.jpg", 167.36000000000001, 12 },
                    { 64, 82, 25, 5, 1723098131.3182368, "Description for product 64", false, 0.0, 138, "Product 64", "product64.jpg", 878.08000000000004, 19 },
                    { 65, 83, 26, 6, 1723098131.3182375, "Description for product 65", false, 0.0, 51, "Product 65", "product65.jpg", 813.59000000000003, 7 },
                    { 66, 97, 27, 7, 1723098131.3182385, "Description for product 66", false, 0.0, 103, "Product 66", "product66.jpg", 233.09, 7 },
                    { 67, 80, 28, 8, 1723098131.3182387, "Description for product 67", false, 0.0, 110, "Product 67", "product67.jpg", 676.23000000000002, 11 },
                    { 68, 16, 29, 9, 1723098131.3182397, "Description for product 68", false, 0.0, 163, "Product 68", "product68.jpg", 655.38, 11 },
                    { 69, 24, 30, 10, 1723098131.3182402, "Description for product 69", false, 0.0, 93, "Product 69", "product69.jpg", 625.5, 2 },
                    { 70, 72, 31, 11, 1723098131.3182409, "Description for product 70", false, 0.0, 49, "Product 70", "product70.jpg", 147.38999999999999, 4 },
                    { 71, 22, 32, 12, 1723098131.3182414, "Description for product 71", false, 0.0, 50, "Product 71", "product71.jpg", 115.41, 16 },
                    { 72, 28, 33, 13, 1723098131.3182421, "Description for product 72", false, 0.0, 103, "Product 72", "product72.jpg", 348.77999999999997, 18 },
                    { 73, 57, 34, 14, 1723098131.3182454, "Description for product 73", false, 0.0, 30, "Product 73", "product73.jpg", 153.19999999999999, 3 },
                    { 74, 99, 35, 15, 1723098131.3182459, "Description for product 74", false, 0.0, 177, "Product 74", "product74.jpg", 187.97999999999999, 8 },
                    { 75, 57, 36, 16, 1723098131.3182468, "Description for product 75", false, 0.0, 110, "Product 75", "product75.jpg", 66.609999999999999, 6 },
                    { 76, 74, 37, 17, 1723098131.3182473, "Description for product 76", false, 0.0, 136, "Product 76", "product76.jpg", 769.70000000000005, 19 },
                    { 77, 1, 38, 18, 1723098131.318248, "Description for product 77", false, 0.0, 85, "Product 77", "product77.jpg", 420.01999999999998, 8 },
                    { 78, 8, 39, 19, 1723098131.3182487, "Description for product 78", false, 0.0, 151, "Product 78", "product78.jpg", 99.519999999999996, 8 },
                    { 79, 34, 40, 20, 1723098131.3182495, "Description for product 79", false, 0.0, 72, "Product 79", "product79.jpg", 338.50999999999999, 10 },
                    { 80, 82, 1, 1, 1723098131.3182499, "Description for product 80", false, 0.0, 170, "Product 80", "product80.jpg", 64.099999999999994, 2 },
                    { 81, 90, 2, 2, 1723098131.3182509, "Description for product 81", false, 0.0, 178, "Product 81", "product81.jpg", 606.91999999999996, 9 },
                    { 82, 94, 3, 3, 1723098131.3182514, "Description for product 82", false, 0.0, 186, "Product 82", "product82.jpg", 508.72000000000003, 8 },
                    { 83, 89, 4, 4, 1723098131.3182521, "Description for product 83", false, 0.0, 147, "Product 83", "product83.jpg", 250.43000000000001, 2 },
                    { 84, 70, 5, 5, 1723098131.3182528, "Description for product 84", false, 0.0, 62, "Product 84", "product84.jpg", 267.39999999999998, 10 },
                    { 85, 21, 6, 6, 1723098131.3182533, "Description for product 85", false, 0.0, 187, "Product 85", "product85.jpg", 277.87, 17 },
                    { 86, 38, 7, 7, 1723098131.318254, "Description for product 86", false, 0.0, 120, "Product 86", "product86.jpg", 145.81999999999999, 14 },
                    { 87, 12, 8, 8, 1723098131.3182571, "Description for product 87", false, 0.0, 78, "Product 87", "product87.jpg", 263.47000000000003, 13 },
                    { 88, 9, 9, 9, 1723098131.318258, "Description for product 88", false, 0.0, 122, "Product 88", "product88.jpg", 23.710000000000001, 14 },
                    { 89, 35, 10, 10, 1723098131.3182583, "Description for product 89", false, 0.0, 36, "Product 89", "product89.jpg", 958.50999999999999, 14 },
                    { 90, 11, 11, 11, 1723098131.3182592, "Description for product 90", false, 0.0, 180, "Product 90", "product90.jpg", 471.66000000000003, 18 },
                    { 91, 98, 12, 12, 1723098131.3182597, "Description for product 91", false, 0.0, 169, "Product 91", "product91.jpg", 197.94, 1 },
                    { 92, 12, 13, 13, 1723098131.3182604, "Description for product 92", false, 0.0, 141, "Product 92", "product92.jpg", 647.80999999999995, 4 },
                    { 93, 13, 14, 14, 1723098131.3182609, "Description for product 93", false, 0.0, 141, "Product 93", "product93.jpg", 606.12, 13 },
                    { 94, 71, 15, 15, 1723098131.3182616, "Description for product 94", false, 0.0, 173, "Product 94", "product94.jpg", 920.23000000000002, 15 },
                    { 95, 88, 16, 16, 1723098131.3182621, "Description for product 95", false, 0.0, 144, "Product 95", "product95.jpg", 114.63, 10 },
                    { 96, 88, 17, 17, 1723098131.3182628, "Description for product 96", false, 0.0, 137, "Product 96", "product96.jpg", 63.630000000000003, 15 },
                    { 97, 5, 18, 18, 1723098131.3182635, "Description for product 97", false, 0.0, 87, "Product 97", "product97.jpg", 323.06999999999999, 15 },
                    { 98, 53, 19, 19, 1723098131.318264, "Description for product 98", false, 0.0, 147, "Product 98", "product98.jpg", 723.17999999999995, 6 },
                    { 99, 96, 20, 20, 1723098131.3182647, "Description for product 99", false, 0.0, 92, "Product 99", "product99.jpg", 784.58000000000004, 9 },
                    { 100, 25, 21, 1, 1723098131.3182652, "Description for product 100", false, 0.0, 69, "Product 100", "product100.jpg", 788.90999999999997, 2 },
                    { 101, 22, 22, 2, 1723098131.3182659, "Description for product 101", false, 0.0, 164, "Product 101", "product101.jpg", 385.44, 19 },
                    { 102, 59, 23, 3, 1723098131.3182695, "Description for product 102", false, 0.0, 111, "Product 102", "product102.jpg", 816.89999999999998, 2 },
                    { 103, 2, 24, 4, 1723098131.31827, "Description for product 103", false, 0.0, 93, "Product 103", "product103.jpg", 922.83000000000004, 8 },
                    { 104, 62, 25, 5, 1723098131.3182707, "Description for product 104", false, 0.0, 163, "Product 104", "product104.jpg", 328.88999999999999, 2 },
                    { 105, 96, 26, 6, 1723098131.3182712, "Description for product 105", false, 0.0, 178, "Product 105", "product105.jpg", 617.37, 13 },
                    { 106, 41, 27, 7, 1723098131.3182721, "Description for product 106", false, 0.0, 112, "Product 106", "product106.jpg", 736.62, 11 },
                    { 107, 9, 28, 8, 1723098131.3182726, "Description for product 107", false, 0.0, 100, "Product 107", "product107.jpg", 557.52999999999997, 14 },
                    { 108, 81, 29, 9, 1723098131.3182733, "Description for product 108", false, 0.0, 72, "Product 108", "product108.jpg", 675.72000000000003, 16 },
                    { 109, 84, 30, 10, 1723098131.3182738, "Description for product 109", false, 0.0, 187, "Product 109", "product109.jpg", 836.00999999999999, 11 },
                    { 110, 42, 31, 11, 1723098131.3182745, "Description for product 110", false, 0.0, 73, "Product 110", "product110.jpg", 692.70000000000005, 12 },
                    { 111, 50, 32, 12, 1723098131.3182752, "Description for product 111", false, 0.0, 140, "Product 111", "product111.jpg", 954.84000000000003, 16 },
                    { 112, 73, 33, 13, 1723098131.3182757, "Description for product 112", false, 0.0, 162, "Product 112", "product112.jpg", 272.95999999999998, 13 },
                    { 113, 29, 34, 14, 1723098131.3182764, "Description for product 113", false, 0.0, 102, "Product 113", "product113.jpg", 645.10000000000002, 12 },
                    { 114, 8, 35, 15, 1723098131.3182769, "Description for product 114", false, 0.0, 123, "Product 114", "product114.jpg", 229.37, 6 },
                    { 115, 56, 36, 16, 1723098131.3182776, "Description for product 115", false, 0.0, 59, "Product 115", "product115.jpg", 153.56, 7 },
                    { 116, 64, 37, 17, 1723098131.3182812, "Description for product 116", false, 0.0, 72, "Product 116", "product116.jpg", 89.430000000000007, 16 },
                    { 117, 26, 38, 18, 1723098131.3182819, "Description for product 117", false, 0.0, 113, "Product 117", "product117.jpg", 548.87, 16 },
                    { 118, 38, 39, 19, 1723098131.3182824, "Description for product 118", false, 0.0, 88, "Product 118", "product118.jpg", 580.70000000000005, 12 },
                    { 119, 96, 40, 20, 1723098131.3182831, "Description for product 119", false, 0.0, 94, "Product 119", "product119.jpg", 391.74000000000001, 6 },
                    { 120, 35, 1, 1, 1723098131.3182838, "Description for product 120", false, 0.0, 40, "Product 120", "product120.jpg", 276.74000000000001, 9 },
                    { 121, 66, 2, 2, 1723098131.3182845, "Description for product 121", false, 0.0, 131, "Product 121", "product121.jpg", 210.05000000000001, 1 },
                    { 122, 9, 3, 3, 1723098131.318285, "Description for product 122", false, 0.0, 69, "Product 122", "product122.jpg", 999.79999999999995, 13 },
                    { 123, 66, 4, 4, 1723098131.3182857, "Description for product 123", false, 0.0, 96, "Product 123", "product123.jpg", 605.69000000000005, 19 },
                    { 124, 96, 5, 5, 1723098131.3182864, "Description for product 124", false, 0.0, 140, "Product 124", "product124.jpg", 252.91999999999999, 17 },
                    { 125, 1, 6, 6, 1723098131.3182869, "Description for product 125", false, 0.0, 120, "Product 125", "product125.jpg", 927.79999999999995, 9 },
                    { 126, 57, 7, 7, 1723098131.3182876, "Description for product 126", false, 0.0, 121, "Product 126", "product126.jpg", 952.61000000000001, 7 },
                    { 127, 98, 8, 8, 1723098131.3182881, "Description for product 127", false, 0.0, 114, "Product 127", "product127.jpg", 4.9400000000000004, 13 },
                    { 128, 70, 9, 9, 1723098131.3182888, "Description for product 128", false, 0.0, 81, "Product 128", "product128.jpg", 208.03999999999999, 11 },
                    { 129, 96, 10, 10, 1723098131.3182895, "Description for product 129", false, 0.0, 64, "Product 129", "product129.jpg", 384.55000000000001, 16 },
                    { 130, 39, 11, 11, 1723098131.3182919, "Description for product 130", false, 0.0, 50, "Product 130", "product130.jpg", 549.38, 8 },
                    { 131, 34, 12, 12, 1723098131.3182929, "Description for product 131", false, 0.0, 43, "Product 131", "product131.jpg", 49.579999999999998, 9 },
                    { 132, 83, 13, 13, 1723098131.3182931, "Description for product 132", false, 0.0, 43, "Product 132", "product132.jpg", 3.3500000000000001, 2 },
                    { 133, 6, 14, 14, 1723098131.318294, "Description for product 133", false, 0.0, 101, "Product 133", "product133.jpg", 581.10000000000002, 9 },
                    { 134, 59, 15, 15, 1723098131.3182943, "Description for product 134", false, 0.0, 189, "Product 134", "product134.jpg", 855.69000000000005, 12 },
                    { 135, 29, 16, 16, 1723098131.3182952, "Description for product 135", false, 0.0, 162, "Product 135", "product135.jpg", 600.62, 5 },
                    { 136, 23, 17, 17, 1723098131.3182957, "Description for product 136", false, 0.0, 190, "Product 136", "product136.jpg", 87.560000000000002, 13 },
                    { 137, 41, 18, 18, 1723098131.3182964, "Description for product 137", false, 0.0, 196, "Product 137", "product137.jpg", 3.4399999999999999, 10 },
                    { 138, 55, 19, 19, 1723098131.3182969, "Description for product 138", false, 0.0, 40, "Product 138", "product138.jpg", 268.69999999999999, 1 },
                    { 139, 15, 20, 20, 1723098131.3182976, "Description for product 139", false, 0.0, 117, "Product 139", "product139.jpg", 856.01999999999998, 18 },
                    { 140, 4, 21, 1, 1723098131.3183036, "Description for product 140", false, 0.0, 186, "Product 140", "product140.jpg", 954.04999999999995, 9 },
                    { 141, 73, 22, 2, 1723098131.3183043, "Description for product 141", false, 0.0, 162, "Product 141", "product141.jpg", 723.92999999999995, 1 },
                    { 142, 72, 23, 3, 1723098131.3183048, "Description for product 142", false, 0.0, 197, "Product 142", "product142.jpg", 263.75, 11 },
                    { 143, 20, 24, 4, 1723098131.3183055, "Description for product 143", false, 0.0, 66, "Product 143", "product143.jpg", 385.97000000000003, 12 },
                    { 144, 73, 25, 5, 1723098131.3183062, "Description for product 144", false, 0.0, 49, "Product 144", "product144.jpg", 411.23000000000002, 2 },
                    { 145, 82, 26, 6, 1723098131.3183067, "Description for product 145", false, 0.0, 152, "Product 145", "product145.jpg", 795.57000000000005, 3 },
                    { 146, 53, 27, 7, 1723098131.3183076, "Description for product 146", false, 0.0, 70, "Product 146", "product146.jpg", 983.24000000000001, 15 },
                    { 147, 34, 28, 8, 1723098131.3183081, "Description for product 147", false, 0.0, 26, "Product 147", "product147.jpg", 552.98000000000002, 9 },
                    { 148, 32, 29, 9, 1723098131.3183088, "Description for product 148", false, 0.0, 127, "Product 148", "product148.jpg", 154.65000000000001, 16 },
                    { 149, 9, 30, 10, 1723098131.3183093, "Description for product 149", false, 0.0, 164, "Product 149", "product149.jpg", 63.649999999999999, 9 },
                    { 150, 59, 31, 11, 1723098131.31831, "Description for product 150", false, 0.0, 195, "Product 150", "product150.jpg", 694.11000000000001, 11 },
                    { 151, 97, 32, 12, 1723098131.3183105, "Description for product 151", false, 0.0, 57, "Product 151", "product151.jpg", 895.45000000000005, 18 },
                    { 152, 12, 33, 13, 1723098131.3183112, "Description for product 152", false, 0.0, 185, "Product 152", "product152.jpg", 283.31999999999999, 1 },
                    { 153, 91, 34, 14, 1723098131.3183119, "Description for product 153", false, 0.0, 106, "Product 153", "product153.jpg", 350.75999999999999, 1 },
                    { 154, 45, 35, 15, 1723098131.318315, "Description for product 154", false, 0.0, 35, "Product 154", "product154.jpg", 797.53999999999996, 12 },
                    { 155, 84, 36, 16, 1723098131.3183155, "Description for product 155", false, 0.0, 78, "Product 155", "product155.jpg", 73.409999999999997, 4 },
                    { 156, 24, 37, 17, 1723098131.3183162, "Description for product 156", false, 0.0, 132, "Product 156", "product156.jpg", 355.13999999999999, 19 },
                    { 157, 71, 38, 18, 1723098131.3183167, "Description for product 157", false, 0.0, 50, "Product 157", "product157.jpg", 567.48000000000002, 12 },
                    { 158, 82, 39, 19, 1723098131.3183177, "Description for product 158", false, 0.0, 25, "Product 158", "product158.jpg", 30.960000000000001, 8 },
                    { 159, 32, 40, 20, 1723098131.3183181, "Description for product 159", false, 0.0, 57, "Product 159", "product159.jpg", 642.5, 19 },
                    { 160, 25, 1, 1, 1723098131.3183188, "Description for product 160", false, 0.0, 61, "Product 160", "product160.jpg", 629.34000000000003, 2 },
                    { 161, 34, 2, 2, 1723098131.3183193, "Description for product 161", false, 0.0, 140, "Product 161", "product161.jpg", 780.65999999999997, 1 },
                    { 162, 20, 3, 3, 1723098131.31832, "Description for product 162", false, 0.0, 113, "Product 162", "product162.jpg", 922.64999999999998, 4 },
                    { 163, 8, 4, 4, 1723098131.3183208, "Description for product 163", false, 0.0, 44, "Product 163", "product163.jpg", 248.69, 12 },
                    { 164, 56, 5, 5, 1723098131.3183212, "Description for product 164", false, 0.0, 197, "Product 164", "product164.jpg", 284.56999999999999, 13 },
                    { 165, 36, 6, 6, 1723098131.3183219, "Description for product 165", false, 0.0, 195, "Product 165", "product165.jpg", 543.94000000000005, 12 },
                    { 166, 97, 7, 7, 1723098131.3183224, "Description for product 166", false, 0.0, 156, "Product 166", "product166.jpg", 424.45999999999998, 16 },
                    { 167, 17, 8, 8, 1723098131.3183231, "Description for product 167", false, 0.0, 179, "Product 167", "product167.jpg", 275.82999999999998, 7 },
                    { 168, 36, 9, 9, 1723098131.3183267, "Description for product 168", false, 0.0, 92, "Product 168", "product168.jpg", 16.850000000000001, 16 },
                    { 169, 15, 10, 10, 1723098131.3183277, "Description for product 169", false, 0.0, 142, "Product 169", "product169.jpg", 397.89999999999998, 4 },
                    { 170, 66, 11, 11, 1723098131.3183281, "Description for product 170", false, 0.0, 135, "Product 170", "product170.jpg", 823.03999999999996, 11 },
                    { 171, 69, 12, 12, 1723098131.3183289, "Description for product 171", false, 0.0, 140, "Product 171", "product171.jpg", 811.91999999999996, 3 },
                    { 172, 41, 13, 13, 1723098131.3183296, "Description for product 172", false, 0.0, 105, "Product 172", "product172.jpg", 942.76999999999998, 19 },
                    { 173, 61, 14, 14, 1723098131.31833, "Description for product 173", false, 0.0, 191, "Product 173", "product173.jpg", 704.67999999999995, 9 },
                    { 174, 15, 15, 15, 1723098131.3183308, "Description for product 174", false, 0.0, 188, "Product 174", "product174.jpg", 304.07999999999998, 1 },
                    { 175, 92, 16, 16, 1723098131.3183315, "Description for product 175", false, 0.0, 103, "Product 175", "product175.jpg", 393.04000000000002, 16 },
                    { 176, 29, 17, 17, 1723098131.318332, "Description for product 176", false, 0.0, 121, "Product 176", "product176.jpg", 796.84000000000003, 8 },
                    { 177, 52, 18, 18, 1723098131.3183329, "Description for product 177", false, 0.0, 52, "Product 177", "product177.jpg", 369.52999999999997, 9 },
                    { 178, 89, 19, 19, 1723098131.3183331, "Description for product 178", false, 0.0, 161, "Product 178", "product178.jpg", 889.24000000000001, 14 },
                    { 179, 53, 20, 20, 1723098131.3183341, "Description for product 179", false, 0.0, 111, "Product 179", "product179.jpg", 460.99000000000001, 19 },
                    { 180, 31, 21, 1, 1723098131.3183348, "Description for product 180", false, 0.0, 93, "Product 180", "product180.jpg", 89.560000000000002, 6 },
                    { 181, 65, 22, 2, 1723098131.3183353, "Description for product 181", false, 0.0, 81, "Product 181", "product181.jpg", 200.27000000000001, 17 },
                    { 182, 1, 23, 3, 1723098131.3183384, "Description for product 182", false, 0.0, 90, "Product 182", "product182.jpg", 441.88, 5 },
                    { 183, 29, 24, 4, 1723098131.3183391, "Description for product 183", false, 0.0, 194, "Product 183", "product183.jpg", 375.62, 5 },
                    { 184, 60, 25, 5, 1723098131.3183396, "Description for product 184", false, 0.0, 142, "Product 184", "product184.jpg", 78.739999999999995, 4 },
                    { 185, 37, 26, 6, 1723098131.3183403, "Description for product 185", false, 0.0, 72, "Product 185", "product185.jpg", 80.540000000000006, 16 },
                    { 186, 12, 27, 7, 1723098131.3183408, "Description for product 186", false, 0.0, 174, "Product 186", "product186.jpg", 0.70999999999999996, 9 },
                    { 187, 83, 28, 8, 1723098131.3183415, "Description for product 187", false, 0.0, 23, "Product 187", "product187.jpg", 634.12, 9 },
                    { 188, 82, 29, 9, 1723098131.318342, "Description for product 188", false, 0.0, 50, "Product 188", "product188.jpg", 796.72000000000003, 17 },
                    { 189, 50, 30, 10, 1723098131.3183427, "Description for product 189", false, 0.0, 111, "Product 189", "product189.jpg", 5.75, 9 },
                    { 190, 66, 31, 11, 1723098131.3183434, "Description for product 190", false, 0.0, 107, "Product 190", "product190.jpg", 195.97999999999999, 16 },
                    { 191, 90, 32, 12, 1723098131.3183441, "Description for product 191", false, 0.0, 138, "Product 191", "product191.jpg", 372.95999999999998, 16 },
                    { 192, 36, 33, 13, 1723098131.3183444, "Description for product 192", false, 0.0, 144, "Product 192", "product192.jpg", 444.29000000000002, 3 },
                    { 193, 49, 34, 14, 1723098131.3183453, "Description for product 193", false, 0.0, 188, "Product 193", "product193.jpg", 708.15999999999997, 5 },
                    { 194, 3, 35, 15, 1723098131.3183458, "Description for product 194", false, 0.0, 50, "Product 194", "product194.jpg", 713.70000000000005, 17 },
                    { 195, 64, 36, 16, 1723098131.3183465, "Description for product 195", false, 0.0, 133, "Product 195", "product195.jpg", 807.66999999999996, 16 },
                    { 196, 51, 37, 17, 1723098131.3183501, "Description for product 196", false, 0.0, 56, "Product 196", "product196.jpg", 892.80999999999995, 19 },
                    { 197, 15, 38, 18, 1723098131.3183506, "Description for product 197", false, 0.0, 124, "Product 197", "product197.jpg", 515.33000000000004, 18 },
                    { 198, 42, 39, 19, 1723098131.3183513, "Description for product 198", false, 0.0, 173, "Product 198", "product198.jpg", 578.85000000000002, 3 },
                    { 199, 74, 40, 20, 1723098131.3183517, "Description for product 199", false, 0.0, 147, "Product 199", "product199.jpg", 143.56999999999999, 7 },
                    { 200, 7, 1, 1, 1723098131.3183525, "Description for product 200", false, 0.0, 114, "Product 200", "product200.jpg", 394.04000000000002, 3 },
                    { 201, 8, 2, 2, 1723098131.3183532, "Description for product 201", false, 0.0, 164, "Product 201", "product201.jpg", 604.34000000000003, 7 },
                    { 202, 71, 3, 3, 1723098131.3183537, "Description for product 202", false, 0.0, 181, "Product 202", "product202.jpg", 451.63999999999999, 7 },
                    { 203, 30, 4, 4, 1723098131.3183544, "Description for product 203", false, 0.0, 107, "Product 203", "product203.jpg", 924.88999999999999, 11 },
                    { 204, 89, 5, 5, 1723098131.3183548, "Description for product 204", false, 0.0, 121, "Product 204", "product204.jpg", 488.80000000000001, 11 },
                    { 205, 97, 6, 6, 1723098131.3183556, "Description for product 205", false, 0.0, 89, "Product 205", "product205.jpg", 482.95999999999998, 10 },
                    { 206, 10, 7, 7, 1723098131.3183563, "Description for product 206", false, 0.0, 177, "Product 206", "product206.jpg", 814.04999999999995, 13 },
                    { 207, 26, 8, 8, 1723098131.3183568, "Description for product 207", false, 0.0, 75, "Product 207", "product207.jpg", 811.12, 6 },
                    { 208, 31, 9, 9, 1723098131.3183575, "Description for product 208", false, 0.0, 126, "Product 208", "product208.jpg", 478.48000000000002, 4 },
                    { 209, 18, 10, 10, 1723098131.3183579, "Description for product 209", false, 0.0, 21, "Product 209", "product209.jpg", 462.49000000000001, 16 },
                    { 210, 28, 11, 11, 1723098131.3183615, "Description for product 210", false, 0.0, 138, "Product 210", "product210.jpg", 736.79999999999995, 17 },
                    { 211, 88, 12, 12, 1723098131.3183622, "Description for product 211", false, 0.0, 151, "Product 211", "product211.jpg", 24.550000000000001, 13 },
                    { 212, 61, 13, 13, 1723098131.3183627, "Description for product 212", false, 0.0, 46, "Product 212", "product212.jpg", 61.170000000000002, 10 },
                    { 213, 87, 14, 14, 1723098131.3183634, "Description for product 213", false, 0.0, 76, "Product 213", "product213.jpg", 711.28999999999996, 3 },
                    { 214, 1, 15, 15, 1723098131.3183639, "Description for product 214", false, 0.0, 161, "Product 214", "product214.jpg", 501.58999999999997, 5 },
                    { 215, 61, 16, 16, 1723098131.3183649, "Description for product 215", false, 0.0, 110, "Product 215", "product215.jpg", 146.84999999999999, 13 },
                    { 216, 8, 17, 17, 1723098131.3183653, "Description for product 216", false, 0.0, 175, "Product 216", "product216.jpg", 577.20000000000005, 12 },
                    { 217, 51, 18, 18, 1723098131.3183661, "Description for product 217", false, 0.0, 187, "Product 217", "product217.jpg", 338.64999999999998, 14 },
                    { 218, 65, 19, 19, 1723098131.3183663, "Description for product 218", false, 0.0, 62, "Product 218", "product218.jpg", 648.84000000000003, 10 },
                    { 219, 77, 20, 20, 1723098131.3183672, "Description for product 219", false, 0.0, 83, "Product 219", "product219.jpg", 906.82000000000005, 18 },
                    { 220, 4, 21, 1, 1723098131.3183675, "Description for product 220", false, 0.0, 126, "Product 220", "product220.jpg", 310.72000000000003, 18 },
                    { 221, 72, 22, 2, 1723098131.3183684, "Description for product 221", false, 0.0, 165, "Product 221", "product221.jpg", 7.2300000000000004, 5 },
                    { 222, 47, 23, 3, 1723098131.3183689, "Description for product 222", false, 0.0, 134, "Product 222", "product222.jpg", 544.52999999999997, 6 },
                    { 223, 16, 24, 4, 1723098131.3183696, "Description for product 223", false, 0.0, 47, "Product 223", "product223.jpg", 744.37, 19 },
                    { 224, 27, 25, 5, 1723098131.318372, "Description for product 224", false, 0.0, 161, "Product 224", "product224.jpg", 109.06, 6 },
                    { 225, 52, 26, 6, 1723098131.3183725, "Description for product 225", false, 0.0, 108, "Product 225", "product225.jpg", 947.41999999999996, 5 },
                    { 226, 70, 27, 7, 1723098131.3183732, "Description for product 226", false, 0.0, 144, "Product 226", "product226.jpg", 578.63999999999999, 8 },
                    { 227, 37, 28, 8, 1723098131.3183739, "Description for product 227", false, 0.0, 112, "Product 227", "product227.jpg", 155.80000000000001, 3 },
                    { 228, 46, 29, 9, 1723098131.3183744, "Description for product 228", false, 0.0, 172, "Product 228", "product228.jpg", 639.22000000000003, 3 },
                    { 229, 2, 30, 10, 1723098131.3183751, "Description for product 229", false, 0.0, 35, "Product 229", "product229.jpg", 283.02999999999997, 13 },
                    { 230, 84, 31, 11, 1723098131.3183758, "Description for product 230", false, 0.0, 127, "Product 230", "product230.jpg", 442.19, 6 },
                    { 231, 4, 32, 12, 1723098131.3183763, "Description for product 231", false, 0.0, 179, "Product 231", "product231.jpg", 535.72000000000003, 14 },
                    { 232, 60, 33, 13, 1723098131.3183773, "Description for product 232", false, 0.0, 42, "Product 232", "product232.jpg", 979.37, 7 },
                    { 233, 86, 34, 14, 1723098131.3183777, "Description for product 233", false, 0.0, 104, "Product 233", "product233.jpg", 75.319999999999993, 17 },
                    { 234, 25, 35, 15, 1723098131.3183784, "Description for product 234", false, 0.0, 73, "Product 234", "product234.jpg", 507.36000000000001, 12 },
                    { 235, 40, 36, 16, 1723098131.3183792, "Description for product 235", false, 0.0, 76, "Product 235", "product235.jpg", 808.88999999999999, 4 },
                    { 236, 66, 37, 17, 1723098131.3183799, "Description for product 236", false, 0.0, 120, "Product 236", "product236.jpg", 480.88999999999999, 12 },
                    { 237, 48, 38, 18, 1723098131.3183839, "Description for product 237", false, 0.0, 175, "Product 237", "product237.jpg", 935.44000000000005, 4 },
                    { 238, 43, 39, 19, 1723098131.3183849, "Description for product 238", false, 0.0, 36, "Product 238", "product238.jpg", 258.63, 3 },
                    { 239, 30, 40, 20, 1723098131.3183854, "Description for product 239", false, 0.0, 74, "Product 239", "product239.jpg", 568.82000000000005, 7 },
                    { 240, 60, 1, 1, 1723098131.3183861, "Description for product 240", false, 0.0, 144, "Product 240", "product240.jpg", 19.129999999999999, 10 },
                    { 241, 78, 2, 2, 1723098131.3183866, "Description for product 241", false, 0.0, 170, "Product 241", "product241.jpg", 680.54999999999995, 2 },
                    { 242, 35, 3, 3, 1723098131.3183873, "Description for product 242", false, 0.0, 67, "Product 242", "product242.jpg", 974.75, 10 },
                    { 243, 16, 4, 4, 1723098131.318388, "Description for product 243", false, 0.0, 164, "Product 243", "product243.jpg", 955.74000000000001, 3 },
                    { 244, 41, 5, 5, 1723098131.3183885, "Description for product 244", false, 0.0, 42, "Product 244", "product244.jpg", 910.07000000000005, 10 },
                    { 245, 76, 6, 6, 1723098131.3183892, "Description for product 245", false, 0.0, 130, "Product 245", "product245.jpg", 559.65999999999997, 14 },
                    { 246, 58, 7, 7, 1723098131.3183899, "Description for product 246", false, 0.0, 156, "Product 246", "product246.jpg", 590.90999999999997, 17 },
                    { 247, 22, 8, 8, 1723098131.3183904, "Description for product 247", false, 0.0, 79, "Product 247", "product247.jpg", 727.37, 18 },
                    { 248, 98, 9, 9, 1723098131.3183911, "Description for product 248", false, 0.0, 65, "Product 248", "product248.jpg", 595.74000000000001, 16 },
                    { 249, 73, 10, 10, 1723098131.3183916, "Description for product 249", false, 0.0, 35, "Product 249", "product249.jpg", 447.06, 3 },
                    { 250, 65, 11, 11, 1723098131.3183925, "Description for product 250", false, 0.0, 121, "Product 250", "product250.jpg", 705.64999999999998, 1 },
                    { 251, 36, 12, 12, 1723098131.3183973, "Description for product 251", false, 0.0, 32, "Product 251", "product251.jpg", 754.07000000000005, 2 },
                    { 252, 25, 13, 13, 1723098131.3183978, "Description for product 252", false, 0.0, 196, "Product 252", "product252.jpg", 377.54000000000002, 18 },
                    { 253, 49, 14, 14, 1723098131.3183985, "Description for product 253", false, 0.0, 59, "Product 253", "product253.jpg", 918.57000000000005, 19 },
                    { 254, 85, 15, 15, 1723098131.318399, "Description for product 254", false, 0.0, 126, "Product 254", "product254.jpg", 574.96000000000004, 9 },
                    { 255, 92, 16, 16, 1723098131.3183997, "Description for product 255", false, 0.0, 167, "Product 255", "product255.jpg", 906.83000000000004, 4 },
                    { 256, 97, 17, 17, 1723098131.3184004, "Description for product 256", false, 0.0, 150, "Product 256", "product256.jpg", 616.71000000000004, 14 },
                    { 257, 76, 18, 18, 1723098131.3184011, "Description for product 257", false, 0.0, 130, "Product 257", "product257.jpg", 256.05000000000001, 6 },
                    { 258, 18, 19, 19, 1723098131.3184044, "Description for product 258", false, 0.0, 181, "Product 258", "product258.jpg", 536.04999999999995, 14 },
                    { 259, 79, 20, 20, 1723098131.3184049, "Description for product 259", false, 0.0, 127, "Product 259", "product259.jpg", 44.18, 4 },
                    { 260, 66, 21, 1, 1723098131.3184056, "Description for product 260", false, 0.0, 51, "Product 260", "product260.jpg", 599.75999999999999, 18 },
                    { 261, 90, 22, 2, 1723098131.3184063, "Description for product 261", false, 0.0, 83, "Product 261", "product261.jpg", 591.30999999999995, 15 },
                    { 262, 70, 23, 3, 1723098131.3184068, "Description for product 262", false, 0.0, 25, "Product 262", "product262.jpg", 681.90999999999997, 3 },
                    { 263, 90, 24, 4, 1723098131.3184075, "Description for product 263", false, 0.0, 77, "Product 263", "product263.jpg", 185.59999999999999, 12 },
                    { 264, 19, 25, 5, 1723098131.318408, "Description for product 264", false, 0.0, 86, "Product 264", "product264.jpg", 392.81, 8 },
                    { 265, 94, 26, 6, 1723098131.3184087, "Description for product 265", false, 0.0, 95, "Product 265", "product265.jpg", 610.5, 13 },
                    { 266, 9, 27, 7, 1723098131.3184097, "Description for product 266", false, 0.0, 100, "Product 266", "product266.jpg", 140.12, 8 },
                    { 267, 20, 28, 8, 1723098131.3184099, "Description for product 267", false, 0.0, 139, "Product 267", "product267.jpg", 673.87, 8 },
                    { 268, 93, 29, 9, 1723098131.3184109, "Description for product 268", false, 0.0, 140, "Product 268", "product268.jpg", 375.57999999999998, 13 },
                    { 269, 38, 30, 10, 1723098131.3184114, "Description for product 269", false, 0.0, 62, "Product 269", "product269.jpg", 964.02999999999997, 6 },
                    { 270, 61, 31, 11, 1723098131.3184121, "Description for product 270", false, 0.0, 172, "Product 270", "product270.jpg", 665.66999999999996, 11 },
                    { 271, 99, 32, 12, 1723098131.3184128, "Description for product 271", false, 0.0, 41, "Product 271", "product271.jpg", 912.54999999999995, 3 },
                    { 272, 16, 33, 13, 1723098131.3184133, "Description for product 272", false, 0.0, 96, "Product 272", "product272.jpg", 16.440000000000001, 12 },
                    { 273, 45, 34, 14, 1723098131.3184161, "Description for product 273", false, 0.0, 89, "Product 273", "product273.jpg", 196.41, 3 },
                    { 274, 52, 35, 15, 1723098131.3184168, "Description for product 274", false, 0.0, 193, "Product 274", "product274.jpg", 785.08000000000004, 18 },
                    { 275, 67, 36, 16, 1723098131.3184175, "Description for product 275", false, 0.0, 75, "Product 275", "product275.jpg", 466.56, 7 },
                    { 276, 61, 37, 17, 1723098131.318418, "Description for product 276", false, 0.0, 131, "Product 276", "product276.jpg", 895.24000000000001, 10 },
                    { 277, 97, 38, 18, 1723098131.3184187, "Description for product 277", false, 0.0, 28, "Product 277", "product277.jpg", 226.59999999999999, 1 },
                    { 278, 66, 39, 19, 1723098131.3184192, "Description for product 278", false, 0.0, 91, "Product 278", "product278.jpg", 49.439999999999998, 19 },
                    { 279, 41, 40, 20, 1723098131.3184197, "Description for product 279", false, 0.0, 158, "Product 279", "product279.jpg", 740.84000000000003, 7 },
                    { 280, 13, 1, 1, 1723098131.3184204, "Description for product 280", false, 0.0, 66, "Product 280", "product280.jpg", 466.83999999999997, 2 },
                    { 281, 90, 2, 2, 1723098131.3184211, "Description for product 281", false, 0.0, 122, "Product 281", "product281.jpg", 490.13999999999999, 3 },
                    { 282, 22, 3, 3, 1723098131.3184216, "Description for product 282", false, 0.0, 122, "Product 282", "product282.jpg", 618.21000000000004, 16 },
                    { 283, 13, 4, 4, 1723098131.3184223, "Description for product 283", false, 0.0, 38, "Product 283", "product283.jpg", 99.370000000000005, 1 },
                    { 284, 54, 5, 5, 1723098131.3184228, "Description for product 284", false, 0.0, 127, "Product 284", "product284.jpg", 86.689999999999998, 7 },
                    { 285, 96, 6, 6, 1723098131.3184235, "Description for product 285", false, 0.0, 138, "Product 285", "product285.jpg", 194.66, 17 },
                    { 286, 62, 7, 7, 1723098131.3184242, "Description for product 286", false, 0.0, 114, "Product 286", "product286.jpg", 28.41, 17 },
                    { 287, 44, 8, 8, 1723098131.3184304, "Description for product 287", false, 0.0, 32, "Product 287", "product287.jpg", 375.89999999999998, 5 },
                    { 288, 41, 9, 9, 1723098131.3184311, "Description for product 288", false, 0.0, 26, "Product 288", "product288.jpg", 61.020000000000003, 6 },
                    { 289, 46, 10, 10, 1723098131.3184316, "Description for product 289", false, 0.0, 105, "Product 289", "product289.jpg", 135.96000000000001, 13 },
                    { 290, 59, 11, 11, 1723098131.3184323, "Description for product 290", false, 0.0, 62, "Product 290", "product290.jpg", 301.50999999999999, 13 },
                    { 291, 3, 12, 12, 1723098131.3184328, "Description for product 291", false, 0.0, 144, "Product 291", "product291.jpg", 79.150000000000006, 11 },
                    { 292, 2, 13, 13, 1723098131.3184335, "Description for product 292", false, 0.0, 89, "Product 292", "product292.jpg", 197.09, 3 },
                    { 293, 50, 14, 14, 1723098131.3184342, "Description for product 293", false, 0.0, 52, "Product 293", "product293.jpg", 763.20000000000005, 13 },
                    { 294, 23, 15, 15, 1723098131.3184347, "Description for product 294", false, 0.0, 100, "Product 294", "product294.jpg", 558.49000000000001, 19 },
                    { 295, 94, 16, 16, 1723098131.3184357, "Description for product 295", false, 0.0, 161, "Product 295", "product295.jpg", 210.19, 2 },
                    { 296, 22, 17, 17, 1723098131.3184359, "Description for product 296", false, 0.0, 186, "Product 296", "product296.jpg", 168.47, 7 },
                    { 297, 50, 18, 18, 1723098131.3184369, "Description for product 297", false, 0.0, 123, "Product 297", "product297.jpg", 730.79999999999995, 18 },
                    { 298, 4, 19, 19, 1723098131.3184373, "Description for product 298", false, 0.0, 46, "Product 298", "product298.jpg", 608.88999999999999, 12 },
                    { 299, 65, 20, 20, 1723098131.3184381, "Description for product 299", false, 0.0, 35, "Product 299", "product299.jpg", 803.41999999999996, 1 },
                    { 300, 80, 21, 1, 1723098131.3184385, "Description for product 300", false, 0.0, 143, "Product 300", "product300.jpg", 496.26999999999998, 2 },
                    { 301, 45, 22, 2, 1723098131.3184421, "Description for product 301", false, 0.0, 192, "Product 301", "product301.jpg", 8.1600000000000001, 19 },
                    { 302, 4, 23, 3, 1723098131.3184428, "Description for product 302", false, 0.0, 64, "Product 302", "product302.jpg", 507.76999999999998, 4 },
                    { 303, 47, 24, 4, 1723098131.3184435, "Description for product 303", false, 0.0, 127, "Product 303", "product303.jpg", 735.54999999999995, 7 },
                    { 304, 1, 25, 5, 1723098131.3184443, "Description for product 304", false, 0.0, 83, "Product 304", "product304.jpg", 57.359999999999999, 9 },
                    { 305, 17, 26, 6, 1723098131.3184447, "Description for product 305", false, 0.0, 151, "Product 305", "product305.jpg", 928.14999999999998, 18 },
                    { 306, 73, 27, 7, 1723098131.3184454, "Description for product 306", false, 0.0, 127, "Product 306", "product306.jpg", 172.05000000000001, 5 },
                    { 307, 23, 28, 8, 1723098131.3184459, "Description for product 307", false, 0.0, 187, "Product 307", "product307.jpg", 846.53999999999996, 9 },
                    { 308, 71, 29, 9, 1723098131.3184469, "Description for product 308", false, 0.0, 123, "Product 308", "product308.jpg", 497.62, 19 },
                    { 309, 36, 30, 10, 1723098131.3184471, "Description for product 309", false, 0.0, 48, "Product 309", "product309.jpg", 482.75999999999999, 7 },
                    { 310, 71, 31, 11, 1723098131.3184481, "Description for product 310", false, 0.0, 137, "Product 310", "product310.jpg", 752.58000000000004, 19 },
                    { 311, 46, 32, 12, 1723098131.3184483, "Description for product 311", false, 0.0, 186, "Product 311", "product311.jpg", 211.53, 1 },
                    { 312, 7, 33, 13, 1723098131.3184493, "Description for product 312", false, 0.0, 120, "Product 312", "product312.jpg", 135.28999999999999, 19 },
                    { 313, 94, 34, 14, 1723098131.3184497, "Description for product 313", false, 0.0, 175, "Product 313", "product313.jpg", 54.450000000000003, 16 },
                    { 314, 65, 35, 15, 1723098131.3184505, "Description for product 314", false, 0.0, 35, "Product 314", "product314.jpg", 514.30999999999995, 1 },
                    { 315, 1, 36, 16, 1723098131.3184547, "Description for product 315", false, 0.0, 140, "Product 315", "product315.jpg", 719.33000000000004, 16 },
                    { 316, 24, 37, 17, 1723098131.3184555, "Description for product 316", false, 0.0, 96, "Product 316", "product316.jpg", 457.17000000000002, 9 },
                    { 317, 42, 38, 18, 1723098131.3184559, "Description for product 317", false, 0.0, 142, "Product 317", "product317.jpg", 72.730000000000004, 8 },
                    { 318, 14, 39, 19, 1723098131.3184569, "Description for product 318", false, 0.0, 28, "Product 318", "product318.jpg", 950.13999999999999, 5 },
                    { 319, 80, 40, 20, 1723098131.3184574, "Description for product 319", false, 0.0, 51, "Product 319", "product319.jpg", 77.200000000000003, 2 },
                    { 320, 48, 1, 1, 1723098131.3184581, "Description for product 320", false, 0.0, 65, "Product 320", "product320.jpg", 897.13999999999999, 16 },
                    { 321, 36, 2, 2, 1723098131.3184586, "Description for product 321", false, 0.0, 95, "Product 321", "product321.jpg", 675.46000000000004, 3 },
                    { 322, 81, 3, 3, 1723098131.3184593, "Description for product 322", false, 0.0, 101, "Product 322", "product322.jpg", 650.97000000000003, 5 },
                    { 323, 97, 4, 4, 1723098131.31846, "Description for product 323", false, 0.0, 102, "Product 323", "product323.jpg", 164.34, 12 },
                    { 324, 88, 5, 5, 1723098131.3184607, "Description for product 324", false, 0.0, 58, "Product 324", "product324.jpg", 454.66000000000003, 15 },
                    { 325, 73, 6, 6, 1723098131.3184612, "Description for product 325", false, 0.0, 58, "Product 325", "product325.jpg", 346.32999999999998, 18 },
                    { 326, 20, 7, 7, 1723098131.3184619, "Description for product 326", false, 0.0, 153, "Product 326", "product326.jpg", 673.07000000000005, 18 },
                    { 327, 16, 8, 8, 1723098131.3184624, "Description for product 327", false, 0.0, 135, "Product 327", "product327.jpg", 615.70000000000005, 1 },
                    { 328, 48, 9, 9, 1723098131.3184631, "Description for product 328", false, 0.0, 39, "Product 328", "product328.jpg", 159.0, 9 },
                    { 329, 52, 10, 10, 1723098131.3184659, "Description for product 329", false, 0.0, 193, "Product 329", "product329.jpg", 456.93000000000001, 7 },
                    { 330, 67, 11, 11, 1723098131.3184669, "Description for product 330", false, 0.0, 160, "Product 330", "product330.jpg", 678.50999999999999, 18 },
                    { 331, 82, 12, 12, 1723098131.3184671, "Description for product 331", false, 0.0, 51, "Product 331", "product331.jpg", 516.24000000000001, 18 },
                    { 332, 27, 13, 13, 1723098131.3184681, "Description for product 332", false, 0.0, 94, "Product 332", "product332.jpg", 597.0, 18 },
                    { 333, 16, 14, 14, 1723098131.3184683, "Description for product 333", false, 0.0, 150, "Product 333", "product333.jpg", 686.0, 16 },
                    { 334, 75, 15, 15, 1723098131.3184693, "Description for product 334", false, 0.0, 121, "Product 334", "product334.jpg", 10.699999999999999, 1 },
                    { 335, 71, 16, 16, 1723098131.3184698, "Description for product 335", false, 0.0, 77, "Product 335", "product335.jpg", 309.32999999999998, 18 },
                    { 336, 30, 17, 17, 1723098131.3184705, "Description for product 336", false, 0.0, 27, "Product 336", "product336.jpg", 132.05000000000001, 3 },
                    { 337, 4, 18, 18, 1723098131.318471, "Description for product 337", false, 0.0, 82, "Product 337", "product337.jpg", 119.45999999999999, 8 },
                    { 338, 16, 19, 19, 1723098131.3184717, "Description for product 338", false, 0.0, 160, "Product 338", "product338.jpg", 391.72000000000003, 9 },
                    { 339, 8, 20, 20, 1723098131.3184721, "Description for product 339", false, 0.0, 63, "Product 339", "product339.jpg", 486.31999999999999, 10 },
                    { 340, 61, 21, 1, 1723098131.3184729, "Description for product 340", false, 0.0, 178, "Product 340", "product340.jpg", 697.50999999999999, 2 },
                    { 341, 14, 22, 2, 1723098131.3184733, "Description for product 341", false, 0.0, 21, "Product 341", "product341.jpg", 475.63, 5 },
                    { 342, 38, 23, 3, 1723098131.3184783, "Description for product 342", false, 0.0, 25, "Product 342", "product342.jpg", 401.79000000000002, 12 },
                    { 343, 41, 24, 4, 1723098131.3184788, "Description for product 343", false, 0.0, 39, "Product 343", "product343.jpg", 475.39999999999998, 10 },
                    { 344, 19, 25, 5, 1723098131.3184795, "Description for product 344", false, 0.0, 145, "Product 344", "product344.jpg", 564.55999999999995, 10 },
                    { 345, 35, 26, 6, 1723098131.3184803, "Description for product 345", false, 0.0, 52, "Product 345", "product345.jpg", 540.40999999999997, 11 },
                    { 346, 27, 27, 7, 1723098131.3184807, "Description for product 346", false, 0.0, 136, "Product 346", "product346.jpg", 33.259999999999998, 15 },
                    { 347, 38, 28, 8, 1723098131.3184814, "Description for product 347", false, 0.0, 89, "Product 347", "product347.jpg", 463.41000000000003, 2 },
                    { 348, 69, 29, 9, 1723098131.3184819, "Description for product 348", false, 0.0, 137, "Product 348", "product348.jpg", 223.49000000000001, 8 },
                    { 349, 51, 30, 10, 1723098131.3184829, "Description for product 349", false, 0.0, 79, "Product 349", "product349.jpg", 666.20000000000005, 8 },
                    { 350, 79, 31, 11, 1723098131.3184831, "Description for product 350", false, 0.0, 180, "Product 350", "product350.jpg", 886.05999999999995, 6 },
                    { 351, 79, 32, 12, 1723098131.3184841, "Description for product 351", false, 0.0, 59, "Product 351", "product351.jpg", 343.38, 9 },
                    { 352, 28, 33, 13, 1723098131.3184845, "Description for product 352", false, 0.0, 33, "Product 352", "product352.jpg", 436.92000000000002, 14 },
                    { 353, 77, 34, 14, 1723098131.3184853, "Description for product 353", false, 0.0, 95, "Product 353", "product353.jpg", 996.48000000000002, 15 },
                    { 354, 58, 35, 15, 1723098131.3184857, "Description for product 354", false, 0.0, 77, "Product 354", "product354.jpg", 460.52999999999997, 11 },
                    { 355, 72, 36, 16, 1723098131.3184865, "Description for product 355", false, 0.0, 96, "Product 355", "product355.jpg", 813.75999999999999, 3 },
                    { 356, 30, 37, 17, 1723098131.3184924, "Description for product 356", false, 0.0, 164, "Product 356", "product356.jpg", 69.819999999999993, 16 },
                    { 357, 94, 38, 18, 1723098131.3184931, "Description for product 357", false, 0.0, 72, "Product 357", "product357.jpg", 794.37, 13 },
                    { 358, 50, 39, 19, 1723098131.3184936, "Description for product 358", false, 0.0, 158, "Product 358", "product358.jpg", 196.66999999999999, 7 },
                    { 359, 83, 40, 20, 1723098131.3184943, "Description for product 359", false, 0.0, 56, "Product 359", "product359.jpg", 377.24000000000001, 8 },
                    { 360, 94, 1, 1, 1723098131.318495, "Description for product 360", false, 0.0, 165, "Product 360", "product360.jpg", 792.55999999999995, 2 },
                    { 361, 97, 2, 2, 1723098131.3184955, "Description for product 361", false, 0.0, 172, "Product 361", "product361.jpg", 894.92999999999995, 12 },
                    { 362, 6, 3, 3, 1723098131.3184962, "Description for product 362", false, 0.0, 65, "Product 362", "product362.jpg", 447.63999999999999, 6 },
                    { 363, 65, 4, 4, 1723098131.3184967, "Description for product 363", false, 0.0, 143, "Product 363", "product363.jpg", 152.22999999999999, 14 },
                    { 364, 75, 5, 5, 1723098131.3184977, "Description for product 364", false, 0.0, 45, "Product 364", "product364.jpg", 187.44999999999999, 1 },
                    { 365, 39, 6, 6, 1723098131.3184979, "Description for product 365", false, 0.0, 102, "Product 365", "product365.jpg", 570.17999999999995, 18 },
                    { 366, 27, 7, 7, 1723098131.3184988, "Description for product 366", false, 0.0, 170, "Product 366", "product366.jpg", 51.969999999999999, 3 },
                    { 367, 49, 8, 8, 1723098131.3184991, "Description for product 367", false, 0.0, 150, "Product 367", "product367.jpg", 666.82000000000005, 19 },
                    { 368, 52, 9, 9, 1723098131.3185, "Description for product 368", false, 0.0, 101, "Product 368", "product368.jpg", 356.25999999999999, 11 },
                    { 369, 4, 10, 10, 1723098131.3185005, "Description for product 369", false, 0.0, 167, "Product 369", "product369.jpg", 746.19000000000005, 16 },
                    { 370, 97, 11, 11, 1723098131.3185041, "Description for product 370", false, 0.0, 127, "Product 370", "product370.jpg", 140.47, 15 },
                    { 371, 33, 12, 12, 1723098131.3185043, "Description for product 371", false, 0.0, 109, "Product 371", "product371.jpg", 430.67000000000002, 9 },
                    { 372, 39, 13, 13, 1723098131.3185053, "Description for product 372", false, 0.0, 33, "Product 372", "product372.jpg", 767.40999999999997, 8 },
                    { 373, 66, 14, 14, 1723098131.3185058, "Description for product 373", false, 0.0, 108, "Product 373", "product373.jpg", 882.82000000000005, 13 },
                    { 374, 79, 15, 15, 1723098131.3185065, "Description for product 374", false, 0.0, 120, "Product 374", "product374.jpg", 75.489999999999995, 6 },
                    { 375, 75, 16, 16, 1723098131.3185072, "Description for product 375", false, 0.0, 194, "Product 375", "product375.jpg", 614.88999999999999, 8 },
                    { 376, 19, 17, 17, 1723098131.3185079, "Description for product 376", false, 0.0, 108, "Product 376", "product376.jpg", 561.97000000000003, 11 },
                    { 377, 80, 18, 18, 1723098131.3185084, "Description for product 377", false, 0.0, 90, "Product 377", "product377.jpg", 88.090000000000003, 11 },
                    { 378, 58, 19, 19, 1723098131.3185091, "Description for product 378", false, 0.0, 165, "Product 378", "product378.jpg", 17.18, 2 },
                    { 379, 75, 20, 20, 1723098131.3185096, "Description for product 379", false, 0.0, 185, "Product 379", "product379.jpg", 869.98000000000002, 1 },
                    { 380, 44, 21, 1, 1723098131.3185103, "Description for product 380", false, 0.0, 52, "Product 380", "product380.jpg", 948.11000000000001, 14 },
                    { 381, 4, 22, 2, 1723098131.3185108, "Description for product 381", false, 0.0, 76, "Product 381", "product381.jpg", 579.42999999999995, 8 },
                    { 382, 2, 23, 3, 1723098131.3185115, "Description for product 382", false, 0.0, 160, "Product 382", "product382.jpg", 775.25999999999999, 12 },
                    { 383, 62, 24, 4, 1723098131.318512, "Description for product 383", false, 0.0, 159, "Product 383", "product383.jpg", 201.91999999999999, 6 },
                    { 384, 79, 25, 5, 1723098131.3185155, "Description for product 384", false, 0.0, 72, "Product 384", "product384.jpg", 25.859999999999999, 17 },
                    { 385, 89, 26, 6, 1723098131.3185165, "Description for product 385", false, 0.0, 167, "Product 385", "product385.jpg", 185.25999999999999, 7 },
                    { 386, 9, 27, 7, 1723098131.318517, "Description for product 386", false, 0.0, 28, "Product 386", "product386.jpg", 319.19999999999999, 19 },
                    { 387, 16, 28, 8, 1723098131.3185177, "Description for product 387", false, 0.0, 27, "Product 387", "product387.jpg", 326.30000000000001, 17 },
                    { 388, 24, 29, 9, 1723098131.3185184, "Description for product 388", false, 0.0, 194, "Product 388", "product388.jpg", 211.56999999999999, 7 },
                    { 389, 24, 30, 10, 1723098131.3185189, "Description for product 389", false, 0.0, 177, "Product 389", "product389.jpg", 372.04000000000002, 11 },
                    { 390, 28, 31, 11, 1723098131.3185196, "Description for product 390", false, 0.0, 48, "Product 390", "product390.jpg", 358.94, 4 },
                    { 391, 96, 32, 12, 1723098131.3185201, "Description for product 391", false, 0.0, 75, "Product 391", "product391.jpg", 600.65999999999997, 19 },
                    { 392, 53, 33, 13, 1723098131.3185208, "Description for product 392", false, 0.0, 96, "Product 392", "product392.jpg", 773.91999999999996, 12 },
                    { 393, 10, 34, 14, 1723098131.3185215, "Description for product 393", false, 0.0, 114, "Product 393", "product393.jpg", 462.14999999999998, 11 },
                    { 394, 26, 35, 15, 1723098131.318522, "Description for product 394", false, 0.0, 146, "Product 394", "product394.jpg", 22.27, 15 },
                    { 395, 60, 36, 16, 1723098131.3185227, "Description for product 395", false, 0.0, 166, "Product 395", "product395.jpg", 123.01000000000001, 19 },
                    { 396, 51, 37, 17, 1723098131.3185232, "Description for product 396", false, 0.0, 169, "Product 396", "product396.jpg", 951.45000000000005, 14 },
                    { 397, 68, 38, 18, 1723098131.3185239, "Description for product 397", false, 0.0, 49, "Product 397", "product397.jpg", 14.66, 13 },
                    { 398, 56, 39, 19, 1723098131.3185272, "Description for product 398", false, 0.0, 126, "Product 398", "product398.jpg", 557.97000000000003, 13 },
                    { 399, 13, 40, 20, 1723098131.3185279, "Description for product 399", false, 0.0, 148, "Product 399", "product399.jpg", 10.52, 17 },
                    { 400, 9, 1, 1, 1723098131.3185284, "Description for product 400", false, 0.0, 185, "Product 400", "product400.jpg", 848.79999999999995, 7 }
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
