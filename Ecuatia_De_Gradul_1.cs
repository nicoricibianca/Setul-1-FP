using System;

namespace Setul1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti o valoare pentru a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti o valoare pentru b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double x = -b / a;
                Console.WriteLine("Solutia este: x=" + x);
            }
            else
            {
                Console.WriteLine("Nu exista solutii pentru a=0");
            }
        }
    }
}