namespace { RootNamespace }.{ ModuleName}.HealthChecks;

public class { ModuleName }HealthChecks: IHealthCheck
{
    public{ ModuleName }HealthChecks() { }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {   
        try
        {
            // Add your health check logic here
            return HealthCheckResult.Healthy("<> server is healthy");
        }
        catch(Exception exception)
        {
            return HealthCheckResult.Unhealthy(exception.Message, exception);
        }
    }
}