using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Juridica_Fisica
{
    public class PessoaFisica : Pessoa
    {
        private String cpf;

        public String getCpf()
        {
            return cpf;
        }

        public void setCpf(String novoCpf)
        {
            cpf = novoCpf;
        }
    }
}
