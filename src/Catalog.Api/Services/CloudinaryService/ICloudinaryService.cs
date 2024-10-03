using Catalog.Api.Services;

namespace Catalog.Api.Service.CloudinaryService
{
    public interface ICloudinaryService
    {
        Task<Uri> UploadImage(string fileName, Stream steam);
        Task<ServiceResult> DeleteImage(int productId);
    }
}