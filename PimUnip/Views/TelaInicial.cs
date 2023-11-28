using PimUnip.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimUnip
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void new_depart_Click(object sender, EventArgs e)
        {
            NovoDepartamento novoDepartamento = new NovoDepartamento();
            novoDepartamento.Show();
        }
        private void new_func_Click(object sender, EventArgs e)
        {
            CadastroFunc cadastro = new CadastroFunc();
            cadastro.Show();
        }
        private void delete_func_Click(object sender, EventArgs e)
        {
            DemitirFunc demitirFunc = new DemitirFunc();
            demitirFunc.Show();
        }
        private void edit_cargo_Click(object sender, EventArgs e)
        {
            MudarCargo mudarCargo = new MudarCargo();
            mudarCargo.Show();
        }
        private void list_func_Click(object sender, EventArgs e)
        {
            ListaFuncionarios listaFuncionarios = new ListaFuncionarios();
            listaFuncionarios.Show();
        }

        private void pagamento_Click(object sender, EventArgs e)
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            folhaPagamento.Show();
        }
    }
}
