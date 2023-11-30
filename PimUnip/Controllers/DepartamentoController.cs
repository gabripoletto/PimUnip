using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public class DepartamentoController
    {
        private readonly IDepartamentoService _service;
        public DepartamentoController(IDepartamentoService service)
        {
            _service = service;
        }

        public void AdicionarDepartamento(DepartamentoRequest request)
        {
            try
            {
                var result = Departamento.Parse(request);

                _service.InsertOne(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeletarDepartamento(string idDepartamento)
        {
            try
            {
                _service.DeleteDep(idDepartamento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void AdicionarFuncDepart(string idDepartamento)
        {
            try
            {
                _service.UpdateAddFunc(idDepartamento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
