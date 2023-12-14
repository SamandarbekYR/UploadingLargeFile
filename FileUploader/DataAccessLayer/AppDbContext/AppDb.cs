using FileUploader.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileUploader.DataAccessLayer.AppDbContext
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options)
            : base(options)
        { }

        DbSet<Person> Person { get; set; }
        DbSet<PersonImages> PersonImages { get; set; }
    }
}
