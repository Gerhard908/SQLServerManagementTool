using SQLServerManagementTool.Application.Interfaces.Database;
using SQLServerManagementTool.Domain.Entities;
using SQLServerManagementTool.Domain.Interfaces;

namespace SQLServerManagementTool.Application.Services.Database;

public class DatabaseService : IDatabaseService
{
    private readonly IDatabaseProvider _provider;

    public DatabaseService(IDatabaseProvider provider)
    {
        _provider = provider;
    }

    public async Task<IReadOnlyList<DatabaseInformation>> GetDatabasesAsync(
        ConnectionInformation connection)
    {
        return await _provider.GetDatabasesAsync(connection);
    }
}