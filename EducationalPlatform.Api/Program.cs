using EducationalPlatform.Application.Handlers.Lectures;
using EducationalPlatform.Core.Interfaces;
using EducationalPlatform.Infrastructure;
using EducationalPlatform.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EducationalPlatform.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
       builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        builder.Services.AddScoped<ILectureRepository, LectureRepository>();
        builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(GetLecturesByLevelHandler).Assembly));

        builder.Services.AddScoped<ILectureRepository, LectureRepository>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

       

        app.Run();
    }
}