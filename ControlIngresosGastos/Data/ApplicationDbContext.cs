using ControlIngresosGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlIngresosGastos.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
