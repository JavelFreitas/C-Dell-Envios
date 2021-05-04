using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Juridica_Fisica
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "a";
            while (op != "s")
            {
                PessoaFisica pfisica = new PessoaFisica();
                PessoaJuridica pjuridica = new PessoaJuridica();

                pfisica.setNome("Claudio");
                Console.WriteLine(pfisica.getNome());

                pjuridica.setCnpj("00000");
                Console.WriteLine(pjuridica.getCnpj());

                Console.WriteLine("Insira s para sair");
                op = Console.ReadLine();
            }
        }
    }
}
