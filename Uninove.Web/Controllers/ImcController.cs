using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers
{
    public class ImcController : Controller
    {
        // Abre o formulário vazio
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Recebe o formulário, valida com ModelState e faz o cálculo
        [HttpPost]
        public IActionResult Cadastrar(Imc imc)
        {
            if (ModelState.IsValid)
            {
                // Cálculo do IMC (Server-Side)
                imc.Resultado = imc.Peso / (imc.Altura * imc.Altura);

                // Classificação
                if (imc.Resultado < 18.5) imc.Classificacao = "Abaixo do peso";
                else if (imc.Resultado < 25) imc.Classificacao = "Peso normal";
                else if (imc.Resultado < 30) imc.Classificacao = "Sobrepeso";
                else imc.Classificacao = "Obesidade";

                // Redireciona para a View de confirmação levando os dados calculados
                return View("Confirmacao", imc);
            }

            // Se der erro de validação, volta para o formulário mostrando os erros
            return View(imc);
        }
    }
}