using Orion.Services.StockAnalyzer.API.Data;
using Orion.Services.StockAnalyzer.API.Services;
using Microsoft.EntityFrameworkCore;
using Orion.Services.StockAnalyzer.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// builder.Services.AddDbContext<StockAnalyzerContext>(op => op.UseNpgsql(connectionString));


builder.Services.AddControllers();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
// builder.Services.AddScoped<typeof(ILatestModelRepository), typeof(LatestModelRepository);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
