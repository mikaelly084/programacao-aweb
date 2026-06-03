using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    // Rota: /Aluno
    public IActionResult Index()
    {
        ViewBag.Nome = "Seu Nome Aqui";
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "3º Semestre";

        return View();
    }

    // Rota: /Aluno/Detalhes/{id}
    public IActionResult Detalhes(int id)
    {
        ViewBag.AlunoId = id;
        return View(); 
    }

    // Rota: /Aluno/Privacy
    public IActionResult Privacy()
    {
        return View();
    }

    // Rota: /Aluno/Cadastrar
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (ModelState.IsValid)
        {
            
            return View("Confirmacao", aluno);
        }

        return View(aluno);
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
} 