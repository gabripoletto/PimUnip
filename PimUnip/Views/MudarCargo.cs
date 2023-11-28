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
        public MudarCargo()
        {
            InitializeComponent();
        }
        private void sendNewAument_Click(object sender, EventArgs e)
        {
            TrocarCargoSalario(inputIdFunc.Text, inputNewCargo.Text, float.Parse(inputAumento.Text));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TrocarCargoSalario(string idFuncionario, string novoCargo, float novoSalario)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "UPDATE funcionarios SET cargo = @NovoCargo, salario = @NovoSalario WHERE id_Funcionario = @IdFuncionario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
                command.Parameters.AddWithValue("@NovoCargo", novoCargo);
                command.Parameters.AddWithValue("@NovoSalario", novoSalario);

                command.ExecuteNonQuery();
            }
        }
    }
}
