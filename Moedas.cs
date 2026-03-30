using System;
using System.Data;
using System.Globalization;

Console.WriteLine("--- Conversor de Moedas ---");
Console.WriteLine("Digite o valor em Reais: R$");
decimal valorReal = decimal.Parse(Console.ReadLine()); 

Console.WriteLine("Escolha a moeda: ");
Console.WriteLine("1 - Dollar");
Console.WriteLine("2 - Euro");
Console.WriteLine("3 - Iene");
Console.WriteLine("4 - Libra");

int opcao = int.Parse(Console.ReadLine());
Moeda moedaEscolhida = (Moeda)opcao;


ConversorMoeda conversor = new ConversorMoeda();

decimal convertido = conversor.Converter(valorReal, moedaEscolhida);

string resultado = FormatarMoeda(convertido, moedaEscolhida);

Console.WriteLine($"\nValor convertido: {resultado}");

string FormatarMoeda(decimal valor, Moeda moeda)
{
    switch (moeda)
    {
        case Moeda.Dolar:
            return valor.ToString("C", new CultureInfo("en-US"));

        case Moeda.Euro:
            return valor.ToString("C", new CultureInfo("fr-FR"));

        case Moeda.Iene:
            return valor.ToString("C", new CultureInfo("ja-JP"));

        case Moeda.Libra:
            return valor.ToString("C", new CultureInfo("en-GB"));

        default:
            return valor.ToString();
    }
}

class ConversorMoeda
{
    public decimal Converter(decimal valor, Moeda moeda)
    {
        switch (moeda)
        {
            case Moeda.Dolar:
                return valor / 4.50m;
            case Moeda.Euro:
                return valor / 6.20m;
            case Moeda.Iene:
                return valor / 0.056m;
            case Moeda.Libra:
                return valor / 6.95m; // m no final avisa que o valor eh decimal
            default:
                return 0;
        }
    }
}

public enum Moeda
{
    Dolar = 1,
    Euro = 2,
    Iene = 3,
    Libra = 4
}

