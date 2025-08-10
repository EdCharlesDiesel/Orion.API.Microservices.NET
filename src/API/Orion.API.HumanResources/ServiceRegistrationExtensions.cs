using Orion.API.HumanResources.Business;
using Orion.API.HumanResources.DataAccess.DbContexts;
using Orion.API.HumanResources.DataAccess.Services;

namespace Orion.API.HumanResources
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection RegisterBusinessServices(
            this IServiceC
                ollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPromotionService, PromotionService>();
            services.AddScoped<EmployeeFactory>(); 
            return services;
        }

        public static IServiceCollection RegisterDataServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            // add the DbContext
            services.AddDbContext<HumanResourcesDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("EmployeeManagementDB")));

            // register the repository
            services.AddScoped<IEmployeeManagementRepository, EmployeeManagementRepository>();
            return services;
        }
    }
}
