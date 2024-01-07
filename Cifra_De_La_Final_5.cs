using System;

namespace Setul1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            Console.WriteLine("Dati un numar intreg: ");
            int n = int.Parse(Console.ReadLine());
            int cifra = n % 10;
            Console.WriteLine("Cifra de la sfarsitul numarului introdus este: " +  cifra);

        }
    }
}