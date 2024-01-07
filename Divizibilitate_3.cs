using System;
using System.Runtime.CompilerServices;

namespace Setul1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            Console.WriteLine("Dati doua valori: ");
            int n = int.Parse(Console.ReadLine()); 
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("N se divide cu k.");
            }
            else
            {
                Console.WriteLine("N nu se divide cu k.");
            }


        }
        
        
            


        
            
    }
}