﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definicje i wydruk zmiennych
            int a = 3, b = 4;
            Console.WriteLine("Po zmianie:  a={0}, b = {1}", a, b);
            Interchange(ref a, ref b);
            Console.WriteLine("Po zmianie: a={0}, b={1}", a, b);
            Console.ReadKey();
        
        }
        /****************************************/
        static void Interchange(ref int aa,ref int bb)
        {
            int tmp = aa;
            aa = bb;
            bb = tmp;
        }
    }
}
