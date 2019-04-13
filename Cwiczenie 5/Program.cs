using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("podaj wartosc n: ");
            string text = Console.ReadLine();
            if (!Int32.TryParse(text, out n))
                throw new ArgumentException("n nie jest liczba calkowita!\n");
                    int silnia = Factorial(n);
            Console.WriteLine("silnia liczby {0} wynosi: {1}", n, silnia);
            Console.ReadKey();    }
        /********************************************/
        static int Factorial (int mm)
        {
            //Policz silnie 
            int i = 1;
            int wynik = 1;
            while (i <= mm)
                wynik *= i++;
            return wynik;
        }
    }
}
