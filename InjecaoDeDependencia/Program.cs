using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerMensagens controller = new ControllerMensagens(new SMS());
            controller.realizarEnvio();
        }
    }
}
