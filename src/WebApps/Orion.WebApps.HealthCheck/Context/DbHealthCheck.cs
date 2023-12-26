using Devart.Data.PostgreSql;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Orion.WebApps.HealthCheck.Context
{
    public class DbHealthCheckIHealthCheck:IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                using (PgSqlConnection pgSqlConnection =
                     new PgSqlConnection("User Id = postgres; Password = postgres;" +
                     "host=localhost;database=Demo;"))
                {
                    if (pgSqlConnection.State !=
                        System.Data.ConnectionState.Open)
                        pgSqlConnection.Open();

                    if (pgSqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        pgSqlConnection.Close();
                        return Task.FromResult(
                        HealthCheckResult.Healthy("The database is up and running."));
                    }
                }

                return Task.FromResult(
                      new HealthCheckResult(
                      context.Registration.FailureStatus, "The database is down."));
            }
            catch (Exception)
            {
                return Task.FromResult(
                    new HealthCheckResult(
                        context.Registration.FailureStatus, "The database is down."));
            }
        }
    }
}
