using HealthChecks.UI.Client;
using Orion.WebApps.HealthCheck;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services
.AddHealthChecks()
.AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));


//builder.Services
//    .AddHealthChecksUI(options =>
//    {
//        options.AddHealthCheckEndpoint("Healthcheck API", "/healthcheck");
//    })
//    .AddInMemoryStorage();


var app = builder.Build();

app.MapHealthChecks("/healthcheck", new()
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});

app.MapHealthChecksUI(options => options.UIPath = "/dashboard");

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
