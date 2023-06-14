using Microsoft.EntityFrameworkCore;
using CursosOnline.Domain.Entities.Seguridad;

namespace CursosOnline.Infraestructure.Context
{
    public partial class CursosContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolMenu> RolMenu { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
