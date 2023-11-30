using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public class FuncionarioController
    {
        private readonly IFuncionarioService _service;
        public FuncionarioController(IFuncionarioService service) 
        {
            _service = service;
        }

        public void AddFuncionario(FuncionarioRequest request)
        {
            try
            {
                _service.InsertOne(Funcionario.Parse(request));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ExcluirFuncionario(string request)
        {
            try
            {
                _service.DeleteOne(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Funcionario> ListarFuncionarios()
        {
            return _service.ListAll();
        }

        public void AlterarCargo(string idFuncionario, string novoCargo, float novoSalario)
        {
            try
            {
                _service.UpdateCargo(idFuncionario, novoCargo, novoSalario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
