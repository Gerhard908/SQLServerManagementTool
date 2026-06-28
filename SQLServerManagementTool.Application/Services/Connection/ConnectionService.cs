using SQLServerManagementTool.Application.Interfaces.Connection;
using SQLServerManagementTool.Domain.Entities;
using SQLServerManagementTool.Domain.Interfaces;

namespace SQLServerManagementTool.Application.Services.Connection;

public class ConnectionService : IConnectionService
{
    private readonly IDatabaseProvider _provider;

    public ConnectionService(IDatabaseProvider provider)
    {
        _provider = provider;
    }

    public async Task<bool> TestConnectionAsync(ConnectionInformation connection)
    {
        return await _provider.TestConnectionAsync(connection);
    }
}