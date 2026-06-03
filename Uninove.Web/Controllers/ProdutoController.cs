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

        // O construtor recebe a conexão do banco de dados (Injeção de Dependência)
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        // Rota: /Produto (Lista os produtos vindos do banco de dados)
        public async Task<IActionResult> Index()
        {
            // Busca a lista real da tabela do banco de dados
            var listaDeProdutos = await _context.Produtos.ToListAsync();
            return View(listaDeProdutos);
        }

        // Rota: /Produto/Cadastrar (Abre a tela com o formulário de cadastro)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

     [HttpPost]
public async Task<IActionResult> Cadastrar(Produto produto)
{
    // Força o .NET a ignorar qualquer erro de validação de texto/número que veio da tela
    ModelState.Clear();

    try
    {
        _context.Produtos.Add(produto); // Adiciona explicitamente na tabela de Produtos
        await _context.SaveChangesAsync(); // Grava fisicamente no uninove.db
        
        return RedirectToAction(nameof(Index)); // Vai para a listagem
    }
    catch (System.Exception ex)
    {
        // Se der qualquer erro no banco, ele não vai quebrar, vai reexibir a tela
        return View(produto);
    }
}
    }
}