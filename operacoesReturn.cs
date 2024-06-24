using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class operacoesReturn
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("As 4 operações matemáticas:");
            Console.WriteLine("Digite um valor:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("As 4 operações matemáticas:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A soma dos valores informados é de: {Soma(x, y)}");
            Console.WriteLine($"A diferença dos valores informados é de: {Subtracao(x, y)}");
            Console.WriteLine($"A divisão dos valores informados é de: {Divisao(x, y)}");
            Console.WriteLine($"A multiplicação dos valores informados é de: {Multiplicacao(x, y)}");
        }

        static double Soma(double x, double y)
        {
            return x + y;
        }
        static double Subtracao(double x, double y)
        {
            return x - y;
        }
        static double Divisao(double x, double y)
        {
            return x / y;
        }
        static double Multiplicacao(double x, double y)
        {
            return x * y;
        }
    }
}
