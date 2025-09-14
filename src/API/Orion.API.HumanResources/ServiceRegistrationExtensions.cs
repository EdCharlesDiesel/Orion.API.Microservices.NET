

using Microsoft.EntityFrameworkCore;
using Orion.API.HumanResources.Business;
using Orion.DataAccess.Postgres.Data;
using Orion.DataAccess.Postgres.Repositories;
using Orion.DataAccess.Postgres.Tools;

namespace Orion.API.HumanResources
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterBusinessServices(
            this IService
                collection services)
        {
            services.AddScoped<IEmployeeService, E>();
            services.AddScoped<IPromotionService, PromotionService>();
            services.AddScoped<EmployeeFactory>(); 
            return services;
        }
    
        public static IServiceCollection RegisterHumanResourcesServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            // add the DbContext
            object config;
            services.AddDbContext<OrionDbContext>(options =>
                options.UseNpgsql(config.GetConnectionString("DefaultConnection")));
    
            // register the repository
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            // services.AddScoped<IEmployeeManagementRepository, EmployeeManagementRepository>();
            return services;
        }
    }

    public interface IService
    {
    }
}
