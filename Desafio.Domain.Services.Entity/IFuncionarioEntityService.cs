using Desafio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Domain.Services.Entity
{
    public interface IFuncionarioEntityService
    {
        List<Funcionario> ObterFuncionarios();
    }
}
