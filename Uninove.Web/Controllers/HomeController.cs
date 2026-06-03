using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;
using System.Collections.Generic; 

namespace Uninove.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Boletim()
    {
        
        List<string> disciplinas = new List<string>
        {
            "Programação Web",
            "Banco de Dados",
            "Estrutura de Dados",
            "Design de Interface",
            "Arquitetura de Software"
        };

        List<double> notas = new List<double>
        {
            9.5, // Nota de Prog Web
            6.8, // Nota de BD
            4.5, // Nota de Estrutura
            8.0, // Nota de Design
            5.5  // Nota de Arq
        };

    
        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    } 
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Sobre()
    {
        return View();
    }
} 