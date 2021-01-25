using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OficinaAPIWeb.Models
{
    public class Pedido
    {
        public int codigoPedido { get; set; }
        public DateTime dataPedido { get; set; }
        public string cpfCliente { get; set; }
    }
}