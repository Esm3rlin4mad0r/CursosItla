using Microsoft.EntityFrameworkCore;
using CursosOnline.Domain.Entities.Almacen;

namespace CursosOnline.Infraestructure.Context
{
    public partial class CursosContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        
    }
}
