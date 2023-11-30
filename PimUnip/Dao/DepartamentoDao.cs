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
    public class DepartamentoDao : IDepartamentoService
    {
        public DepartamentoDao() { }
        
        public void UpdateAddFunc(string idDepartamento)
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

        public void InsertOne(Departamento departamento)
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

        public void DeleteDep(string idDepartamento)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=PEDROSNOTE; integrated security=SSPI;initial catalog=SQL_Imobiliaria"))
            {
                connection.Open();

                string query = "DELETE FROM departamento WHERE id_Departamento = @IdDepartamento";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdDepartamento", idDepartamento);

                command.ExecuteNonQuery();
            }
        }
    }
}
