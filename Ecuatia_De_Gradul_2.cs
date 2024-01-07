using System;

namespace Setul1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            Tratati toate cazurile posibile.*/

            Console.Write("Dati o valoare pentru a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Dati o valoare pt b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Dati o valoare pentru c: ");
            double c = double.Parse(Console.ReadLine());

            Quadratic(a, b, c);
        }

        public static void Quadratic(double a, double b, double c)
        {
            double delta = Math.Sqrt(b * b - 4 * a * c);
            if (delta >= 0)
            {
                double x1 = (-b + delta) / 2*a;
                double x2 = (-b - delta) / 2*a;
                Console.WriteLine("x1= " + x1 + ", x2= " + x2);
            }
            else
            {
                Console.WriteLine("Nu exista radacini");
            }
        }
        
    }
}