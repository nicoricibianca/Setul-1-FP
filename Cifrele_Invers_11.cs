using System;

namespace Setul1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            Console.Write("Dati un numar caruia sa i se afiseze cifrele invers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numarul {n} scris cu cifrele invers este: ");
            CifreleInvers(n);
        }
         static void CifreleInvers(int num)
        {
            while (num > 0)
            {
                int cifra = num % 10;
                Console.Write(cifra + "");
                num = num / 10;
            }
        }
    }
}