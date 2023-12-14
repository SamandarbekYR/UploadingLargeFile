namespace FileUploader.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        public IPerson Person { get; }
        public IPersonImages PersonImages { get; }

        public int SaveChanges();
       
    }
}
