namespace SQLServerManagementTool.Domain.Entities;

using SQLServerManagementTool.Domain.Enums;

public class ConnectionInformation
{
    public ConnectionType ConnectionType { get; set; }

    public string ServerName { get; set; } = string.Empty;

    public string? DatabaseName { get; set; }

    public bool UseWindowsAuthentication { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool EncryptConnection { get; set; } = true;

    public bool TrustServerCertificate { get; set; }

    public int ConnectionTimeout { get; set; } = 30;
}