using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Cliente
    {
        public string nome;
        public string cpf;

        public Cliente (string novoNome, string novoCpf)
        {
            nome = novoNome;
            cpf = novoCpf;
        }
    }
}
