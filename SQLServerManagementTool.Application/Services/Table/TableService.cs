/*
 * Project      : SQL Server Management Tool
 * Description  : Provides business logic for retrieving
 *                database tables and columns.
 */

using SQLServerManagementTool.Application.Interfaces.Table;
using SQLServerManagementTool.Domain.Entities;
using SQLServerManagementTool.Domain.Interfaces;

namespace SQLServerManagementTool.Application.Services.Table;

/// <summary>
/// Handles retrieval of table metadata.
/// </summary>
public class TableService : ITableService
{
    private readonly IDatabaseProvider _provider;

    public TableService(IDatabaseProvider provider)
    {
        _provider = provider;
    }

    public async Task<IReadOnlyList<TableInformation>> GetTablesAsync(
        ConnectionInformation connection,
        string databaseName)
    {
        return await _provider.GetTablesAsync(connection, databaseName);
    }

    public async Task<IReadOnlyList<ColumnInformation>> GetColumnsAsync(
        ConnectionInformation connection,
        string databaseName,
        string tableName)
    {
        return await _provider.GetColumnsAsync(
            connection,
            databaseName,
            tableName);
    }
}