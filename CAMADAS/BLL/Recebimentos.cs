using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireVendas.CAMADAS.BLL
{
    public class Recebimentos
    {
        public List<MODEL.Recebimentos> Select(string nome)
        {
            DAL.Recebimentos dalRecebimentos = new DAL.Recebimentos();
            ///... verificações e regras de negócios
            return dalRecebimentos.Select(nome);
        }

        public List<MODEL.Recebimentos> SelectById(int id)
        {
            DAL.Recebimentos dalRecebimentos = new DAL.Recebimentos();
            ///... verificações e regras de negócios
            return dalRecebimentos.SelectById(id);
        }
    }
}
