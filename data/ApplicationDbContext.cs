using Microsoft.EntityFrameworkCore;
using mvcSistema.Models;

namespace mvcSistema.data
{
    public class ApplicationDbContext : DbContext // Aquí faltaba el ':'
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aquí se incluirán todos los modelos que se creen
        public DbSet<Producto> Producto { get; set; }
    }
}
