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
    public class FuncionarioDao : IFuncionarioService
    {
        public FuncionarioDao() { }
        public void InsertOne(Funcionario funcionario)
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

        public void DeleteOne(string idFuncionario)
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

        public List<Funcionario> ListAll()
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

        public void UpdateCargo(string idFuncionario, string novoCargo, float novoSalario)
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
