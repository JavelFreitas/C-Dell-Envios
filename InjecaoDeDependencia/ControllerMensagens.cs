using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia
{
    class ControllerMensagens
    {
        IMensagem msg;
        public ControllerMensagens(IMensagem novaMensagem)
        {
            msg = novaMensagem;
        }

        public void realizarEnvio()
        {
            msg.Enviar();
        }
    }
}
