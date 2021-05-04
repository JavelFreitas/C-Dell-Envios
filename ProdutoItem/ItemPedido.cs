using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoItem
{
    class ItemPedido
    {
        int codigoItem;
        string descricaoItem;
        float valorItem;
        string cpfCliente;
        public ItemPedido(int codItem, string descItem, float valItem, string cpfCli)
        {
            this.codigoItem = codItem;
            this.descricaoItem = descItem;
            this.valorItem = valItem;
            this.cpfCliente = cpfCli;
        }

        public override string ToString()
        {
            return $"Codigo: {codigoItem}, Descricao: {descricaoItem}, Valor: {valorItem}, CPF: {cpfCliente}";
        }
    }
}