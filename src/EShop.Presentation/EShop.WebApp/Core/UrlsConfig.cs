namespace EShop.WebApp.Core
{
    public static class UrlsConfig
    {
        public const string ClientName = "EShopApi";

        public static class Identity
        {
            public const string ConfirmEmail = "/Identity/ConfirmEmail";
            public const string ManageInfo = "/Identity/ManageInfo";
            public const string Register = "/Identity/Register";
            public const string SignIn = "/Identity/SignIn";
            public const string SignOut = "/Identity/SignOut";
            public const string RefreshToken = "/Identity/RefreshToken";
            public const string ResendConfirmEmail = "/Identity/ResendConfirmEmail";
            public const string ForgotPassword = "/Identity/ForgotPassword";
            public const string ResetPassword = "/Identity/ResetPassword";
            public const string Manage2Fa = "/Identity/Manage2Fa";
        }

        public static class Catalog
        {
            public const string GetAllProducts = "/Catalog/GetAllProducts";
            public const string GetProductsByAdvanceFilter = "/Catalog/GetProductsByAdvanceFilter";
            public const string GetProductById = "/Catalog/GetProductById";
            public const string GetAllBrands = "/Catalog/GetAllBrands";
            public const string GetAllCategories = "/Catalog/GetAllCategories";
            public const string GetTopCategories = "/Catalog/GetTopCategories";
            public const string GetAllImagesOfProduct = "/Catalog/GetAllImagesOfProduct";
            public const string SearchWithSemanticRelevance = "/Catalog/SearchWithSemanticRelevance";
            public const string UploadProductImage = "/Catalog/UploadProductImage";
            public const string CreateProduct = "/Catalog/CreateProduct";
            public const string CreateBrand = "/Catalog/CreateBrand";
            public const string UpdateProduct = "/Catalog/UpdateProduct";
            public const string UpdateBrand = "/Catalog/UpdateBrand";
        }

        public static class Order
        {
            public const string GetAllByBuyerId = "/Order/GetAllByBuyerId";
            public const string CartTypes = "/Order/CartTypes";
            public const string Create = "/Order/Create";
            public const string CreateDraft = "/Order/CreateDraft";
            public const string Cancel = "/Order/Cancel";
            public const string Ship = "/Order/Ship";
        }

        public static class Basket
        {
            public const string GetBasketByCustomerId = "/Basket/GetBasketByCustomerId";
            public const string UpdateQty = "/Basket/UpdateQty";
            public const string Delete = "/Basket/Delete";
        }
    }
}
