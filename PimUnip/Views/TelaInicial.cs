using PimUnip.Controllers;
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
        private readonly FuncionarioController _controller;
        private readonly FolhaPagamentoController _folhaPagamentoController;
        private readonly DepartamentoController _departamentoController;
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void new_depart_Click(object sender, EventArgs e)
        {
            NovoDepartamento novoDepartamento = new NovoDepartamento(_departamentoController);
            novoDepartamento.Show();
        }
        private void new_func_Click(object sender, EventArgs e)
        {
            CadastroFunc cadastro = new CadastroFunc(_controller, _departamentoController);
            cadastro.Show();
        }
        private void delete_func_Click(object sender, EventArgs e)
        {
            DemitirFunc demitirFunc = new DemitirFunc(_controller);
            demitirFunc.Show();
        }
        private void edit_cargo_Click(object sender, EventArgs e)
        {
            MudarCargo mudarCargo = new MudarCargo(_controller);
            mudarCargo.Show();
        }
        private void list_func_Click(object sender, EventArgs e)
        {
            ListaFuncionarios listaFuncionarios = new ListaFuncionarios(_controller);
            listaFuncionarios.Show();
        }

        private void pagamento_Click(object sender, EventArgs e)
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento(_folhaPagamentoController);
            folhaPagamento.Show();
        }

        private void PagFolha_Click(object sender, EventArgs e)
        {
            CriarFolhaPagamento newfolhaPagamento = new CriarFolhaPagamento(_folhaPagamentoController);
            newfolhaPagamento.Show();
        }
    }
}
