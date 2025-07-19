using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.Services.StockAnalyzer.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add EF Core with PostgreSQL
builder.Services.AddDbContext<StockAnalyzerContext>(options =>
    options.UseNpgsql(connectionString));

// Register repositories and services
builder.Services.AddScoped<ILatestModelRepository, LatestModelRepository>();
// builder.Services.AddHttpClient<TradingEconomicsMarketService>();

// Add controller support
builder.Services.AddControllers();

// Swagger support
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

// Optional: Add authentication here if used
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();