using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor_Aluno_2_2
{
    class Professor
    {
        public String nome;
        public int carteiraTrabalho;
        public float salario;

        public void PostarConteudo(String conteudo)
        {
            Console.WriteLine($"Professor postando o conteúdo: {conteudo}");
        }

        public void RealizarChamada()
        {
            Console.WriteLine("Professor realizando chamada");
        }
    }
}
