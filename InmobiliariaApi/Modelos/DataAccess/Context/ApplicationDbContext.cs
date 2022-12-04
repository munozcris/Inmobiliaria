using Microsoft.EntityFrameworkCore;
using Modelos.Models;

namespace Modelos.DataAccess.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<ClienteData> Cliente { get; set; }
        public DbSet<CondicionData> Condiciones { get; set; }
        public DbSet<FormaPagoData> Pagos { get; set; }
        public DbSet<InmuebleData> Inmuebles { get; set; }
        public DbSet<TipoInmuebleData> Tipos { get; set; }
        public DbSet<VentaData> Ventas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
