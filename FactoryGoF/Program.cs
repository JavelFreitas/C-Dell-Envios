using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator fabricaMoto = new MotoCreator();
            Creator fabricaCarro = new CarroCreator();

            Veiculo motoca = fabricaMoto.criar();
            Veiculo carrito = fabricaCarro.criar();

            motoca.getTipo();
            carrito.getTipo();
        }
    }
}
