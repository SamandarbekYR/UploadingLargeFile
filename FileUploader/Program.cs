using FileUploader.BusinecLogicsLayer.Interfaces;
using FileUploader.BusinecLogicsLayer.Services;
using FileUploader.Connection;
using FileUploader.DataAccessLayer.Interfaces;
using FileUploader.DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.DbConnection();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IPersonService, PersonServices>();
builder.Services.AddTransient<IFileService, FileService>();
//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.Limits.MaxRequestBodySize = 700 * 1024 * 1024;
//});

builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 700 * 1024 * 1024;
});

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
