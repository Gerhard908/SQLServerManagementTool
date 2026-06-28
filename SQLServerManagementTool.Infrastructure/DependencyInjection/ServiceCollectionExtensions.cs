using Microsoft.Extensions.DependencyInjection;
using SQLServerManagementTool.Domain.Interfaces;
using SQLServerManagementTool.Infrastructure.Providers.SqlServer;

namespace SQLServerManagementTool.Infrastructure.DependencyInjection;

/// <summary>
/// Extension methods for registering Infrastructure services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers Infrastructure dependencies.
    /// </summary>
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<IDatabaseProvider, SqlServerDatabaseProvider>();

        return services;
    }
}