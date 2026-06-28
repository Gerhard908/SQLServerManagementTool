using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Application.Interfaces.Database;

public interface IDatabaseService
{
    Task<IReadOnlyList<DatabaseInformation>> GetDatabasesAsync(ConnectionInformation connection);
}