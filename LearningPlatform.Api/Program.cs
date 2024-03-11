
using LearningPlatform.DataAccess.Postgres;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<LearningDbContext>(
                options =>
                {
                    options.UseNpgsql(configuration.GetConnectionString(nameof(LearningDbContext)));
                });

            var app = builder.Build();


            app.UseSwagger();
            app.UseSwaggerUI();



        }
    }
}
