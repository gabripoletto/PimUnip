using PimUnip.Dao;
using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public interface IDepartamentoService
    {
        void UpdateAddFunc(string idDepartamento);
        void InsertOne(Departamento departamento);
        void DeleteDep(string idDepartamento);
    }
}
