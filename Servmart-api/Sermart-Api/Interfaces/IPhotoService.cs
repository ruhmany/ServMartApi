using CloudinaryDotNet.Actions;

namespace Sermart_Api.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletionPhotoAsync(string publicid);
    }
}
