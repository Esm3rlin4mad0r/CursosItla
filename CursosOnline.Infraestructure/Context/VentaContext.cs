using Microsoft.EntityFrameworkCore;
using CursosOnline.Domain.Entities.Ventas;

namespace CursosOnline.Infraestructure.Context
{
    public partial class CursosContext
    {
        public  DbSet<DetalleVenta> DetalleVenta { get; set; }
        public  DbSet<Venta> Venta { get; set; }
        public DbSet<TipoDocumentoVenta> TipoDocumentoVenta { get; set; }

    }
}
