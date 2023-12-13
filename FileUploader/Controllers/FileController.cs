using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace FileUploader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]
      //  [RequestSizeLimit(700* 1024 * 1024)]
        public IActionResult File(IFormFile file)
        {
            var fileMb = file.Length / (1024 * 1024);

            // Assuming you want to return the file size as a string
            return Content($"{fileMb} MB");
        }

    }
}
