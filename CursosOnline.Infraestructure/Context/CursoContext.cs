using Microsoft.EntityFrameworkCore;
using CursosOnline.Domain.Entities.Almacen;
using CursosOnline.Infraestructure.Configurations;

namespace CursosOnline.Infraestructure.Context
{
    public partial class CursosContext : DbContext
    {
        public CursosContext()
        {

        }
        public CursosContext(DbContextOptions<CursosContext> options)
               : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfigurationAlmacenEntity();

            modelBuilder.AddConfigurationConfiguracionEntity();

            modelBuilder.AddConfigurationVentaEntity();

            modelBuilder.AddConfigurationSeguridadEntity();

            base.OnModelCreating(modelBuilder);
        }

    }
}
