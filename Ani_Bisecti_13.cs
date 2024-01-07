using System;

namespace Setul1Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            Console.WriteLine("Dati 2 ani: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = NumaraAniBisecti(a, b);
            Console.WriteLine($"Numarul de ani bisecti este {c}");
        }
        private static int NumaraAniBisecti(int a, int b)
        {
            int numara = 0;
            for (int i =  a; i<=  b; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    numara++;
                }
            }
            return numara;
        }
    }
}