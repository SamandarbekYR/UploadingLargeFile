using System.Linq.Expressions;

namespace FileUploader.DataAccessLayer.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void CreateAsync(T entity);
        Task<T> GetById(Expression<Func<T, bool>> expression);
    }
}
