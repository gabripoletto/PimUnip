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
        public ListaFuncionarios()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            List<Funcionario> listaFuncionarios = ObterTodosFuncionarios();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaFuncionarios;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<Funcionario> ObterTodosFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "SELECT * FROM funcionarios";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Funcionario funcionario = new Funcionario
                    {
                        Id = reader["id_Funcionario"].ToString(),
                        Nome = reader["nome"].ToString(),
                        Idade = Convert.ToInt32(reader["idade"]),
                        Endereco = reader["endereco"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        Cargo = reader["cargo"].ToString()
                    };

                    funcionarios.Add(funcionario);
                }
            }

            return funcionarios;
        }
    }
}
