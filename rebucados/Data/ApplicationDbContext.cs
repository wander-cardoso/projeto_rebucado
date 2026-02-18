using Microsoft.EntityFrameworkCore;

using Login23.Models;
using rebucados.Models;
namespace Login23.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options )
            : base( options )   
        {
            
        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
    }
}

