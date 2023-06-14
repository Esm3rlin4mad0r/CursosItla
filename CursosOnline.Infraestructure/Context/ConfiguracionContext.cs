
using Microsoft.EntityFrameworkCore;
using CursosOnline.Domain.Entities.Configuracion;

namespace CursosOnline.Infraestructure.Context
{
    public partial class CursosContext
    {
        public DbSet<NumeroCorrelativo> NumeroCorrelativo { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Negocio>  Negocio { get; set; }
    }
}
