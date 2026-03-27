using System;

Console.Write("Primeiro jogador, digite seu nome: ");
string player1 = Console.ReadLine();

Console.Write("Segundo jogador, digite seu nome: ");
string player2 = Console.ReadLine();

while (player1 == player2)
{
    Console.Write("Eii, os nomes não podem ser iguais! Digite o nome do jogador 2: ");
    player2 = Console.ReadLine();
}

Random dado = new Random();
int pontos1 = 0;
int pontos2 = 0;

for (int rodada = 1; rodada <= 3; rodada++)
{
    int valor1 = dado.Next(1, 7);
    int valor2 = dado.Next(1, 7); // gera de um a 6 

    Console.WriteLine($"\n*Rodada {rodada}:");
    Console.WriteLine($"{player1} tirou {valor1}");
    Console.WriteLine($"{player2} tirou {valor2}");

    if (valor1 > valor2)
    {
        Console.WriteLine($"{player1} venceu a rodada!");
        pontos1++;
    }
    else if (valor2 > valor1)
    {
        Console.WriteLine($"{player2} venceu a rodada!");
        pontos2++;
    }
    else
    {
        Console.WriteLine("Empate!");
    }

    Console.WriteLine("\nPLACAR: ");
    Console.WriteLine($"{player1} | {player2}");
    Console.WriteLine($" {pontos1}  X  {pontos2}");
}

if (pontos1 == pontos2)
{
    Console.Write("Vamos para o desemapate\n");
    while (pontos1 == pontos2)
    {
        int valor1 = dado.Next(1, 7);
        int valor2 = dado.Next(1, 7);

        Console.WriteLine($"{player1} tirou {valor1}");
        Console.WriteLine($"{player2} tirou {valor2}");

        if (valor1 > valor2)
        {
            Console.WriteLine($"{player1} venceu a rodada!");
            pontos1++;
        }
        else if (valor2 > valor1)
        {
            Console.WriteLine($"{player2} venceu a rodada!");
            pontos2++;
        }
        else
        {
            Console.WriteLine("Empate de novo!? Vamos desempatar!!");
        }

    }

}


Console.WriteLine("\n=== RESULTADO FINAL ===");

if (pontos1 > pontos2)
{
    Console.WriteLine($"{player1} venceu o jogo!");
}
else if (pontos2 > pontos1)
{
    Console.WriteLine($"{player2} venceu o jogo!");
}
