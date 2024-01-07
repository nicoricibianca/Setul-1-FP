using System;

namespace Setul1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
           Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  */
            Console.WriteLine("Dati 2 numere naturale: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}