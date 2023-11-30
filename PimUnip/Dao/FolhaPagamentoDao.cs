using PimUnip.Controllers;
using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Dao
{
    public class FolhaPagamentoDao : IFolhaPagamentoservice
    {
        public FolhaPagamentoDao() { }
        public void InsertOne(FolhaPagamentoModal request)
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

        public List<FolhaPagamentoModal> ListAll()
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
