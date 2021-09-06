using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ZeroXTeam.Services
{
    public class PhotoUploadResult 
    {
        public string PublicId { get; set; }
        public string ImageUrl { get; set; }
    }

    public class PhotoUploadService
    {
        private readonly IConfiguration _config;
        private Cloudinary _cloudinary;

        public PhotoUploadService(IConfiguration config)
        {
            _config = config;
            Account account = new Account(
                _config["Cloudinary:Name"],
                _config["Cloudinary:Key"],
                _config["Cloudinary:Secret"]
            );

            _cloudinary = new Cloudinary(account);
            _cloudinary.Api.Secure = true;
        }

        public async Task<PhotoUploadResult> UploadImage(
            IFormFile file, 
            int height = 550, 
            int width = 1345
        )
        {
            var stream = file.OpenReadStream();

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, stream),
                Transformation = new Transformation()
                    .Height(height).Width(width).Crop("fill").Gravity("face")
            };

            var result = await _cloudinary.UploadAsync(uploadParams);

            if (result.Error != null)
            {
                return null;
            }

            return new PhotoUploadResult()
            {
                PublicId = result.PublicId,
                ImageUrl = result?.Url?.AbsoluteUri
            };
        }

        public async Task<bool> DeleteImage(string publicId)
        {
            var destroyParams = new DeletionParams(publicId);

            var result = await _cloudinary.DestroyAsync(destroyParams);

            return result.Error == null;
        }
    }
}