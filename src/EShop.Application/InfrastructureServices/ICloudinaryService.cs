namespace EShop.Application.Services
{
    public interface ICloudinaryService
    {
        Task<Uri> UploadProductImage(int productId, string fileName, Stream steam);
        Task GetAllProductImages(int productId);
        Task DeleteImage(int productId);
    }
}