using FileUploader.BusinecLogicsLayer.Interfaces;
using FileUploader.DataAccessLayer.Interfaces;
using FileUploader.DTOs;
using FileUploader.Entities;

namespace FileUploader.BusinecLogicsLayer.Services
{
    public class PersonServices : IPersonService
    {

        private readonly string PERSONIMAGES = "PersonImages";
        private IUnitOfWork _dbSet;
        private IFileService _fileService;

        public PersonServices(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _dbSet = unitOfWork;
            _fileService = fileService;

        }
        public async Task<bool> AddAsync(PersonCreateDto dto)
        {
            Person person = new Person();
            person.Name = dto.Name;
             _dbSet.Person.CreateAsync(person);
            int res = _dbSet.SaveChanges();

            var model = await _dbSet.Person.GetById(p => p.Name == dto.Name);
            int i = 0;

            //if (res > 0)
            //{
            //    foreach (var image in dto.Images)
            //    {

            //        var imgPath = await _fileService.UploadImageAsync(image, PERSONIMAGES);

            //        PersonImages images = new PersonImages();
            //        images.ImagePath = imgPath;
            //        images.PersonId = model.Id;
            //         _dbSet.PersonImages.CreateAsync(images);
            //    }
            //    i = _dbSet.SaveChanges();
            //}

            if (i > 0)
            {
                return true;
            }

            return false;
        }
    }
}
