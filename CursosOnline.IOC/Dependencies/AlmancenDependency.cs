
using Microsoft.Extensions.DependencyInjection;
using CursosOnline.Application.Contract;
using CursosOnline.Application.Services;
using CursosOnline.Infraestructure.Interfaces;
using CursosOnline.Infraestructure.Repositories;

namespace CursosOnline.IOC.Dependencies
{
    public static class AlmancenDependency
    {
        public static void AddAlmacenDependency(this IServiceCollection services) 
        {

            //Repositories
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            

            //Services
            services.AddTransient<IProductoService, ProductoService>();
            

        }
    }
}
