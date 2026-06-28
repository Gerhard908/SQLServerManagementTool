using SQLServerManagementTool.Application.Interfaces.Session;
using SQLServerManagementTool.Domain.Entities;

namespace SQLServerManagementTool.Application.Services.Session;

public class SessionService : ISessionService
{
    public ConnectionInformation? ActiveConnection { get; set; }

    public string? CurrentDatabase { get; set; }

    public bool IsConnected => ActiveConnection is not null;

    public void Clear()
    {
        ActiveConnection = null;
        CurrentDatabase = null;
    }
}