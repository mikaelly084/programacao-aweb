using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Uninove.Web.Data;
using Uninove.Web.Models;
using System.Threading.Tasks;

namespace Uninove.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var listaDeProdutos = await _context.Produtos.ToListAsync();
            return View(listaDeProdutos);
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

     [HttpPost]
public async Task<IActionResult> Cadastrar(Produto produto)
{
    ModelState.Clear();

    try
    {
        _context.Produtos.Add(produto); 
        await _context.SaveChangesAsync(); 
        
        return RedirectToAction(nameof(Index)); 
    }
    catch (System.Exception ex)
    {
        return View(produto);
    }
}
    }
}