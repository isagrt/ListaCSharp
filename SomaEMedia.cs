using System;
using System.Collections.Generic;
using System.Linq;


class SomaEMedia
{
    static void Main()
    {
        Console.Write("Quantos números deseja informar (3 a 10)? ");
        int quantidade = int.Parse(Console.ReadLine());

        while (quantidade < 3 || quantidade > 10)
        {
            Console.Write("Valor inválido! Digite entre 3 e 10: ");
            quantidade = int.Parse(Console.ReadLine());
        }

        List<double> numeros = new List<double>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            double num;

            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Valor inválido, digite novamente: ");
            }
            numeros.Add(num);
        }

        double soma = numeros.Sum();
        double media = numeros.Average();

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
    }

    static double CalcularSoma(List<double> numeros)
    {
        double soma = 0;
        foreach (double num in numeros)
            soma += num;

        return soma;
    }
}

