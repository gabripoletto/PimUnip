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

namespace PimUnip
{
    public partial class CadastroFunc : Form
    {
        public CadastroFunc()
        {
            InitializeComponent();
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

            var result = Funcionario.Parse(funcionario);

            InserirFuncionario(result);
            AttQntFuncionarios(IdDep.Text);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AttQntFuncionarios(string idDepartamento)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "UPDATE departamento SET funcionarios = funcionarios + 1 WHERE id_Departamento = @IdDepartamento";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdDepartamento", idDepartamento);

                command.ExecuteNonQuery();
            }
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "INSERT INTO funcionarios (id_Funcionario, nome, idade, endereco, telefone, cargo, salario) " +
                               "VALUES (@IdFuncionario, @Nome, @Idade, @Endereco, @Telefone, @Cargo, @Salario)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdFuncionario", funcionario.Id);
                command.Parameters.AddWithValue("@Nome", funcionario.Nome);
                command.Parameters.AddWithValue("@Idade", funcionario.Idade);
                command.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
                command.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                command.Parameters.AddWithValue("@Salario", funcionario.Cargo);
                command.Parameters.AddWithValue("@Cargo", funcionario.Cargo);

                command.ExecuteNonQuery();
            }
        }
    }
}
