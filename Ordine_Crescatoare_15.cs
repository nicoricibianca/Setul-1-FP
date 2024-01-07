namespace Setul1Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            Console.Write("Dati primul numar: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Dati al doilea numar: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Dati al treilea numar: ");
            int c = int.Parse(Console.ReadLine());

            int[] numere = { a, b, c };
            Array.Sort(numere);

            Console.WriteLine("Numerele in ordine crescatoare sunt: ");
            foreach (int i in numere)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}