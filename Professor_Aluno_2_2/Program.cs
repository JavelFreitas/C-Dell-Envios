using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor_Aluno_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alu1 = new Aluno();
            Aluno alu2 = new Aluno();
            Professor prof1 = new Professor();
            Professor prof2 = new Professor();
            string op = "a";

            while (op != "s")
            {
                alu1.nome = "João";
                Console.WriteLine(alu1.nome);

                alu2.InserirDisciplina();

                prof1.nome = "Carlos";
                Console.WriteLine(prof1.nome);

                prof2.PostarConteudo("ORIENTAÇÃO A OBJETOS");

                Console.WriteLine("Encerre inserindo 's'");
                op = Console.ReadLine();
            }

        }
    }
}
