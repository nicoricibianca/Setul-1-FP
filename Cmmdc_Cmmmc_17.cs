using System;

namespace Setul1Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
            Console.WriteLine("Dati doua numere: ");

            Console.Write("Primul numar: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Al doilea numar: ");
            int num2 = int.Parse(Console.ReadLine());

            int cmmdc = Cmmdc(num1, num2);
            int cmmmc = Cmmmc(num1, num2);

            Console.WriteLine($"Cmmdc este {cmmdc}.");
            Console.WriteLine($"Cmmmc este {cmmmc}.");

            
        }

        static int Cmmdc(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Cmmmc(int a, int b)
        {
            int cmmdc = Cmmdc(a, b);
            int cmmmc = (a * b) / cmmdc;
            return cmmdc;
        }
    }
}