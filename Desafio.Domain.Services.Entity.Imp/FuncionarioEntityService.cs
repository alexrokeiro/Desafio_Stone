using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Domain.Models;
using Desafio.Infra.DataAcess;
using System.Linq;

namespace Desafio.Domain.Services.Entity.Imp
{
    public class FuncionarioEntityService : IFuncionarioEntityService
    {
        public IFuncionarioRepository FuncionarioRepository { get; set; }

        public FuncionarioEntityService(IFuncionarioRepository funcionarioRepository)
        {
            FuncionarioRepository = funcionarioRepository;
        }

        public void AdicionarFuncionario(string matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao)
        {
            Funcionario funcionario = Funcionario.Criar(matricula, nome, area, cargo, salarioBruto, dataAdmissao);
            FuncionarioRepository.CriarFuncionario(funcionario);
        }

        public List<Funcionario> ObterFuncionarios()
        {
            return FuncionarioRepository.Listar().ToList();
            
        }


    }

}
