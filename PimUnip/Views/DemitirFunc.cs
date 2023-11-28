using PimUnip.DAO;
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
        public DemitirFunc()
        {
            InitializeComponent();
        }
        private void delete_func_Click(object sender, EventArgs e)
        {
            var idExclusao = input_id_func_delete.Text;
            ExcluirFuncionario(idExclusao);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ExcluirFuncionario(string idFuncionario)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "DELETE FROM funcionarios WHERE id_Funcionario = @IdFuncionario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                command.ExecuteNonQuery();
            }
        }
    }
}
