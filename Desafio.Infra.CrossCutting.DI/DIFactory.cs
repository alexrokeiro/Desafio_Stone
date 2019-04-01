using System;
using Desafio.Application.Services;
using Desafio.Application.Services.Imp;
using Desafio.Domain.Services.Entity;
using Desafio.Domain.Services.Entity.Imp;
using Desafio.Domain.Services.Task;
using Desafio.Domain.Services.Task.Imp;
using Desafio.Infra.DataAcess;
using Desafio.Infra.DataAcess.MongoDb;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Infra.CrossCutting.DI
{
    public class DIFactory
    {
        public static void ConfigureDI(IServiceCollection services)
        {
            
            ConfigureApplicationServices(services);
            ConfigureDomainServices(services);
            ConfigureRepositories(services);
        }

        private static void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            
        }

        private static void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<ICalcularDistribuicaoLucrosApplicationService, CalcularDistribuicaoLucrosApplicationService>();
            

        }

        private static void ConfigureDomainServices(IServiceCollection services)
        {
            services.AddScoped<ICalcularDistribuicaoLucrosTaskService, CalcularDistribuicaoLucrosTaskService>();
            services.AddScoped<IFuncionarioEntityService, FuncionarioEntityService>();
        }
    }
}
