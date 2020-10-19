using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireVendas.CAMADAS.MODEL
{
    public class Recebimentos
    {
        public int id_conta { get; set; }
        public DateTime data_compra { get; set; }
        public DateTime data_vencimento { get; set; }
        public int id_status_recebimento { get; set; }
        public int id_cliente { get; set; }
        public string desc_cliente { get; set; }
        public int id_venda { get; set; }
        public float valor { get; set; }

        //futuros
        public string desc_status_recebimento { get; set; }
    }
}
