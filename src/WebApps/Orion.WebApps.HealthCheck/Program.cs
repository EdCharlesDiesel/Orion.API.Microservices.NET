using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Orion.WebApps.HealthCheck;

var builder = WebApplication.CreateBuilder(args);

// Add controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Required for Swagger UI
builder.Services.AddSwaggerGen();     

// Add health checks
builder.Services
    .AddHealthChecks()
    .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));



// Add HealthChecks UI with in-memory storage
builder.Services
    .AddHealthChecksUI(options =>
    {
        options.AddHealthCheckEndpoint("Healthcheck API", "/healthcheck");
    })
    .AddInMemoryStorage();


var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Authorization (optional if you're not securing endpoints)
app.UseAuthorization();

// Health check endpoint
app.MapHealthChecks("/healthcheck", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

// Health checks dashboard
app.MapHealthChecksUI(options =>
{
    options.UIPath = "/dashboard";
});

// Map controllers
app.MapControllers();

app.Run();