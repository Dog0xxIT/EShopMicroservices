using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using dotenv.net;
using EShop.Application.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace EShop.Infrastructure.Services
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;
        private readonly ILogger<CloudinaryService> _logger;

        public CloudinaryService(ILogger<CloudinaryService> logger)
        {
            _logger = logger;
            DotEnv.Load(options: new DotEnvOptions(probeForEnv: true));
            _cloudinary = new Cloudinary(Environment.GetEnvironmentVariable("CLOUDINARY_URL"));
            _cloudinary.Api.Secure = true;
        }

        public async Task<Uri> UploadProductImage(int productId, string fileName, Stream stream)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(fileName, stream),
                Folder = $"EShop/Products/{productId}"
            };
            var result = await _cloudinary.UploadAsync(uploadParams);
            _logger.LogInformation(result.JsonObj.ToString());
            return result.SecureUrl;
        }

        public async Task GetAllProductImages(int productId)
        {
            var assetFolderResult = await _cloudinary.ListResourceByAssetFolderAsync($"EShop/Products/{productId}", true, true, true);
            _logger.LogInformation(assetFolderResult.JsonObj.ToString());
        }

        public async Task DeleteImage(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
