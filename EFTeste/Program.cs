using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EFTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                ID= 1,
                NomeCliente = "Matheus",
                Endereco = "Rua Batata, numero 51"
            };
            
            ClienteContext db = new ClienteContext();
            db.Cliente.Add(cliente);
            db.SaveChanges();

            Console.WriteLine("Inserir Valores");
            Console.ReadKey();
        }
    }
}
