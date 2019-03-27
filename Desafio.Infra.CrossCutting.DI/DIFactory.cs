using Desafio.Application.Services;
using Desafio.Application.Services.Imp;
using Desafio.Domain.Services.Entity;
using Desafio.Domain.Services.Entity.Imp;
using Desafio.Domain.Services.Task;
using Desafio.Domain.Services.Task.Imp;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Infra.CrossCutting.DI
{
    public class DIFactory
    {
        public static void ConfigureDI(IServiceCollection services)
        {
            
            ConfigureApplicationServices(services);
            ConfigureDomainServices(services);
        }

        private static void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IParticipacaoLucrosApplicationService, ParticipacaoLucrosApplicationService>();
            

        }

        private static void ConfigureDomainServices(IServiceCollection services)
        {
            services.AddScoped<ICalcularDistribuicaoTaskService, CalcularDistribuicaoTaskService>();
            services.AddScoped<IFuncionarioEntityService, FuncionarioEntityService>();
        }
    }
}
