using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoItem
{
    class Pedido
    {
        int codigoPedido;
        string dataPedido;
        string cpfCliente;
        public Pedido(int codPed, string dataPed, string cpfCli)
        {
            codigoPedido = codPed;
            dataPedido = dataPed;
            cpfCliente = cpfCli;
        }

        public override string ToString()
        {
            return $"Codigo: {codigoPedido}, Data: {dataPedido}, CPF: {cpfCliente}";
        }
    }
}