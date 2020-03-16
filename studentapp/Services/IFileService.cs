using Microsoft.AspNetCore.Http;

namespace studentapps.Services
{
    public interface IFileService
    {
        string Upload(IFormFile file);
    }
}