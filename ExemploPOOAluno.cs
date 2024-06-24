using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class ExemploPOOAluno
    {
        string nome = "Luiza";
        int idade = 19;
        string saude = "ruim";
        bool louca = true;

        public static void Main(string[] args)
        {
            ExemploPOOAluno ana = new ExemploPOOAluno();
            Console.WriteLine(ana.nome);
            Console.WriteLine(ana.saude);
        }
    }
}
