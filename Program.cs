
using System.Text;
using DotNetEnv;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ReservApi.Data;
using ReservApi.Repositories;
using ReservApi.Services;
using ReservApi.Utilities;

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

         //Adding JWT
        builder.Services.AddSingleton<JWT>();
        builder.Services.AddAuthentication(config =>
        {
            config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(config =>
        {
            config.RequireHttpsMetadata = false;
            config.SaveToken = true;
            config.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = Environment.GetEnvironmentVariable("JWTISSUER"),
                ValidateAudience = false,
                ValidAudience = Environment.GetEnvironmentVariable("JWTAUDIENCE"),
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWTKEY")!))
            };
        });



        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Crud JWT", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
        });

        //ading scopes
        builder.Services.AddScoped<IBookingRepository,BookingServices >();
        builder.Services.AddScoped<IEmployeeRepository,EmployeeServices >();
        builder.Services.AddScoped<IGuestRepository,GuestServices >();
        builder.Services.AddScoped<IRoomRepository,RoomServices >();
        builder.Services.AddScoped<IRoomTypeRepository,RoomTypeServices >();

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
