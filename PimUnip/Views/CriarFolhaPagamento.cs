using PimUnip.Controllers;
using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimUnip.Views
{
    public partial class CriarFolhaPagamento : Form
    {
        private readonly FolhaPagamentoController _controller;

        public CriarFolhaPagamento(FolhaPagamentoController controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        private void criar_Click(object sender, EventArgs e)
        {
            float descontoPercentual = 7.5f;

            FolhaPagamentoModal newPagamento = new FolhaPagamentoModal
            {
                IdFolha = Guid.NewGuid(),
                HorasTrabalhadas = float.Parse(hrs_trab.Text),
                SalarioBruto = float.Parse(sal_bruto.Text),
                SalarioLiquido = (float.Parse(sal_bruto.Text) * descontoPercentual) / 100,
            };

            _controller.CriarFolhaPagamento(newPagamento);
        }
    }
}
