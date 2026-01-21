namespace AuthServiceIN6BV.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData ImagenFile,string fileName);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagenPath);
    
}