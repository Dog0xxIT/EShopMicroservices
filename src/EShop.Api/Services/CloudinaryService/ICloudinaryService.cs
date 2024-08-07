namespace EShop.Api.Services.CloudinaryService;

public interface ICloudinaryService
{
    Task UploadProductImage(int productId, string fileName, Stream steam);
    Task GetAllProductImages(int productId);
    Task DeleteImage(int productId);
}