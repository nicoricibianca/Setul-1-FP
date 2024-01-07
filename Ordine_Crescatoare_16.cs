using System;

namespace Setul1Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati 5 numere pentru a fi afisate in ordine crescatoare: ");

            Console.Write("Primul numar: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Al doilea numar: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Al treilea numar: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Al patrulea numar: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Al cincilea numar: ");
            int e = int.Parse(Console.ReadLine());

            int[] numere = { a, b, c, d, e };
            Array.Sort(numere);

            Console.WriteLine("Numerele in ordine crescatoare sunt: ");
            foreach (int n in numere)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}