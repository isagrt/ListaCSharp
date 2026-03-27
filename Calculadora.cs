// 1- Calculadora
/*
using System;

double num1, num2, resultado = 0;
int menu = -1;

while (menu != 0)
{
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1 - Somar \n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Resto da Divisão\n6 - Potenciação\n0 - Sair ");
    Console.WriteLine("============");

    Console.Write("Selecione uma opção:");
    menu = int.Parse(Console.ReadLine());



    switch (menu)
    {
        case 1:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 + num2;
            break;
        case 2:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 - num2;
            break;
        case 3:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 * num2;
            break;
        case 4:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 / num2;

            break;
        case 5:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = num1 % num2;

            break;
        case 6:
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num1, num2);

            break;
        case 0:
            Console.Write("Saindo...");
            break;
        default:
            Console.WriteLine("Operador inválido!");
            continue;
    }
    if (menu != 0)
    {
        Console.WriteLine($"Resultado: {resultado}");
    }
}



*/