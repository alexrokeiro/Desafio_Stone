using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Domain.Models
{
    [DataContract]
    public class Funcionario
    {
        private Funcionario() { }

        [DataMember(Name = "matricula")]
        public string Matricula { get; protected set; }
        [DataMember(Name = "nome")]
        public string Nome { get; protected set; }
        [DataMember(Name = "area")]
        public string Area { get; protected set; }
        [DataMember(Name = "cargo")]
        public string Cargo { get; protected set; }
        [DataMember(Name = "salario_bruto")]
        public double SalarioBruto { get; protected set; }
        [DataMember(Name = "data_de_admissao")]
        public DateTime DataAdmissao { get; protected set; }
        public Double ValorDistribuicao { get; protected set; }

        internal static Funcionario Criar(string matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao)
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

            int qtdSalarioMinimos = (int)(SalarioBruto / salarioMinimo);

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
