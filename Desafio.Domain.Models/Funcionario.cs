using System;

namespace Desafio.Domain.Models
{
    public class Funcionario
    {
        private Funcionario() { }

        public Guid Id { get; private set; }

        
        public string Matricula { get; protected set; }
        public string Nome { get; protected set; }
        public string Area { get; protected set; }
        public string Cargo { get; protected set; }
        public double SalarioBruto { get; protected set; }
        public DateTime DataAdmissao { get; protected set; }
        public Double ValorDistribuicao { get; protected set; }

        public static Funcionario Criar(string matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao)
        {

            var funcionario = new Funcionario();
            funcionario.Id = Guid.NewGuid();
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

            int qtdSalarioMinimos = (int)(SalarioBruto / salarioMinimo);

            if (qtdSalarioMinimos <= 3)
                return 1;

            if (qtdSalarioMinimos < 5)
                return 2;

            if (qtdSalarioMinimos < 8)
                return 3;

            return 5;
        }

        private int ObterPesoAreaAtuacao()
        {
            if (Area == "Diretoria")
                return 1;

            if (Area == "Contabilidade" || Area == "Financeiro" || Area == "Tecnologia")
                return 2;

            if (Area == "Serviços Gerais")
                return 3;

            if (Area == "Relacionamento com o Cliente")
                return 5;

            return 0;
        }

        private int ObterPesoTempoAdmissao()
        {
            var tempoAdmissao = DateTime.Now.Subtract(DataAdmissao);

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
