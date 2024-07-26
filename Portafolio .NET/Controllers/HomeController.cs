using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portafolio_.NET.Models;
using Portafolio_.NET.Services;
using System.Diagnostics;

namespace Portafolio_.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IrepositorioProyectos repositorio;

        public HomeController(ILogger<HomeController> logger, IrepositorioProyectos repositorio)
        {
            _logger = logger;
            this.repositorio = repositorio;
        }

        public IActionResult Index()
        {
            var proyectos = repositorio.ObtenerProyectos().Take(Range.All).ToList();
            var modelo = new HomeIndexDTO() { Proyectos = proyectos };
            return View(modelo);
        }

        //public IActionResult Test()
        //{

        //    return View();
        //}

        [HttpPost]
        public IActionResult Contacto(ContactoDTO contacto)
        {
            if (ModelState.IsValid)
            {
                // Procesar el modelo 'contacto' como necesites
                // Por ejemplo, guardar en la base de datos, enviar un correo, etc.

                TempData["SuccessMessage"] = "Gracias por comunicarte con nosotros. Te responderemos pronto.";
                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Ocurrió un error al procesar tu solicitud. Por favor, inténtalo de nuevo.";
            return RedirectToAction("Index");
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


