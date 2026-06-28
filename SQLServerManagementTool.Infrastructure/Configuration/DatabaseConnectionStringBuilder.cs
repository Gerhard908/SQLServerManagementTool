/*
 * Project      : SQL Server Management Tool
 * Description  : Builds provider-specific connection strings
 *                from the application's connection model.
 */

using Microsoft.Data.SqlClient;
using SQLServerManagementTool.Domain.Entities;
using SQLServerManagementTool.Domain.Enums;

namespace SQLServerManagementTool.Infrastructure.Configuration;

/// <summary>
/// Responsible for converting a ConnectionInformation object
/// into a valid SQL Server or Azure SQL connection string.
/// </summary>
public static class DatabaseConnectionStringBuilder
{
    /// <summary>
    /// Builds a provider-specific connection string.
    /// </summary>
    public static string Build(ConnectionInformation connection)
    {
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = connection.ServerName,

            InitialCatalog = string.IsNullOrWhiteSpace(connection.DatabaseName)
                ? "master"
                : connection.DatabaseName,

            IntegratedSecurity = connection.UseWindowsAuthentication,

            Encrypt = connection.EncryptConnection,

            TrustServerCertificate = connection.TrustServerCertificate,

            ConnectTimeout = connection.ConnectionTimeout
        };

        // SQL Authentication
        if (!connection.UseWindowsAuthentication)
        {
            builder.UserID = connection.Username;
            builder.Password = connection.Password;
        }

        // Azure SQL defaults
        if (connection.ConnectionType == ConnectionType.AzureSql)
        {
            builder.Encrypt = true;
            builder.TrustServerCertificate = false;
        }

        return builder.ConnectionString;
    }
}