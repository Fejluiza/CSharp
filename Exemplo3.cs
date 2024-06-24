using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo3
    {
        public static void Main(string[] args)
        {
            Equipe2("Ana Luiza", 2);
        }
        static void Equipe2(string nome, int numeroEquipe)
        {
            Console.WriteLine($"{nome} pertence a equipe {numeroEquipe}");
        }
    }
}
