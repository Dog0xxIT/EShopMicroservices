using EShop.Application.Services.ApplicationService;

namespace EShop.Application.Services.Interfaces
{
    public interface ICloudinaryService
    {
        Task<Uri> UploadImage(string fileName, Stream steam);
        Task<ServiceResult> DeleteImage(int productId);
    }
}