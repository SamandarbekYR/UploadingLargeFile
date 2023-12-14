namespace FileUploader.BusinecLogicsLayer.Interfaces
{
    public interface IFileService
    {
        public Task<string> UploadImageAsync(IFormFile image, string rootpath);
        public Task<bool> DeleteImageAsync(string subpath);
    }
}
