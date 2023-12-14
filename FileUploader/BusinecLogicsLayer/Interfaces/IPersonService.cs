using FileUploader.DTOs;

namespace FileUploader.BusinecLogicsLayer.Interfaces
{
    public interface IPersonService
    {
        Task<bool> AddAsync(PersonCreateDto dto);
    }
}
