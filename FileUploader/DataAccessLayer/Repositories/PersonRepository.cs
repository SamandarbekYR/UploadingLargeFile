using FileUploader.DataAccessLayer.AppDbContext;
using FileUploader.DataAccessLayer.Interfaces;
using FileUploader.Entities;

namespace FileUploader.DataAccessLayer.Repositories
{
    public class PersonRepository : Repository<Person>, IPerson
    {
        public PersonRepository(AppDb appDb) : base(appDb)
        { }
    }
}
