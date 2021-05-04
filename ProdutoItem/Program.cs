using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            char option = 'a';
            while(option != 's')
            {
                Pedido order = new Pedido(1, "29/12/2020", "000.000.000-0");
                ItemPedido item = new ItemPedido(1, "NA", 0, "000.000.000-0");

                Console.WriteLine($"Pedido: {order}");
                Console.WriteLine($"ItemPedido: {item}\n");

                Console.WriteLine("Para terminar o programa digite 's' e aperte enter");
                option = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
