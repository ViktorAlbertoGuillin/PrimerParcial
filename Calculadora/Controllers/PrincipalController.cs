using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace Calculadora.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }

        public IActionResult Calcular()
        {
            return View();
        }


    }
}
