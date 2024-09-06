using EShop.Application.Services.ApplicationService;

namespace EShop.Application.Services.Interfaces
{
    public interface ICloudinaryService
    {
        Task<Uri> UploadProductImage(int productId, string fileName, Stream steam);
        Task<IEnumerable<string>> GetAllImagesByProductId(int productId);
        Task<ServiceResult> DeleteImage(int productId);
    }
}