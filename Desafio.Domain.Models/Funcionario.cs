using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Domain.Models
{
    public class Funcionario
    {
        private Funcionario() { }

        public long Matricula { get; protected set; }
        public string Nome { get; protected set; }
        public string Area { get; protected set; }
        public string Cargo { get; protected set; }
        public double SalarioBruto { get; protected set; }
        public DateTime DataAdmissao { get; protected set; }
        public Double ValorDistribuicao { get; protected set; }

        internal static Funcionario Criar(long matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao)
        {

            var funcionario = new Funcionario();
            funcionario.Matricula = matricula;
            funcionario.Nome = nome;
            funcionario.Area = area;
            funcionario.Cargo = cargo;
            funcionario.SalarioBruto = salarioBruto;
            funcionario.DataAdmissao = dataAdmissao;

            return funcionario;
        }

        private int ObterPesoSalario(double salarioMinimo)
        {

            if (Cargo.ToLower() == "estagiário")
                return 1;

            int qtdSalarioMinimos = (int)(SalarioBruto % salarioMinimo);

            if (qtdSalarioMinimos <= 3)
                return 1;

            if (qtdSalarioMinimos <= 5)
                return 2;

            if (qtdSalarioMinimos <= 8)
                return 3;

            return 5;
        }

        private int ObterPesoAreaAtuacao()
        {
            if (Cargo == "Diretoria")
                return 1;

            if (Cargo == "Contabilidade" || Cargo == "Financeiro" || Cargo == "Tecnologia")
                return 2;

            if (Cargo == "Serviços Gerais")
                return 3;

            if (Cargo == "Relacionamento com o Cliente")
                return 3;

            return 0;
        }

        private int ObterPesoTempoAdmissao()
        {
            var tempoAdmissao = DataAdmissao.Subtract(DateTime.Now);

            if (tempoAdmissao.TotalDays < 365)
                return 1;

            if (tempoAdmissao.TotalDays < 1095)
                return 2;

            if (tempoAdmissao.TotalDays < 2920)
                return 3;

            return 5;
                
        }

        public void CalcularParticipacaoLucros(double salarioMinimo)
        {
            var valorAdimissao = (ObterPesoTempoAdmissao() * SalarioBruto);
            var valorSalario = ObterPesoSalario(salarioMinimo) * SalarioBruto;
            var valorArea = (ObterPesoAreaAtuacao() * SalarioBruto);
            ValorDistribuicao = ((valorAdimissao + valorArea) / valorSalario) * 12;
        }
    }
}
