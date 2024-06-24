using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo4Return
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A divisão dos números informados é: {Dividir(x, y)}");
        }

        static double Dividir(double x, double y)
        {
            return x / y;
        }
    }
}
