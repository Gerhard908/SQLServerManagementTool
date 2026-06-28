using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Application.Interfaces.Table;

public interface ITableService
{
    Task<IReadOnlyList<TableInformation>> GetTablesAsync(
        ConnectionInformation connection,
        string databaseName);

    Task<IReadOnlyList<ColumnInformation>> GetColumnsAsync(
        ConnectionInformation connection,
        string databaseName,
        string tableName);
}