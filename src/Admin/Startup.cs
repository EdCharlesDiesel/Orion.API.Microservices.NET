using Orion.DataAccess.Extensions;
using DDD.ApplicationLayer;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Orion.DataAccess.Models;
using Orion.DataAccess.Contexts;
using Orion.Domain.IRepositories;
using Orion.Domain.Utility;
using Orion.DataAccess.Interfaces;
using Orion.DataAccess.Services;
using Microsoft.Identity.Client;
using Orion.DataAccess.SqlServer;
using Orion.Admin.Controllers;
using Orion.Admin.Security;
using Orion.DataAccess.Strategy;
using Orion.DataAccess.AllFeatures;

namespace Orion.Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<OrionDbContext>(options =>
                            options.UseSqlServer(
                                Configuration.GetConnectionString("Orion_Default_Windows_ConnectionString")));

            services.AddIdentity<MasterUser, IdentityRole<int>>(options =>
                {
                    options.Password.RequiredLength = 2;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequiredUniqueChars = 0;
                })
                .AddRoleManager<RoleManager<IdentityRole<int>>>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<OrionDbContext>();

            RegisterTypes(services);

            services.AddMvc()
                .AddXmlSerializerFormatters();
            
 
            
            services.AddAuthorization(options =>
            {
                options.AddPolicy(SecurityConstants.PolicyName_EditBusinessOwner,
                                  policy => policy.Requirements.Add(
                                      new EditBusinessOwnerRequirement()));
            });

            services.AddSingleton<IAuthorizationHandler, EditBusinessOwnerHandler>(); 


            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbLayer(Configuration.GetConnectionString("Orion_Default_Windows_ConnectionString"),
                "Orion_MainDb");

            services.AddAllQueries(this.GetType().Assembly);
            services.AddAllCommandHandlers(this.GetType().Assembly);
            services.AddAllEventHandlers(this.GetType().Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

                     

          //  CheckDatabaseHasBeenDeployed(app);

            var ci = new CultureInfo("en-za");

            // Configure the Localization middleware
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo>
                {
                    ci,
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    ci,
                }
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            app.UsePopulateSubscriptionClaimsMiddleware();

            // app.UseMvc(routes =>
            // {
            //     routes.MapRoute(
            //         name: "default",
            //         template: "{controller=BusinessOwner}/{action=Index}/{id?}");
            // });
        }

        private void CheckDatabaseHasBeenDeployed(IApplicationBuilder app)
        {
            using (var scope =
                app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = scope.ServiceProvider.GetService<OrionDbContext>())
                {
                    context?.Database.Migrate();
                }

                using (var context = scope.ServiceProvider.GetService<OrionDbContext>())
                {
                    context?.Database.Migrate();
                }
            }
        }

        void RegisterTypes(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddTransient<IUsernameProvider, HttpContextUsernameProvider>();

            services.AddTransient<IFeatureManager, FeatureManager>();

            services.AddTransient<ILogger, Logger>();

            services.AddDbContext<OrionDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Orion_Default_Windows_ConnectionString")));

           //services.AddTransient<IOrionDbContext, OrionDbContext>();

            //services.AddTransient<IRepository<Person>, SqlEntityFrameworkPersonRepository>();

            services.AddTransient<IValidatorStrategy<BusinessOwner>, DefaultValidatorStrategy<BusinessOwner>>();
            
            services.AddTransient<IDaysInOfficeStrategy, DefaultDaysInOfficeStrategy>();

            services.AddTransient<IFeatureRepository, SqlEntityFrameworkFeatureRepository>();

            services.AddTransient<IBusinessOwnerService, BusinessOwnerService>();

            services.AddTransient<ISubscriptionService, SubscriptionService>();

            services.AddTransient<ITestDataUtility, TestDataUtility>();

            services.AddTransient<PopulateSubscriptionClaimsMiddleware>();

            services.AddTransient<IUserAuthorizationStrategy, DefaultUserAuthorizationStrategy>();

            services.AddTransient<IUserClaimsPrincipalProvider, 
                HttpContextUserClaimsPrincipalProvider>();            
        }
    }   
}


