using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace OficinaAPIWeb.Models
{
    public class PedidosStorage
    {
        public List<Pedido> pedidos;
        public int numPedidos;

        public void addPedido( string cpfCliente)
        {
            Pedido novoPedido = new Pedido();

            novoPedido.codigoPedido = numPedidos;
            numPedidos++;

            novoPedido.cpfCliente = cpfCliente;

            novoPedido.dataPedido = DateTime.Now;

            pedidos.Add(novoPedido);
        }
    }
}