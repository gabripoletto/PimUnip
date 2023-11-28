using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Models
{
    public class FuncionarioRequest
    {
        public Guid Id { get; set; }
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public string? Cargo { get; set; }
    }
}
