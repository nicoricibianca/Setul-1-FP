using System;

class Program
{
    static void Main()
    {
        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        //De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        Console.Write("Introduceti un numar natural n: ");
        int n = int.Parse(Console.ReadLine());

        bool hasOnlyTwoRepeatableDigits = numereRepetabile(n);

        if (hasOnlyTwoRepeatableDigits)
        {
            Console.WriteLine($"Numarul {n} contine doar 2 cifre care se repeta.");
        }
        else
        {
            Console.WriteLine($"Numarul {n} are mai multe cifre care se repeta.");
        }
    }

    static bool numereRepetabile(int num)
    {
        int count = 0;
        int ultimaCifra = num % 10;
        num /= 10;

        while (num > 0)
        {
            int currentDigit = num % 10;
            if (currentDigit != ultimaCifra)
            {
                count++;

                if (count > 1)
                {
                    return false; // More than two different digits found
                }
            }

            ultimaCifra = currentDigit;
            num /= 10;
        }

        return true; // Only two repeatable digits found
    }
}
