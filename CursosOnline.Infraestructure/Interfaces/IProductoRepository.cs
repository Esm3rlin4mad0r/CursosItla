using CursosOnline.Domain.Entities.Almacen;
using CursosOnline.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursosOnline.Infraestructure.Interfaces
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        Task<List<Producto>> GetProductByCategory(int categoryId);
    }
}
