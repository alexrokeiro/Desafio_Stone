using Desafio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Domain.Services.Task
{
    public interface ICalcularDistribuicaoLucrosTaskService
    {
        DistribuicaoLucros CalcularDistribuicaoLucros(double valorTotalDisponibilizado);
    }
}
