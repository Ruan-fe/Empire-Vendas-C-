using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireVendas.CAMADAS.BLL
{
    public class TipoVenda
    {
        public List<MODEL.TipoVenda> Select()
        {
            DAL.TipoVenda dalTipoVenda = new DAL.TipoVenda();
            ///... verificações e regras de negócios
            return dalTipoVenda.Select();
        }
    }
}
