using Microsoft.EntityFrameworkCore;
using Uninove.Web.Models;

namespace Uninove.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Passo 5: Configurar o DbSet para a tabela de Produtos
        public DbSet<Produto> Produtos { get; set; }
    }
}