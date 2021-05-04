using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois valores reais a serem somados: ");
            try
            {
                double firstValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double secondValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine((firstValue + secondValue).ToString("F2", CultureInfo.InvariantCulture));

            }catch(FormatException fe)
            {
                Console.WriteLine("Informação inserida não é número real, verifique a inserção. " + fe);
            }
        }
    }
}
