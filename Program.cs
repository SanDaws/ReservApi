
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using ReservApi.Data;

namespace ReservApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        //dbContext
        Env.Load();
        var ServerModuleConection = $"server={Environment.GetEnvironmentVariable("HOST")};" +
                                   $"port={Environment.GetEnvironmentVariable("PORT")};" +
                                   $"database={Environment.GetEnvironmentVariable("DATABASE")};" +
                                   $"uid={Environment.GetEnvironmentVariable("USER")};" +
                                   $"password={Environment.GetEnvironmentVariable("PASSWORD")}";
        builder.Services.AddDbContext<ReserverDbContext>(options => options.UseMySql(ServerModuleConection, ServerVersion.Parse("8.0.20-mysql")));// case using MySQl

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
