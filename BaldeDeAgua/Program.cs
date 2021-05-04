using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BaldeDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacidadeMaxima = 5.0;
            double quantidadeAtual = 0.0;

            Console.WriteLine("Você tem um balde para encher mas não sabe sua capacidade");
            do
            {
                Console.WriteLine("Quantos litros deseja colocar?");
                
                double aguaInserida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(aguaInserida < 0)
                {
                    Console.WriteLine("Não tire água do balde, estamos tentando encher ele.\n");
                    continue;
                }

                quantidadeAtual += aguaInserida;

                if(quantidadeAtual < (capacidadeMaxima / 2))
                {
                    Console.WriteLine("Menos da metade do balde contem água");
                }
                else if (quantidadeAtual > capacidadeMaxima)
                {
                    Console.WriteLine("Que pena! O balde transbordou...");
                    Console.WriteLine("Vamos tentar de novo do 0. \n");
                    quantidadeAtual = 0.0;
                    continue;
                }
                else if (quantidadeAtual == capacidadeMaxima)
                {
                    Console.WriteLine("O Balde está cheio, Obrigado!");
                    break;
                }
                else if (quantidadeAtual >= (capacidadeMaxima - 1))
                {
                    Console.WriteLine("Está quase cheio, só mais um pouco!");
                }
                else 
                {
                    Console.WriteLine("Coloque mais um pouco");
                }
            } while (quantidadeAtual < capacidadeMaxima);

            Console.WriteLine("\nA capacidade máxima era de {0}", capacidadeMaxima.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade colocada foi de {0}\n", quantidadeAtual.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
