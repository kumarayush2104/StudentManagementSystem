using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;

public class AdminController : Controller
{
    public IActionResult Index() => View();

    public IActionResult ManageStandard() => View();

    public IActionResult ViewFeedback() => View();
}