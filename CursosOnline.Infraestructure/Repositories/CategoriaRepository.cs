using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CursosOnline.Domain.Entities.Almacen;
using CursosOnline.Infraestructure.Context;
using CursosOnline.Infraestructure.Core;
using CursosOnline.Infraestructure.Interfaces;


namespace CursosOnline.Infraestructure.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria> ,ICategoriaRepository
    {
        private readonly CursosContext context;
        private readonly ILogger<CategoriaRepository> logger;
        public CategoriaRepository(CursosContext context, 
                                   ILogger<CategoriaRepository> logger) :base(context)
        {
            this.context = context;
            this.logger = logger;
        }

        public async override Task<IEnumerable<Categoria>> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                categorias =  await  this.context.Categoria.Where(cd => !cd.Eliminado).ToListAsync();
            }
            catch (Exception ex)
            {
                this.logger.LogError("Error obteniendo las categorias", ex.ToString());
            }

            return categorias;
        }



    }
}
