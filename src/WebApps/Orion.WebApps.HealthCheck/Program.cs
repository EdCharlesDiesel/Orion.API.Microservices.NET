using System.Net;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Orion.WebApps.HealthCheck;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add health checks
builder.Services
    .AddHealthChecks()
    .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

// Add HealthChecks UI with in-memory storage
builder.Services
    .AddHealthChecksUI(options =>
    {
        options.SetEvaluationTimeInSeconds(15); // Interval between checks
        options.AddHealthCheckEndpoint("Healthcheck API", "/healthcheck");
    })
    .AddInMemoryStorage(); // Use memory; for production consider SQL or Postgres
builder.WebHost.UseWebRoot("wwwroot");
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Optional: use HTTPS redirection and static files if needed
// app.UseHttpsRedirection();

app.UseAuthorization();

// Expose raw health check status (for UI)
app.MapHealthChecks("/healthcheck", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
    ResultStatusCodes =
    {
        [HealthStatus.Healthy] = (int)HttpStatusCode.OK,
        [HealthStatus.Degraded] = (int)HttpStatusCode.OK,
        [HealthStatus.Unhealthy] = (int)HttpStatusCode.ServiceUnavailable
    }
});

// Expose Prometheus metrics for scraping (optional)
app.UseHealthChecksPrometheusExporter("/metrics");

// Expose HealthChecks UI dashboard
app.MapHealthChecksUI(options =>
{
    options.UIPath = "/dashboard";
    options.ApiPath = "/dashboard-api";
});

// Map your controller endpoints
app.MapControllers();

app.Run();