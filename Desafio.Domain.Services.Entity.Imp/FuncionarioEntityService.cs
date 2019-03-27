﻿using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Domain.Models;

namespace Desafio.Domain.Services.Entity.Imp
{
    public class FuncionarioEntityService : IFuncionarioEntityService
    {
        public List<Funcionario> ObterFuncionarios()
        {
            string funcionariosArquivo = @"{[
{
                ""matricula"": 0009968,
""nome"": ""Victor Wilson"",
""area"": ""Diretoria"",
""cargo"": ""Diretor Financeiro"",
""salario_bruto"": 12696.20,
""data_de_admissao"": 2012-01-05
},
{
""matricula"": 0004468,
""nome"": ""Flossie Wilson"",
""area"": ""Contabilidade"",
""cargo"": ""Auxiliar de Contabilidade"",
""salario_bruto"": 1396.52,
""data_de_admissao"": 2015-01-05
},
{
""matricula"": 0008174,
""nome"": ""Sherman Hodges"",
""area"": ""Relacionamento com o Cliente"",
""cargo"": ""Líder de Relacionamento"",
""salario_bruto"": 3899.74,
""data_de_admissao"": 2015-06-07
},
{
""matricula"": 0007463,
""nome"": ""Charlotte Romero"",
""area"": ""Financeiro"",
""cargo"": ""Contador Pleno"",
""salario_bruto"": 3199.82,
""data_de_admissao"": 2018-01-03
},
{
""matricula"": 0005253,
""nome"": ""Wong Austin"",
""area"": ""Financeiro"",
""cargo"": ""Economista Júnior"",
""salario_bruto"": 2215.04,
""data_de_admissao"": 2016-08-27
},
{
""matricula"": 0004867,
""nome"": ""Danielle Blanchard"",
""area"": ""Diretoria"",
""cargo"": ""Auxiliar Administrativo"",
""salario_bruto"": 2768.28,
""data_de_admissao"": 2015-10-17
},
{
""matricula"": 0001843,
""nome"": ""Daugherty Kramer"",
""area"": ""Serviços Gerais"",
""cargo"": ""Atendente de Almoxarifado"",
""salario_bruto"": 2120.08,
""data_de_admissao"": 2016-04-21
},
{
""matricula"": 0007961,
""nome"": ""Francesca Hewitt"",
""area"": ""Contabilidade"",
""cargo"": ""Auxiliar de Contabilidade"",
""salario_bruto"": 2101.68,
""data_de_admissao"": 2015-06-21
},
{
""matricula"": 0006806,
""nome"": ""Ella Hale"",
""area"": ""Diretoria"",
""cargo"": ""Auxiliar Administrativo"",
""salario_bruto"": 2571.73,
""data_de_admissao"": 2014-07-27
},
{
""matricula"": 0005961,
""nome"": ""Jillian Odonnell"",
""area"": ""Contabilidade"",
""cargo"": ""Contador Júnior"",
""salario_bruto"": 2671.26,
""data_de_admissao"": 2016-09-08
},
{
""matricula"": 0007293,
""nome"": ""Morton Battle"",
""area"": ""Contabilidade"",
""cargo"": ""Economista Pleno"",
""salario_bruto"": 4457.08,
""data_de_admissao"": 2017-10-19
},
{
""matricula"": 0002105,
""nome"": ""Dorthy Lee"",
""area"": ""Financeiro"",
""cargo"": ""Estagiário"",
""salario_bruto"": 1491.45,
""data_de_admissao"": 2015-03-16
},
{
""matricula"": 0000273,
""nome"": ""Petersen Coleman"",
""area"": ""Financeiro"",
""cargo"": ""Estagiário"",
""salario_bruto"": 1426.13,
""data_de_admissao"": 2016-09-20
},
{
""matricula"": 0007361,
""nome"": ""Avila Kane"",
""area"": ""Contabilidade"",
""cargo"": ""Auxiliar Administrativo"",
""salario_bruto"": 2166.25,
""data_de_admissao"": 2016-09-16
},
{
""matricula"": 0004237,
""nome"": ""Hess Sloan"",
""area"": ""Relacionamento com o Cliente"",
""cargo"": ""Atendente"",
""salario_bruto"": 2266.46,
""data_de_admissao"": 2014-10-27
},
{
""matricula"": 000538,
""nome"": ""Ashlee Wood"",
""area"": ""Contabilidade"",
""cargo"": ""Auxiliar Administrativo"",
""salario_bruto"": 2330.19,
""data_de_admissao"": 2014-07-15
},
{
""matricula"": 0014319,
""nome"": ""Abraham Jones"",
""area"": ""Diretoria"",
""cargo"": ""Diretor Tecnologia"",
""salario_bruto"": 18053.25,
""data_de_admissao"": 2016-07-05
},
{
""matricula"": 0006335,
""nome"": ""Beulah Long"",
""area"": ""Tecnologia"",
""cargo"": ""Jovem Aprendiz"",
""salario_bruto"": 1019.88,
""data_de_admissao"": 2014-08-27
},
{
""matricula"": 0007676,
""nome"": ""Maricela Martin"",
""area"": ""Serviços Gerais"",
""cargo"": ""Copeiro"",
""salario_bruto"": 1591.69,
""data_de_admissao"": 2018-01-17
},
{
""matricula"": 0002949,
""nome"": ""Stephenson Stone"",
""area"": ""Financeiro"",
""cargo"": ""Analista de Finanças"",
""salario_bruto"": 5694.14,
""data_de_admissao"": 2014-01-26
},
{
""matricula"": 0008601,
""nome"": ""Taylor Mccarthy"",
""area"": ""Relacionamento com o Cliente"",
""cargo"": ""Auxiliar de Ouvidoria"",
""salario_bruto"": 1800.16,
""data_de_admissao"": 2017-03-31
},
{
""matricula"": 0006877,
""nome"": ""Cross Perkins"",
""area"": ""Relacionamento com o Cliente"",
""cargo"": ""Líder de Ouvidoria"",
""salario_bruto"": 3371.47,
""data_de_admissao"": 2016-12-06
}
]}";


            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Funcionario>>(funcionariosArquivo);
        }
    }
}
