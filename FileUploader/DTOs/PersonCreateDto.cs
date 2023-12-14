namespace FileUploader.DTOs
{
    public class PersonCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public IFormFile Images { get; set; } 
    }
}
