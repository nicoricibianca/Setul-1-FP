namespace Setul1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
            Console.WriteLine("Dati 2 valori a si b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
             a = b;
             b = c;
            Console.WriteLine($"a = {a}, b = {b}.");




        }
    }
}