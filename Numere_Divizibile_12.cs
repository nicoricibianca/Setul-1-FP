using System;

namespace Setul1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 
            Console.Write("Dati valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Dati valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

            int numara = IntregiDivizibiliCuN(n, a, b);
            Console.WriteLine($"Numerele divizibile cu {n} din intervalul [{a},{b}] sunt: {numara}");

        }

        static int IntregiDivizibiliCuN(int n, int a, int b)
        {
            int numara = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    numara++;
                }
            }
            return numara;
        }
    }
}