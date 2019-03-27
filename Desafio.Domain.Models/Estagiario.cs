//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Desafio.Domain.Models
//{
//    public class Estagiario : Funcionario
//    {
//        private Estagiario() { }

//        public static Funcionario Criar(long matricula, string nome, string area, string cargo, double salarioBruto, DateTime dataAdmissao)
//        {

//            var funcionario = new Estagiario();
//            funcionario.Matricula = matricula;
//            funcionario.Nome = nome;
//            funcionario.Area = area;
//            funcionario.Cargo = cargo;
//            funcionario.SalarioBruto = salarioBruto;
//            funcionario.DataAdmissao = dataAdmissao;

//            return funcionario;
//        }

//        protected override int ObterPesoAreaAtuacao()
//        {
//            return 1;
//        }
//    }
//}
