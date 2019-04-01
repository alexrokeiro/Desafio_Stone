using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Application.Services.Messages
{
    [DataContract]
    public class CalcularDistribuicaoLucrosMessageRequest
    {
        [DataMember(Name = "valorMaximoDistribuir")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public double VvalorMaximoDistribuir { get; set; }
    }
}
