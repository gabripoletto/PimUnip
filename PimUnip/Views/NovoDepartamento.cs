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
    public partial class NovoDepartamento : Form
    {
        private readonly DepartamentoController _controller;
        public NovoDepartamento(DepartamentoController controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        private void sendNewDep_Click(object sender, EventArgs e)
        {
            DepartamentoRequest departamento = new DepartamentoRequest
            {
                NomeDepartamento = inputNovoDepartamento.Text,
                SalarioBase = float.Parse(inputSalarioDep.Text),
            };

            _controller.AdicionarDepartamento(departamento);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
