using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace Application_Layer.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletionPhotoAsync(string publicid);
    }
}
