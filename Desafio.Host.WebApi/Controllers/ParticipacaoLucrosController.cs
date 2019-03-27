using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Application.Services;
using Desafio.Application.Services.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Host.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipacaoLucrosController : ControllerBase
    {
        public IParticipacaoLucrosApplicationService ParticipacaoLucrosApplicationService { get; }

        public ParticipacaoLucrosController(IParticipacaoLucrosApplicationService participacaoLucrosApplicationService)
        {
            ParticipacaoLucrosApplicationService = participacaoLucrosApplicationService;
        }

        [HttpPost]
        public CalcularDistribuicaoLucrosMessageResponse Post([FromBody] CalcularDistribuicaoLucrosMessageRequest request)
        {
            return ParticipacaoLucrosApplicationService.CalcularDistribuicaoLucros(request);
        }
    }
}