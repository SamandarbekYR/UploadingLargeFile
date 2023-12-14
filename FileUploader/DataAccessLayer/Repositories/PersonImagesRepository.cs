using FileUploader.DataAccessLayer.AppDbContext;
using FileUploader.DataAccessLayer.Interfaces;
using FileUploader.Entities;

namespace FileUploader.DataAccessLayer.Repositories
{
    public class PersonImagesRepository : Repository<PersonImages>, IPersonImages
    {
        public PersonImagesRepository(AppDb appDb) : base(appDb)
        { }
    }
}
