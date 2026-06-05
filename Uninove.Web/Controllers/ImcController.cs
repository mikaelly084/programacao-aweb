using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers
{
    public class ImcController : Controller
    {

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Imc imc)
        {
            if (ModelState.IsValid)
            {
                
                imc.Resultado = imc.Peso / (imc.Altura * imc.Altura);

                if (imc.Resultado < 18.5) imc.Classificacao = "Abaixo do peso";
                else if (imc.Resultado < 25) imc.Classificacao = "Peso normal";
                else if (imc.Resultado < 30) imc.Classificacao = "Sobrepeso";
                else imc.Classificacao = "Obesidade";

                return View("Confirmacao", imc);
            }
            return View(imc);
        }
    }
}