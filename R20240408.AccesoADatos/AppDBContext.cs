using Microsoft.EntityFrameworkCore;
using R20240408.EntidadesDeNegocio;

namespace R20240408.AccesoADatos
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<PersonaR> PersonasR { get; set; }
    }
}
