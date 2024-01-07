namespace Setul1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect. 
           
            Console.WriteLine("Introduceti un an: ");
            int an = int.Parse(Console.ReadLine());
            if (an % 4 == 0)
            {
                Console.WriteLine("Anul: " + an + " este bisect.");
            }
            else
            {
                Console.WriteLine("Anul: " + an + " nu este bisect.");
            }

        }
    }
}