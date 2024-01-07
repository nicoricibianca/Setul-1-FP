namespace Setul1Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 
            Console.Write("Introduceti un numar natural pozitiv n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numarul {n} descompus in factori primi este: ");

            int divizor = 2;

            while (n > 1)
            {
                if (n % divizor == 0)
                {
                    Console.Write(divizor + " ");
                    n /= divizor;
                }
                else
                {
                    divizor++;
                }
            }
            Console.WriteLine();

        }
    }
}