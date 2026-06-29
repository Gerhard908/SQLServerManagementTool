/*
 * Project      : SQL Server Management Tool
 * Description  : Handles the application's landing page and
 *                future database connection workflow.
 */

using Microsoft.AspNetCore.Mvc;
using SQLServerManagementTool.Web.ViewModels.Connection;

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

    /// <summary>
    /// Displays the Connection Wizard.
    /// </summary>
    [HttpGet]
    public IActionResult Connect()
    {
        var model = new ConnectionViewModel();

        return View(model);
    }
}

