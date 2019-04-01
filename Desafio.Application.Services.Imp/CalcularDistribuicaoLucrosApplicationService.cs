using System;
using System.Collections.Generic;
using System.Text;
using Desafio.Application.Services.Mappers;
using Desafio.Application.Services.Messages;
using Desafio.Domain.Services.Task;

namespace Desafio.Application.Services.Imp
{
    public class CalcularDistribuicaoLucrosApplicationService : ICalcularDistribuicaoLucrosApplicationService
    {
        public ICalcularDistribuicaoLucrosTaskService CalcularDistribuicaoTaskService { get; }

        public CalcularDistribuicaoLucrosApplicationService(ICalcularDistribuicaoLucrosTaskService calcularDistribuicaoTaskService)
        {
            CalcularDistribuicaoTaskService = calcularDistribuicaoTaskService;
        }

        public CalcularDistribuicaoLucrosMessageResponse CalcularDistribuicaoLucros(CalcularDistribuicaoLucrosMessageRequest request)
        {
            return CalcularDistribuicaoLucrosMappper.MapToResponse(CalcularDistribuicaoTaskService.CalcularDistribuicaoLucros(request.VvalorMaximoDistribuir));
        }
    }
}
