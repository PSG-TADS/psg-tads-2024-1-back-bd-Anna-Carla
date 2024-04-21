using Microsoft.EntityFrameworkCore;
using LocadoraDeVeiculosAPI.Models;

namespace LocadoraDeVeiculosAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            var connectionString = @"Server=.\SQLEXPRESS;Database=ORM;Trusted_Connection=True;TrustServerCertificate=true;";

        
            builder.Services.AddDbContext<LocadoraContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
}
