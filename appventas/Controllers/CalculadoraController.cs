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
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = " ";
            return View();
        }
    

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {   
            objContacto.Status = "Registrado";
            ViewData["Message"]= "El contacto ya esta " + objContacto.Status;
            return View("Index");
        }

         public IActionResult Calculadora()
        {   
            ViewData["Resultado"] = " ";
            return View();
        }

        public IActionResult Calcular(Calculadora objcalc)
        {
            switch(objcalc.Operando)
            {
                case "+":
                objcalc.Resultado = objcalc.Operador1 + objcalc.Operador2;
                 ViewData["Resultado"]= "La suma es : " + objcalc.Resultado;
                 Console.Write("ga");
                break;
            }



            return View("Calculadora");
        }
    }
}
