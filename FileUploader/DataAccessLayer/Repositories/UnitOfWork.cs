using FileUploader.DataAccessLayer.AppDbContext;
using FileUploader.DataAccessLayer.Interfaces;

namespace FileUploader.DataAccessLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDb _dbSet;
        public IPerson Person { get; }
        public IPersonImages PersonImages { get; }
        public UnitOfWork(AppDb appDb)
        {
            this._dbSet = appDb;
            this.Person = new PersonRepository(appDb);
            this.PersonImages = new PersonImagesRepository(appDb);
        }
        public int SaveChanges()
        {
           return _dbSet.SaveChanges();
        }
    }
}
