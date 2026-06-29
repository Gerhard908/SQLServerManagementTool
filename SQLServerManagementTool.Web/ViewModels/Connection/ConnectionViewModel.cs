/*
 * ==========================================================
 * Project      : SQL Server Management Tool
 * File         : ConnectionViewModel.cs
 * Layer        : Web
 *
 * Description:
 * Represents the information entered by the user when
 * creating a SQL Server or Azure SQL connection.
 * ==========================================================
 */

using System.ComponentModel.DataAnnotations;

namespace SQLServerManagementTool.Web.ViewModels.Connection;

/// <summary>
/// View model used by the Connection Wizard.
/// </summary>
public class ConnectionViewModel
{
    /// <summary>
    /// SQL Server or Azure SQL.
    /// </summary>
    [Display(Name = "Connection Type")]
    public string ConnectionType { get; set; } = "SQLServer";

    /// <summary>
    /// SQL Server instance.
    /// </summary>
    [Required]
    [Display(Name = "Server Name")]
    public string ServerName { get; set; } = string.Empty;

    /// <summary>
    /// Database name.
    /// Optional for first connection.
    /// </summary>
    [Display(Name = "Database")]
    public string DatabaseName { get; set; } = string.Empty;

    /// <summary>
    /// Windows Authentication.
    /// </summary>
    [Display(Name = "Use Windows Authentication")]
    public bool UseWindowsAuthentication { get; set; } = true;

    /// <summary>
    /// SQL Username.
    /// </summary>
    [Display(Name = "Username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// SQL Password.
    /// </summary>
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Encrypt connection.
    /// </summary>
    [Display(Name = "Encrypt Connection")]
    public bool EncryptConnection { get; set; } = true;

    /// <summary>
    /// Trust certificate.
    /// </summary>
    [Display(Name = "Trust Server Certificate")]
    public bool TrustServerCertificate { get; set; }

    /// <summary>
    /// Connection timeout.
    /// </summary>
    [Range(5, 120)]
    public int ConnectionTimeout { get; set; } = 15;
}