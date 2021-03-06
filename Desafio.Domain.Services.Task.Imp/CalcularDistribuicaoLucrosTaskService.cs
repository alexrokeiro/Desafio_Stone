﻿using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Domain.Models;
using Desafio.Domain.Services.Entity;
using Microsoft.Extensions.Configuration;

namespace Desafio.Domain.Services.Task.Imp
{
    public class CalcularDistribuicaoLucrosTaskService : ICalcularDistribuicaoLucrosTaskService
    {
        public IFuncionarioEntityService FuncionarioEntityService { get; }
        public IConfiguration Configuration { get; }

        public CalcularDistribuicaoLucrosTaskService(IFuncionarioEntityService funcionarioEntityService, IConfiguration configuration)
        {
            FuncionarioEntityService = funcionarioEntityService;
            Configuration = configuration;
        }

        public DistribuicaoLucros CalcularDistribuicaoLucros(double valorTotalDisponibilizado)
        {
            var funcionarios = FuncionarioEntityService.ObterFuncionarios();
            var distribuicao = DistribuicaoLucros.Criar(valorTotalDisponibilizado);

            foreach (Funcionario funcionario in funcionarios)
            {
                distribuicao.AdicionarFuncionario(funcionario.Matricula, funcionario.Nome,funcionario.Area, funcionario.Cargo, funcionario.SalarioBruto, funcionario.DataAdmissao, double.Parse(Configuration.GetSection("SalarioMinimo").Value));
            }

            distribuicao.ConsolidarValores();

            return distribuicao;
        }
    }
}
