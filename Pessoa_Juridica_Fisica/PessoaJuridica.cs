using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Juridica_Fisica
{
    public class PessoaJuridica : Pessoa
    {
        private String cnpj;

        public String getCnpj()
        {
            return cnpj;
        }

        public void setCnpj(String novoCnpj)
        {
            cnpj = novoCnpj;
        }
    }
}
