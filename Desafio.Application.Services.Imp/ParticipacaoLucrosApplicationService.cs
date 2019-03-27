using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Application.Services.Mappers;
using Desafio.Application.Services.Messages;
using Desafio.Domain.Services.Task;

namespace Desafio.Application.Services.Imp
{
    public class ParticipacaoLucrosApplicationService : IParticipacaoLucrosApplicationService
    {
        public ICalcularDistribuicaoTaskService CalcularDistribuicaoTaskService { get; }

        public ParticipacaoLucrosApplicationService(ICalcularDistribuicaoTaskService calcularDistribuicaoTaskService)
        {
            CalcularDistribuicaoTaskService = calcularDistribuicaoTaskService;
        }

        public CalcularDistribuicaoLucrosMessageResponse CalcularDistribuicaoLucros(CalcularDistribuicaoLucrosMessageRequest request)
        {
            return CalcularDistribuicaoMappper.MapToResponse(CalcularDistribuicaoTaskService.CalcularDistribuicaoLucros(request.VvalorMaximoDistribuir));
        }
    }
}
