using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HotelListing.API.Services
{
    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = true;

            // ... custom checks. Logic...

            if (isHealthy)
                return Task.FromResult(HealthCheckResult.Healthy("All systems are looking good"));

            return Task.FromResult(new HealthCheckResult(context.Registration.FailureStatus, "System Unhealthy"));
        }
    }
}
