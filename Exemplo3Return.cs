using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Exemplo3Return
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A multiplicação dos números solicitados é: {Multiplicar(x,y)}");
        }

        static double Multiplicar(double x, double y)
        {
            return x * y;
        }
    }
}
