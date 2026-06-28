/*
 * Project      : SQL Server Management Tool
 * Description  : SQL Server implementation of the database provider.
 */

using Microsoft.Data.SqlClient;
using SQLServerManagementTool.Domain.Entities;
using SQLServerManagementTool.Domain.Interfaces;
using SQLServerManagementTool.Infrastructure.Configuration;

namespace SQLServerManagementTool.Infrastructure.Providers.SqlServer;

/// <summary>
/// Provides SQL Server specific implementations for metadata retrieval
/// and connection management.
/// </summary>
public class SqlServerDatabaseProvider : IDatabaseProvider
{
    /// <summary>
    /// Tests whether a connection to SQL Server can be established.
    /// </summary>
    public async Task<bool> TestConnectionAsync(ConnectionInformation connection)
    {
        try
        {
            // Build the SQL Server connection string from
            // the supplied connection information.
            var connectionString =
                DatabaseConnectionStringBuilder.Build(connection);

            // Attempt to open the SQL Server connection.
            await using var sqlConnection =
                new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            return true;
        }
        catch
        {
            // Any exception indicates the connection failed.
            return false;
        }
    }

    public Task<IReadOnlyList<DatabaseInformation>> GetDatabasesAsync(ConnectionInformation connection)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<TableInformation>> GetTablesAsync(
        ConnectionInformation connection,
        string databaseName)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<ColumnInformation>> GetColumnsAsync(
        ConnectionInformation connection,
        string databaseName,
        string tableName)
    {
        throw new NotImplementedException();
    }
}