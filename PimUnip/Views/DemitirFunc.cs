using PimUnip.Controllers;
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

namespace PimUnip
{
    public partial class DemitirFunc : Form
    {
        private readonly FuncionarioController _controller;
        public DemitirFunc(FuncionarioController controller)
        {
            InitializeComponent();

            _controller = controller;
        }
        private void delete_func_Click(object sender, EventArgs e)
        {
            var idExclusao = input_id_func_delete.Text;

            _controller.ExcluirFuncionario(idExclusao);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
