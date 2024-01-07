using System.Diagnostics.CodeAnalysis;

namespace Setul1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
            Console.WriteLine("Dati 3 numere pozitive: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c &  b + c > a & c + a > b)
            {
                Console.WriteLine( $"Numerele {a}, {b} si {c} pot fi lungimile laturilor unui triunghi. ");
            }
            else
            {
                Console.WriteLine($"Numerele {a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi. ");
            }
        }
    }
}