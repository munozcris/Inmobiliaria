using Microsoft.EntityFrameworkCore;
using Modelos.Models;

namespace Modelos.DataAccess.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<ClienteData> Cliente { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
