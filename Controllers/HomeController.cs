using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            //return RedirectToAction("Buscar", "Usuario", routeValues: new { nombre = "Alejandro Garcia" });        
            return RedirectToAction("MostrarHolaMundo", "Usuario");        

        }
    }
}