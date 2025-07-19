using Microsoft.OpenApi.Models;
using Orion.Services.Catalog.API.Data;
using Orion.Services.Catalog.API.Repositories;

namespace Orion.Services.Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                 c.SwaggerDoc("v1", new OpenApiInfo
                 {
                     Title = "Catalog API",
                     Description = null,
                     Version = "v1",
                     TermsOfService = null,
                     Contact = null,
                     License = null,
                     Extensions = null
                 });
            });
            
            builder.Services.AddScoped<ICatalogContext, CatalogContext>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            var app = builder.Build();

            app.UseAuthorization();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Catalog API V1");
                });
            }

            app.MapControllers();

            app.Run();
        }
    }
}