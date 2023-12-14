using FileUploader.BusinecLogicsLayer.Interfaces;
using FileUploader.DTOs;
using FileUploader.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace FileUploader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IPersonService _personService;

        public FileController(IPersonService service)
        {
            this._personService = service;
        }

        [HttpPost("mb")]
      //  [RequestSizeLimit(700* 1024 * 1024)]
        public IActionResult File(IFormFile file)
        {
            var fileMb = file.Length / (1024 * 1024);

            // Assuming you want to return the file size as a string
            return Content($"{fileMb} MB");
        }

        [HttpPost]
        public  async Task<IActionResult> CreatePerson ([FromForm] PersonCreateDto createDto)
        {
            UserCreateValidator validator = new UserCreateValidator();
            var res = validator.Validate(createDto);
            if (res.IsValid)
            {
               // await _personService.AddAsync(createDto);
                return Content("file type to'g'ri kiritdingiz");
            }
            else
            {
                return Content("file type xato kiritdingiz");
            }
        }
    }
}
