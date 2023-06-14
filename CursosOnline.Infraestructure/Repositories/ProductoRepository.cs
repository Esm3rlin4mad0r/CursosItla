
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CursosOnline.Domain.Entities.Almacen;
using CursosOnline.Infraestructure.Context;
using CursosOnline.Infraestructure.Core;
using CursosOnline.Infraestructure.Exceptions;
using CursosOnline.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursosOnline.Infraestructure.Repositories
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        private readonly CursosContext context;
        private readonly ILogger<ProductoRepository> logger;

        public ProductoRepository(CursosContext context,
                                   ILogger<ProductoRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }
        public async Task<List<Producto>> GetProductByCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }
        public async override Task Save(Producto entity)
        {
            if (!await this.context.Categoria.AnyAsync(cd => cd.Id == entity.IdCategoria))
            {
                throw new ProductoException("La categoria no se encuentra registrada");
            }


            await base.Save(entity);
            await base.SaveChanges();


        }
        public override async Task Update(Producto entity)
        {

            await base.Update(entity);
            await base.SaveChanges();
        }
    }
}
