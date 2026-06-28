/*
 * Project      : SQL Server Management Tool
 * Description  : Handles the application's landing page and
 *                future database connection workflow.
 */

using Microsoft.AspNetCore.Mvc;

namespace SQLServerManagementTool.Web.Controllers;

/// <summary>
/// Controller responsible for the application's
/// connection workflow.
/// </summary>
public class ConnectionController : Controller
{
    /// <summary>
    /// Displays the connection screen.
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }
}