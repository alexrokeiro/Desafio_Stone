using Desafio.Infra.CrossCutting.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace WZ.Telecom.Seg.Host.WebApi.Configurations
{
    public static class InjectionDependencyConfigurations
    {
        public static IServiceCollection ConfigureDI(this IServiceCollection services)
        {
            DIFactory.ConfigureDI(services);

            return services;
        }
    }
}
