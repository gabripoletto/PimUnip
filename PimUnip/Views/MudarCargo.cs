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

namespace PimUnip.Views
{
    public partial class MudarCargo : Form
    {
        private readonly FuncionarioController _controller;
        public MudarCargo(FuncionarioController controller)
        {
            InitializeComponent();

            _controller = controller;
        }
        private void sendNewAument_Click(object sender, EventArgs e)
        {
            _controller.AlterarCargo(inputIdFunc.Text, inputNewCargo.Text, float.Parse(inputAumento.Text));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
