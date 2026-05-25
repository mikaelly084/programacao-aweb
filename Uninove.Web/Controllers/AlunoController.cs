using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Seu Nome Aqui";
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "3º Semestre";

        return View();
    }
    public IActionResult Detalhes(int id)
    {
    ViewBag.AlunoId = id;
    return View(); // <-- Sem nada dentro dos parênteses
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
