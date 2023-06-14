using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CursosOnline.Infraestructure.Context;

namespace CursosOnline.IOC.Dependencies
{
    public static class ContextDependency
    {
        public static void AddContextDependency(this IServiceCollection services, string connString) 
        {
            services.AddDbContext<CursosContext>(options => options.UseSqlServer(connString));
        }
    }
}
