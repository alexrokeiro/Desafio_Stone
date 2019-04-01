using Desafio.Domain.Models;
using System;
using Xunit;
using System.Linq;

namespace Desafio.UnitTest
{
    public class CalcularDistribuicaoLucrosTaskServiceTest
    {
        [Fact]
        public void CalcularBonificacaoDiretoriaTest()
        {
            var distribuicao = DistribuicaoLucros.Criar(1000000);
            distribuicao.AdicionarFuncionario("0101", "Funcionario", "Diretoria", "Diretor Financeiro", 2000, DateTime.Now.AddYears(-4), 995);
            distribuicao.ConsolidarValores();

            Assert.Equal("48",distribuicao.Funcionarios.FirstOrDefault().ValorDistribuicao.ToString("00"));
        }

        [Fact]
        public void CalcularBonificacaoContabilidadeTest()
        {
            var distribuicao = DistribuicaoLucros.Criar(1000000);
            distribuicao.AdicionarFuncionario("0101", "Funcionario", "Contabilidade", "Diretor Financeiro", 2000, DateTime.Now.AddYears(-4), 995);
            distribuicao.ConsolidarValores();

            Assert.Equal("60", distribuicao.Funcionarios.FirstOrDefault().ValorDistribuicao.ToString("00"));
        }

        [Fact]
        public void CalcularBonificacaoServicosGeraisTest()
        {
            var distribuicao = DistribuicaoLucros.Criar(1000000);
            distribuicao.AdicionarFuncionario("0101", "Funcionario", "Serviços Gerais", "Diretor Financeiro", 2000, DateTime.Now.AddYears(-4), 995);
            distribuicao.ConsolidarValores();

            Assert.Equal("72", distribuicao.Funcionarios.FirstOrDefault().ValorDistribuicao.ToString("00"));
        }

        [Fact]
        public void CalcularBonificacaoRelacionamentoClienteTest()
        {
            var distribuicao = DistribuicaoLucros.Criar(1000000);
            distribuicao.AdicionarFuncionario("0101", "Funcionario", "Relacionamento com o Cliente", "Diretor Financeiro", 2000, DateTime.Now.AddYears(-4), 995);
            distribuicao.ConsolidarValores();

            Assert.Equal("96", distribuicao.Funcionarios.FirstOrDefault().ValorDistribuicao.ToString("00"));
        }

        [Fact]
        public void CalcularBonificacaoEstagiarioTest()
        {
            var distribuicao = DistribuicaoLucros.Criar(1000000);
            distribuicao.AdicionarFuncionario("0101", "Funcionario", "Financeiro", "Estagiário", 1491.45, new DateTime(2015,03,16), 995);
            distribuicao.ConsolidarValores();

            Assert.Equal("60", distribuicao.Funcionarios.FirstOrDefault().ValorDistribuicao.ToString("00"));
        }
    }
}
