using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Application.Services.Messages
{
    [DataContract]
    public class ParticipacaoMessage
    {
        [DataMember(Name = "matricula")]
        public string Matricula { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "valor_da_participacao")]
        public string ValorParticipacao { get; set; }
    }
}
