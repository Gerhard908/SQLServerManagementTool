/*
 * Project      : SQL Server Management Tool
 * Description  : Registers Application layer services with the
 *                dependency injection container.
 */

using Microsoft.Extensions.DependencyInjection;
using SQLServerManagementTool.Application.Interfaces.Connection;
using SQLServerManagementTool.Application.Interfaces.Database;
using SQLServerManagementTool.Application.Interfaces.Session;
using SQLServerManagementTool.Application.Interfaces.Table;
using SQLServerManagementTool.Application.Services.Connection;
using SQLServerManagementTool.Application.Services.Database;
using SQLServerManagementTool.Application.Services.Session;
using SQLServerManagementTool.Application.Services.Table;

namespace SQLServerManagementTool.Application.DependencyInjection;

/// <summary>
/// Registers Application services.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers all application services.
    /// </summary>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IConnectionService, ConnectionService>();
        services.AddScoped<IDatabaseService, DatabaseService>();
        services.AddScoped<ITableService, TableService>();

        // SessionService is a Singleton because it stores
        // the currently active connection.
        services.AddSingleton<ISessionService, SessionService>();

        return services;
    }
}