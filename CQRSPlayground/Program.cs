
using CQRSPlayground.RLL;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Services
            builder.Services.AddScoped<IProductRLL,ProductRLL>();
            builder.Services.AddMediatR(typeof(Program).Assembly);
            builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("PlayerDBConnection")));
            
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
}
