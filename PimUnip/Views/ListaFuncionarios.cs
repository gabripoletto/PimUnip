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
    public partial class ListaFuncionarios : Form
    {
        private readonly FuncionarioController _controller;
        public ListaFuncionarios(FuncionarioController controller)
        {
            InitializeComponent();
            CarregarDados();

            _controller = controller;
        }

        private void CarregarDados()
        {
            List<Funcionario> listaFuncionarios = _controller.ListarFuncionarios();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaFuncionarios;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
