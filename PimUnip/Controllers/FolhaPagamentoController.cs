using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public class FolhaPagamentoController
    {
        private readonly IFolhaPagamentoservice _service;
        public FolhaPagamentoController(IFolhaPagamentoservice service)
        {
            _service = service;
        }

        public void CriarFolhaPagamento(FolhaPagamentoModal request)
        {
            try
            {
                _service.InsertOne(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<FolhaPagamentoModal> ListarFolhaPagamento()
        {
            return _service.ListAll();
        }
    }
}
