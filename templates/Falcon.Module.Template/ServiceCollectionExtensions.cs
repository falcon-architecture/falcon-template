namespace {RootNamespace}.{ ModuleName };

public static class ServiceCollectionExtensions
{
    private interface IModuleMarker { }
    private sealed class ModuleMarker : IModuleMarker { }

    public static IServiceCollection Add{ ModuleName }Module(this IServiceCollection services, IConfiguration configuration, string configPath)
    {
        services.Configure<{ ModuleName }Options>(configuration.GetSection(configPath));
        return services.Add{ ModuleName }Module();
    }

    public static IServiceCollection Add{ ModuleName }Module(this IServiceCollection services, IConfigurationSection section)
    {
        services.Configure<{ ModuleName }Options>(section);
        return services.Add{ ModuleName }Module();
    }

    public static IServiceCollection Add{ ModuleName }Module(this IServiceCollection services, Action<{ ModuleName }Options> configure)
    {
        services.Configure(configure);
        return services.Add{ ModuleName }Module();
    }

    public static IServiceCollection Add{ ModuleName }Module(this IServiceCollection services)
    {
        // Avoid duplicate registration
        if (services.Any(s => s.ServiceType == typeof(IModuleMarker)))
        {
            return services;
        }
        services.AddHealthChecks().AddCheck<{ ModuleName }HealthChecks>(name: "{ ModuleName }", tags: ["{ ModuleName }", "readiness"]);
        return services.AddScoped<,>(); // Add your services here
    }

    public static IServiceProvider Use{ ModuleName }Middelwares(IServiceProvider serviceProvider)
    {
        return serviceProvider;
    }

    public static IServiceProvider Use{ ModuleName }Module(IServiceProvider serviceProvider)
    {
        return serviceProvider;
    }
}