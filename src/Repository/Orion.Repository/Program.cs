using Microsoft.EntityFrameworkCore;
using Orion.Repository.Data;


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // ✅ Fixes timestamp issues with Npgsql

var builder = WebApplication.CreateBuilder(args);

// ✅ Configuration
var configuration = builder.Configuration;
string connectionString = configuration.GetConnectionString("DefaultConnection");

// ✅ Add EF Core with PostgreSQL
builder.Services.AddDbContext<OrionDbContext>(options =>
    options.UseNpgsql(connectionString));

// ✅ Register application services

// builder.Services.AddScoped<ICalendarServices,CalendarRepository>();
// builder.Services.AddScoped<IComtradeServices, ComtradeRepository>();
// builder.Services.AddScoped<IForecastServices, ForecastRepository>();
// builder.Services.AddAutoMapper(typeof(CalendarEventProfile));

// ✅ Add HTTP client support if needed
builder.Services.AddHttpClient(); // Or named client if needed


var app = builder.Build();

// ✅ Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Better error info in dev

}
else
{
    app.UseExceptionHandler("/error"); // Optional: your custom error endpoint
    app.UseHsts(); // Enforce HTTPS in production
}

app.UseHttpsRedirection();

// Optional: add if you configure authentication
// app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();