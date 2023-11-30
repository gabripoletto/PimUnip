using PimUnip.Dao;
using PimUnip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimUnip.Controllers
{
    public interface IFolhaPagamentoservice
    {
        void InsertOne(FolhaPagamentoModal request);
        List<FolhaPagamentoModal> ListAll();
    }
}
