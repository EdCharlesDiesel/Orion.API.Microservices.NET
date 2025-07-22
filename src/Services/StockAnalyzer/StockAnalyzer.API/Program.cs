using FastEndpoints;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Mappings;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.Services.StockAnalyzer.API.Repositories;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); // ✅ Fixes timestamp issues with Npgsql

var builder = WebApplication.CreateBuilder(args);

// ✅ Configuration
var configuration = builder.Configuration;
string connectionString = configuration.GetConnectionString("DefaultConnection");

// ✅ Add EF Core with PostgreSQL
builder.Services.AddDbContext<StockAnalyzerContext>(options =>
    options.UseNpgsql(connectionString));

// ✅ Register application services
builder.Services.AddScoped<ILatestModelRepository, LatestModelRepository>();
builder.Services.AddScoped<CalendarRepository>();
builder.Services.AddAutoMapper(typeof(CalendarEventProfile));
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddFastEndpoints();

// ✅ Add HTTP client support if needed
builder.Services.AddHttpClient(); // Or named client if needed

// ✅ Add controller support
builder.Services.AddControllers();

// ✅ Swagger configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseFastEndpoints();
// ✅ Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Better error info in dev
    app.UseSwagger();
    app.UseSwaggerUI();
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