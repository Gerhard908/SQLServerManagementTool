using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Domain.Interfaces;

public interface IDatabaseProvider
{
    Task<bool> TestConnectionAsync(ConnectionInformation connection);

    Task<IReadOnlyList<DatabaseInformation>> GetDatabasesAsync(ConnectionInformation connection);

    Task<IReadOnlyList<TableInformation>> GetTablesAsync(ConnectionInformation connection, string databaseName);

    Task<IReadOnlyList<ColumnInformation>> GetColumnsAsync(ConnectionInformation connection, string databaseName, string tableName);
}