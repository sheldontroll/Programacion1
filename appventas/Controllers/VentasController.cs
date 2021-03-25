using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class VentasController : Controller
    {
        private readonly ILogger<VentasController> _logger;

        public VentasController(ILogger<VentasController> logger)
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

        public IActionResult Ventas()
        {
            return View();
        }

        public IActionResult IGV(Ventas objventas)
        {
            objventas.Resultado = objventas.Precio * objventas.Cantidad;
            objventas.Resultado = objventas.Resultado * 1.18;
            ViewData["Venta"] = "Por la compra de : " + objventas.Nombre + " Incluido IGV es: " + objventas.Resultado;
            return View("Ventas");
        }

    }
}