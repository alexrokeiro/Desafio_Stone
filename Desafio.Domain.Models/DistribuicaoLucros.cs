using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Desafio.Domain.Models
{
    public class DistribuicaoLucros
    {
        private DistribuicaoLucros() { }
        public int TotalFuncionarios { get; private set; }
        public double TotalDistribuido { get; private set; }
        public double TotalDisponibilizado { get ; private set; }
        public double SaldoTotalDisponibilizado { get; private set; }
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

        public static DistribuicaoLucros Criar(double totalDisponibilizado)
        {
            var model = new DistribuicaoLucros();
            model.TotalDisponibilizado = totalDisponibilizado;

            return model;
        }

        public void ConsolidarValores()
        {
            TotalDistribuido = Funcionarios.Sum(it => it.ValorDistribuicao);
            SaldoTotalDisponibilizado = TotalDisponibilizado - TotalDistribuido;
        }


        public void AdicionarFuncionario(string matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao, double salarioMinimo)
        {
            var model = Funcionario.Criar(matricula, nome, area, cargo, salarioBruto, dataAdmissao);
            model.CalcularParticipacaoLucros(salarioMinimo);
            Funcionarios.Add(model);
        }
    }
}
