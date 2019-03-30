using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Desafio.Domain.Models
{
    [DataContract]
    public class Funcionarios
    {
        [DataMember(Name = "funcionarios")]
        public List<Funcionario> FuncionariosList { get; set; }

    }
}
