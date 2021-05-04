using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor_Aluno_2_2
{
    class Aluno
    {
        public String nome;
        public int matricula;
        public String email;

        public void InserirDisciplina()
        {
            Console.WriteLine("Aluno inserindo disciplina");
        }
        public void RemoverDisciplina()
        {
            Console.WriteLine("Aluno removendo disciplina");
        }
        public void RealizarMatricula() 
        {
            Console.WriteLine("Aluno realizando matricula");
        }
    }
}
