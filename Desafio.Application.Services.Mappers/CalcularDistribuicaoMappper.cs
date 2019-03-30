﻿using Desafio.Application.Services.Messages;
using Desafio.Domain.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Desafio.Application.Services.Mappers
{
    public class CalcularDistribuicaoMappper
    {
        public static CalcularDistribuicaoLucrosMessageResponse MapToResponse(DistribuicaoLucros model)
        {
            if (model == null)
                return new CalcularDistribuicaoLucrosMessageResponse();

            var response = new CalcularDistribuicaoLucrosMessageResponse();
            response.SaldTotalDisponibilizado = model.SaldoTotalDisponibilizado.ToString();
            response.TotaldeDistribuido = model.TotalDistribuido.ToString();
            response.TotaldeFuncionarios = model.Funcionarios.Count().ToString();
            response.TotalDisponibilizado = model.TotalDisponibilizado.ToString();
            response.Participacoes = MapToResponse(model.Funcionarios);

            return response;

        }

        public static List<ParticipacaoMessage> MapToResponse(List<Funcionario> models)
        {
            if (models == null)
                return new List<ParticipacaoMessage>();

            var list = new List<ParticipacaoMessage>();

            foreach (Funcionario model in models)
            {
                list.Add(MapToResponse(model));
            }

            return list;
        }

        public static ParticipacaoMessage MapToResponse(Funcionario model)
        {
            if (model == null)
                return new ParticipacaoMessage();

            var culture = CultureInfo.CreateSpecificCulture("pt-BR");

            var response = new ParticipacaoMessage();
            response.Matricula = model.Matricula;
            response.Nome = model.Nome;
            response.ValorParticipacao = $"R$: {model.ValorDistribuicao.ToString("C",culture)}";

            return response;
        }
    }
}
