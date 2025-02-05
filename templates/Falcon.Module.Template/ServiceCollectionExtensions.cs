namespace {RootNamespace}.{ModuleName};

public static class ServiceCollectionExtensions
{
    public static IServiceCollection Add{ModuleName}Module(IServiceCollection services)
    {
        return services.AddScoped<,>(); // Add your services here
    }

    public static IApplicationBuilder Use{ModuleName}Middelwares(IApplicationBuilder app)
    {
        return app;
    }

    public static IApplicationBuilder Use{ModuleName}Module(IApplicationBuilder app)
    {
        return app;
    }
}