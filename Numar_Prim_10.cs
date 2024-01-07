using System;

namespace Setul1Ex10
{
    internal class Program
    {
        private static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Dati un numar natural n: ");
            int numar = int.Parse(Console.ReadLine());
            if (IsPrime(numar))
            {
                Console.WriteLine(numar + " este numar prim.");
            }
            else
            {
                Console.WriteLine(numar + " nu este numar prim.");
            }
        }
    }
}