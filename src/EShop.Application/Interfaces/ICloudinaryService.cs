namespace EShop.Application.Interfaces
{
    public interface ICloudinaryService
    {
        Task<Uri> UploadImage(string fileName, Stream steam);
        Task<ServiceResult> DeleteImage(int productId);
    }
}