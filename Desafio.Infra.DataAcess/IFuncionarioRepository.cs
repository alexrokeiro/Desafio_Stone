using Desafio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Infra.DataAcess
{
    public interface IFuncionarioRepository
    {
        void CriarFuncionario(Funcionario funcionario);
        IEnumerable<Funcionario> Listar();
    }
}
