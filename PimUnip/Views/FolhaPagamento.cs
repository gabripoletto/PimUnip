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
    public partial class FolhaPagamento : Form
    {
        private readonly FolhaPagamentoController _controller;
        public FolhaPagamento(FolhaPagamentoController controller)
        {
            InitializeComponent();
            CarregarDados();

            _controller = controller;
        }

        private void CarregarDados()
        {
            List<FolhaPagamentoModal> folhasPagamento = _controller.ListarFolhaPagamento();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = folhasPagamento;
        }
    }
}
