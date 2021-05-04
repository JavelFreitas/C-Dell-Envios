using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa_Juridica_Fisica
{
    public class Pessoa
    {
        private String nome;
        private int telefone;

        public String getNome()
        {
            return nome;
        }

        public void setNome(String novoNome)
        {
            nome = novoNome;
        }

        public int getTelefone()
        {
            return telefone;
        }

        public void setTelefone(int novoTelefone)
        {
            telefone = novoTelefone;
        }
    }
}
