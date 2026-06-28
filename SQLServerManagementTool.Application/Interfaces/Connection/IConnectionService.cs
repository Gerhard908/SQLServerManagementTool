using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Application.Interfaces.Connection;

public interface IConnectionService
{
    Task<bool> TestConnectionAsync(ConnectionInformation connection);
}