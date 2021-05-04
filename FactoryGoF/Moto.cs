using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGoF
{
    class Moto : Veiculo
    {
        public override void getTipo()
        {
            Console.WriteLine("Tipo do veiculo: Moto");
        }
    }
}
