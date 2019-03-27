using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Application.Services.Messages
{
    [DataContract]
    public class CalcularDistribuicaoLucrosMessageRequest
    {
        [DataMember(Name = "valorMaximoDistribuir")]
        public double VvalorMaximoDistribuir { get; set; }
    }
}
