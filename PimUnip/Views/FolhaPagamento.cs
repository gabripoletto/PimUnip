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
    public partial class FolhaPagamento : Form
    {
        public FolhaPagamento()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            List<FolhaPagamentoModal> folhasPagamento = ObterTodasFolhasPagamento();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = folhasPagamento;
        }

        public List<FolhaPagamentoModal> ObterTodasFolhasPagamento()
        {
            List<FolhaPagamentoModal> folhasPagamento = new List<FolhaPagamentoModal>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "SELECT * FROM folha_Pagamento";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FolhaPagamentoModal folha = new FolhaPagamentoModal
                    {
                        IdFolha = Guid.NewGuid(),
                        HorasTrabalhadas = Convert.ToSingle(reader["hrs_Trabalhadas"]),
                        SalarioBruto = Convert.ToSingle(reader["salario_Bruto"]),
                        SalarioLiquido = Convert.ToSingle(reader["salario_Liquido"])
                    };

                    folhasPagamento.Add(folha);
                }
            }

            return folhasPagamento;
        }
    }
}
