using CursosOnline.Application.Dtos.Producto;
using CursosOnline.Domain.Entities.Almacen;

namespace CursosOnline.Application.Extentions
{
    public static class ProductExtention
    {
        /// <summary>
        /// Se encarga de convertir de un DTO del producto a su entidad
        /// </summary>
        /// <param name="productAddDto">mi dto</param>
        /// <returns>Retorna el producto</returns>
        public static Producto ConvertDtoAddProductToProduct(this ProductAddDto productAddDto)
        {
            return new Producto()
            {
                CodigoBarra = productAddDto.CodigoBarra,
                Descripcion = productAddDto.Descripcion,
                IdCategoria = productAddDto.IdCategoria,
                Marca = productAddDto.Marca,
                NombreImagen = productAddDto.NombreImagen,
                Precio = productAddDto.Precio,
                Stock = productAddDto.Stock,
                UrlImagen = productAddDto.UrlImagen,
                FechaRegistro = productAddDto.Fecha
            };
        }

    }
}
