using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class ExemploReturn2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Subtrair(6, 5));
        }

        static int Subtrair(int x, int y) {
            return x - y;
        }
    }
}
