using System;
using System.Collections.Generic;

class Fibo
{
    static void Main()
    {
       
        Console.Write("Informe um número: ");
        int numero;

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro não negativo.");
        }

        bool pertence = VerificaFibonacci(numero);

      if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool VerificaFibonacci(int n)
    {
  
        List<int> fibonacci = new List<int> { 0, 1 };

         while (true)
        {
            int proximo = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
            if (proximo > n) break; 
            fibonacci.Add(proximo);
        }

        
        return fibonacci.Contains(n);
    }
}
