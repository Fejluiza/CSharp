using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo2
    {
        public static void Main(string[] args)
        {
            Equipe("02");
        }
        static void Equipe(string numeroEquipe)
        {
            Console.WriteLine($"equipe {numeroEquipe}");
        }
    }
}
