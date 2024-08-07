using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using dotenv.net;

namespace EShop.Api.Services.CloudinaryService
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService()
        {
            DotEnv.Load(options: new DotEnvOptions(probeForEnv: true));
            _cloudinary = new Cloudinary(Environment.GetEnvironmentVariable("CLOUDINARY_URL"));
            _cloudinary.Api.Secure = true;
        }

        public async Task UploadProductImage(int productId, string fileName, Stream stream)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(fileName, stream),
                Folder = $"EShop/Products/{productId}"
            };
            var result = _cloudinary.Upload(uploadParams);
            Console.WriteLine(result.JsonObj);
        }

        public async Task GetAllProductImages(int productId)
        {
            var assetFolderResult = await _cloudinary.ListResourceByAssetFolderAsync($"EShop/Products/{productId}", true, true, true);
            Console.WriteLine(assetFolderResult);
        }

        public async Task DeleteImage(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
