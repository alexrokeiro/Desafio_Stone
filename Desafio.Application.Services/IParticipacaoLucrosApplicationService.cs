using Desafio.Application.Services.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Application.Services
{
    public interface IParticipacaoLucrosApplicationService
    {
        CalcularDistribuicaoLucrosMessageResponse CalcularDistribuicaoLucros(CalcularDistribuicaoLucrosMessageRequest request);
    }
}
