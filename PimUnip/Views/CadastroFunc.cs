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
using static System.Net.Mime.MediaTypeNames;

namespace PimUnip
{
    public partial class CadastroFunc : Form
    {
        private readonly FuncionarioController _controller;
        private readonly DepartamentoController _departamentoController;
        public CadastroFunc(FuncionarioController controller, DepartamentoController departamentoController)
        {
            InitializeComponent();

            _controller = controller;
            _departamentoController = departamentoController;
        }
        private void sendNewFunc_Click(object sender, EventArgs e)
        {
            FuncionarioRequest funcionario = new FuncionarioRequest
            {
                Nome = inputNomeFunc.Text,
                Cpf = inputCpfFunc.Text,
                Idade = int.Parse(inputIdadeFunc.Text),
                Endereco = inputEndFunc.Text,
                Telefone = inputTelFunc.Text,
                Cargo = inputCargoFunc.Text,
                Salario = long.Parse(inputSalario.Text),
            };

            _controller.AddFuncionario(funcionario);
            _departamentoController.AdicionarFuncDepart(IdDep.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
