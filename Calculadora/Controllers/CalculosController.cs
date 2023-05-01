using Calculadora.Repositorio.Entidades;
using Calculadora.Servicio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Web.Controllers
{
    public class CalculosController : Controller
    {
        readonly ICalculadoraServicio _servicio;
        public CalculosController(ICalculadoraServicio servicio)   // importantisimo tener este constructor para enlazar el constructor con el servicio
        {
            _servicio = servicio;
        }


        [HttpPost]
        public IActionResult Calcular(Datos datos) 
        {
            Resultados resultado = _servicio.CalcularResultado(datos);
            _servicio.GuardarResultado(resultado);
            return View(resultado);
        }

        public IActionResult Listar()
        {
            List<Resultados> lista = _servicio.ListarResultados();
            return View(lista);
        }
    }
}
