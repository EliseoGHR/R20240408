using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using R20240408.AccesoADatos;

namespace R20240408.LogicaDeNegocio
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddScoped<PersonaRBL>();
            return services;
        }
    }
}
