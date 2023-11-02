using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidationUser.Models;

namespace ValidationUser.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new User());
    }
    [HttpPost]
    [Route("/register")]
    public IActionResult Submit(User user)
    {
        if (ModelState.IsValid)
        {
            // El modelo es válido, realiza alguna acción aquí
            // Por ejemplo, redirige a una página de éxito
            return RedirectToAction("Privacy", user);
        }

        // Si el modelo no es válido, muestra de nuevo el formulario con los errores de validación
        return View("Index");
    }

    [HttpGet]
    [Route("/result")]
    public IActionResult Privacy(User user)
    {
        return View("Privacy", user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
