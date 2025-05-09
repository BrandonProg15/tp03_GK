using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03GK.Models;

namespace TP03GK.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Discografia.InicializarDiscos();
        ViewBag.Discos = Discografia.Discos; 
        return View();
    }
    public IActionResult SelectDisco(int id)
    {
        if(Discografia.Discos.ContainsKey(id)){
            ViewBag.Discos = Discografia.Discos[id];
            ViewBag.id=id;
        }
        return View("infoDatosPersonales");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
