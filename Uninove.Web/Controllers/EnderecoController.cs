using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult ProcessarEndereco([FromBody] Endereco model) 
        {
            if (model == null)
            {
                return BadRequest("Dados inválidos.");
            }

            TempData["EnderecoData"] = JsonSerializer.Serialize(model);

            return Json(new { success = true, redirectUrl = Url.Action("Sucesso") });
        }

        public IActionResult Sucesso()
        {
            if (TempData["EnderecoData"] == null)
            {
                return RedirectToAction("Index");
            }

            var json = TempData["EnderecoData"].ToString();
          
            var model = JsonSerializer.Deserialize<Endereco>(json); 

            return View(model);
        }
    }
}