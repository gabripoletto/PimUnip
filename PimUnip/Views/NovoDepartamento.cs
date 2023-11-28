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
        public NovoDepartamento()
        {
            InitializeComponent();
        }

        private void sendNewDep_Click(object sender, EventArgs e)
        {
            DepartamentoRequest departamento = new DepartamentoRequest
            {
                NomeDepartamento = inputNovoDepartamento.Text,
                SalarioBase = float.Parse(inputSalarioDep.Text),
            };

            var result = Departamento.Parse(departamento);

            InserirDepartamento(result);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InserirDepartamento(Departamento departamento)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "INSERT INTO departamento (id_Departamento, nome_Departamento, funcionarios, salario_Base) " +
                               "VALUES (@IdDepartamento, @NomeDepartamento, @Funcionarios, @SalarioBase)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdDepartamento", departamento.IdDepartamento);
                command.Parameters.AddWithValue("@NomeDepartamento", departamento.NomeDepartamento);
                command.Parameters.AddWithValue("@Funcionarios", departamento.Funcionarios);
                command.Parameters.AddWithValue("@SalarioBase", departamento.SalarioBase);

                command.ExecuteNonQuery();
            }
        }
    }
}
