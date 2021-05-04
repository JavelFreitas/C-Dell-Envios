using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    class SMS : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando SMS");
        }
    }
}
