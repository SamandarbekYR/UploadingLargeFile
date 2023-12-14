using FileUploader.BusinecLogicsLayer.Common;
using FileUploader.BusinecLogicsLayer.Interfaces;

namespace FileUploader.BusinecLogicsLayer.Services
{
    public class FileService : IFileService
    {
        private readonly string MEDIA = "Media";
        private readonly string IMAGES = "Images";
        private readonly string ROOTPATH;

        public FileService(IWebHostEnvironment webHost)
        {
            ROOTPATH = webHost.WebRootPath;
        }
        public Task<bool> DeleteImageAsync(string subpath)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadImageAsync(IFormFile image, string rootpath)
        {
            string newImageName = MediaHelper.MakeImageName(image.FileName);
            string subPath = Path.Combine(MEDIA, IMAGES, rootpath, newImageName);
            string path = Path.Combine(ROOTPATH, subPath);
            var stream = new FileStream(path, FileMode.Create);
            await image.CopyToAsync(stream);
            stream.Close();

            return subPath;
        }
    }
}
