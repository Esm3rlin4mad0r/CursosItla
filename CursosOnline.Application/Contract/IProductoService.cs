using CursosOnline.Application.Core;
using CursosOnline.Application.Dtos.Producto;
using CursosOnline.Application.Responses;
using System.Threading.Tasks;

namespace CursosOnline.Application.Contract
{
    public interface IProductoService
    {
       Task<ServiceResult> Get();
       Task<ServiceResult> GetById(int Id);
       Task<ProductAddResponse> SaveProduct(ProductAddDto productAddDto);
       Task<ServiceResult> ModifyProduct(ProductUpdateDto productUpdateDto);

    }
}
