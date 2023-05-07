using Labb4_API.Models;
using Labb4_API.Services;
using Microsoft.EntityFrameworkCore;

namespace Labb4_API {
    public class Program {
        public static void Main(string[] args) {
            //Base of the builder
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IPersonRepo, PersonRepo>();  
            builder.Services.AddScoped<ILinkRepo, LinkRepo>();  

            //EF to SQL
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}