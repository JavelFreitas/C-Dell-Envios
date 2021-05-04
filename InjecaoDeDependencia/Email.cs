using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    class Email : IMensagem
    {
        public void Enviar()
        {
            Console.WriteLine("Enviado E-Mail");
        }
    }
}
