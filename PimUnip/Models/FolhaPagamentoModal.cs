using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Models
{
    public class FolhaPagamentoModal
    {
        public Guid IdFolha { get; set; }
        public float HorasTrabalhadas { get; set; }
        public float SalarioBruto { get; set; }
        public float SalarioLiquido { get; set; }
    }
}
