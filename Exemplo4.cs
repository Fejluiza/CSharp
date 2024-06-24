using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo4
    {
        public static void Main(string[] args)
        {
            Carro("Toyota");
            Carro();
            Carro("Honda");
            Carro("Chevrolet");
            Carro();
        }
        static void Carro(string carro = "Pegeout")
        {
            Console.WriteLine(carro);
        }
    }
}
