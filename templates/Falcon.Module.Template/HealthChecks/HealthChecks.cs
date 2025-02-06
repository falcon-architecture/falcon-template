namespace { RootNamespace }.{ ModuleName}.HealthChecks;

public class { ModuleName }HealthChecks: IHealthCheck
{
    public{ ModuleName }HealthChecks() { }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {   bool isHealthy = true;
        // Add your health check logic here
        if (isHealthy)
        {
            throw new NotImplementedException();
        }
        catch(Exception exception)
        {
            return HealthCheckResult.Unhealthy(exception.Message, exception);
        }
        return HealthCheckResult.Healthy("Successfully connected");
    }
}