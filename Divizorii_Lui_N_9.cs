using System;

namespace Setul1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n. 
            Console.WriteLine("Dati un numar natural n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii numarului {0} sunt:",n);
            Console.Write("{0} {1}",1,n);
            for (int i = 2; i <= (n/2); i++)
            {
                if ((n % i) == 0) 
                Console.Write(" {0}", i);
            }

          
        }
    }
}