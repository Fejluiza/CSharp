﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class ExemploReturn
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Somar(2, 4));
        }
        static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
