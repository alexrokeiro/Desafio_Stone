using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Application.Services.Messages
{
    [DataContract]
    public class CalcularDistribuicaoLucrosMessageResponse
    {
        [DataMember(Name = "participacoes")]
        public List<ParticipacaoMessage> Participacoes { get; set; }

        [DataMember(Name = "total_de_funcionarios")]
        public string TotaldeFuncionarios { get; set; }

        [DataMember(Name = "total_distribuido")]
        public string TotaldeDistribuido { get; set; }

        [DataMember(Name = "total_disponibilizado")]
        public string TotalDisponibilizado { get; set; }

        [DataMember(Name = "saldo_total_disponibilizado")]
        public string SaldTotalDisponibilizado { get; set; }
    }
}
