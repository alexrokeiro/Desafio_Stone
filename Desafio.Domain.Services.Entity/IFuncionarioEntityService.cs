using Desafio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Domain.Services.Entity
{
    public interface IFuncionarioEntityService
    {
        List<Funcionario> ObterFuncionarios();
        void AdicionarFuncionario(string matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao);
    }
}
