using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Cliente_Vendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            while(op != "s")
            {
                Cliente c = new Cliente();
                Vendedor v = new Vendedor();
                Produto p = new Produto();

                Console.WriteLine("Insira s para sair");
                op = Console.ReadLine();
            }
        }
    }
}
