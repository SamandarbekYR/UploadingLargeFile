using FileUploader.DataAccessLayer.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace FileUploader.Connection
{
    public static class DatabaseConnection
    {
        public static void DbConnection (this WebApplicationBuilder builder)
        {
            string connection = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder.Services.AddDbContext<AppDb>(options => options.UseNpgsql(connection));
        }

    }
}
