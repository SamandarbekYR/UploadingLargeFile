using FileUploader.BusinecLogicsLayer.Common;
using FileUploader.DTOs;
using FluentValidation;

namespace FileUploader.Validators
{
    public class UserCreateValidator : AbstractValidator<PersonCreateDto>
    {
        public UserCreateValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("Doim kritishi kerak")
                .MinimumLength(3).WithMessage("name 3 ta charakterdan ko'proq bo'ishi kerak")
                    .MaximumLength(50).WithMessage("name 50 ta charakterdan kam bo'lishi kerak");
            
            RuleFor(dto => dto.Images ).SetValidator(new FileValidator());
        }
    }
}
