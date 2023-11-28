using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Models
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public static Funcionario Parse(FuncionarioRequest request)
        {
            Funcionario funcionario = new Funcionario
            {
                Id = Guid.NewGuid().ToString(),
                Cpf = request.Cpf,
                Nome = request.Nome,
                Idade = request.Idade,
                Endereco = request.Endereco,
                Salario = request.Salario,
                Telefone = request.Telefone,
                Cargo = request.Cargo
            };

            return funcionario;
        }

    }
}
