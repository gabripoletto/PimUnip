using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Models
{
    public class Departamento
    {
        public Guid IdDepartamento { get; set; }
        public string NomeDepartamento { get; set; }
        public int Funcionarios { get; set; }
        public float SalarioBase { get; set; }

        public static Departamento Parse(DepartamentoRequest request)
        {
            Departamento departamento = new Departamento
            {
                IdDepartamento = Guid.NewGuid(),
                NomeDepartamento = request.NomeDepartamento,
                Funcionarios = 0,
                SalarioBase = request.SalarioBase,
            };

            return departamento;
        }
    }
}
