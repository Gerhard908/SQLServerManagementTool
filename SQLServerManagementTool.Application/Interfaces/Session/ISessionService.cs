using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Application.Interfaces.Session;

public interface ISessionService
{
    ConnectionInformation? ActiveConnection { get; set; }

    string? CurrentDatabase { get; set; }

    bool IsConnected { get; }

    void Clear();
}