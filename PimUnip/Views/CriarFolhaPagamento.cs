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
    public partial class CriarFolhaPagamento : Form
    {
        public CriarFolhaPagamento()
        {
            InitializeComponent();
        }

        private void criar_Click(object sender, EventArgs e)
        {
            float descontoPercentual = 7.5f;

            FolhaPagamentoModal newPagamento = new FolhaPagamentoModal
            {
                IdFolha = Guid.NewGuid(),
                HorasTrabalhadas = float.Parse(hrs_trab.Text),
                SalarioBruto = float.Parse(sal_bruto.Text),
                SalarioLiquido = (float.Parse(sal_bruto.Text) * descontoPercentual) / 100,
            };

            novaFolhaPagamento(newPagamento);
        }

        public void novaFolhaPagamento(FolhaPagamentoModal request)
        {
            string query = $"INSERT INTO folha_Pagamento (id_folha_pagamento, hrs_Trabalhadas, salario_Bruto, salario_Liquido) " +
                   $"VALUES ('{request.IdFolha}', {request.HorasTrabalhadas}, {request.SalarioBruto}, {request.SalarioLiquido})";

            string connectionString = "@\"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria\"";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
