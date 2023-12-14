using FileUploader.DataAccessLayer.AppDbContext;
using FileUploader.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;

namespace FileUploader.DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> _dbSet;

        public Repository(AppDb appDb)
        {
            _dbSet = appDb.Set<T>();
        }
        public void CreateAsync(T entity) =>  _dbSet.Add(entity);
        public async Task<T> GetById(Expression<Func<T, bool>> expression) => await _dbSet.FirstOrDefaultAsync(expression)!;
    }
}
