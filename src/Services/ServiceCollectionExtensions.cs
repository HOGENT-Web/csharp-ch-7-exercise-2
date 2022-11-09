using BogusStore.Services.Products;
using BogusStore.Shared.Products;
using Microsoft.Extensions.DependencyInjection;

namespace BogusStore.Services;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds all services to the DI container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddBogusServices(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
        // Add more services here...

        return services;
    }
}

