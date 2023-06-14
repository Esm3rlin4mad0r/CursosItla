using CursosOnline.Web.Models.Requests;
using CursosOnline.Web.Models.Responses;

namespace CursosOnline.Web.ApiServices.Interfaces
{
    public interface IProductApiService
    {
        Task<ProductoListResponse> GetProductos();
        Task<ProductoGetResponse> GetProducto(int Id);
        Task<ProductAddReponse> SaveProducto(ProductSaveRequest productRequest);
        Task<ResponseBase> UpdateProducto(ProductSaveRequest productRequest);
    }
}
