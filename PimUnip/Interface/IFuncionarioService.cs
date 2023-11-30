using PimUnip.Dao;
using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public interface IFuncionarioService
    {
        void InsertOne(Funcionario funcionario);
        void DeleteOne(string idFuncionario);
        List<Funcionario> ListAll();
        void UpdateCargo(string idFuncionario, string novoCargo, float novoSalario);
    }
}
