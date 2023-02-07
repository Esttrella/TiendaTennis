using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TiendaTennis.Models;
/*Autor: Hermilo Almaraz Vargas
  Fecha de creación: 04/2/2023
  Fecha de actulizacion: 05/2/2023
  Descripcion: Creación del controlleler  principal (Donde se despliegará el contenido principal)
*/

namespace TiendaTennis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
}