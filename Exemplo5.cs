using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo5
    {
        public static void Main(string[] args)
        {
            Aluno(nome1: "Lucas", nome2: "Camila", nome3: "Liz");
        }

        static void Aluno(string nome1, string nome2, string nome3)
        {
            Console.WriteLine($"O nome do aluno premiado é: {nome3}");
        }
    }
}
