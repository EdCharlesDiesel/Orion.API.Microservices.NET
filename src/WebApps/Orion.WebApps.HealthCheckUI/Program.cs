var builder = WebApplication.CreateBuilder(args);

// Register PostgreSQL health check
builder.Services.AddHealthChecks()
    .AddNpgSql(builder.Configuration.GetConnectionString("DefaultConnection"), name: "postgresql");

// Add HealthChecks UI with PostgreSQL storage
builder.Services.AddHealthChecksUI(opt =>
    {
        opt.SetEvaluationTimeInSeconds(10); // frequency
        opt.AddHealthCheckEndpoint("API", "/health");
    })
    .AddPostgreSqlStorage(builder.Configuration.GetConnectionString("DefaultConnection"));

var app = builder.Build();

app.MapGet("/", () => "HealthCheck API");

app.MapHealthChecks("/health");
app.MapHealthChecksUI(options =>
{
    options.UIPath = "/health-ui";
});

app.Run();