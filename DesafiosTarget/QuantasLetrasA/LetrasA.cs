using System;

class LetrasA
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase");
        string input = Console.ReadLine();

        int count = CountLetterA(input);

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula e minúscula) ocorre {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }

    static int CountLetterA(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        return count;
    }
}
