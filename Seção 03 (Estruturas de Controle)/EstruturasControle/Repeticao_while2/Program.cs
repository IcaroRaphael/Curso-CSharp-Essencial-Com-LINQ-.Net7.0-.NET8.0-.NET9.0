﻿Console.WriteLine("## Instrução While ##\n");

// while(true)
// {
//     Console.Write("Informe um numero inteiro (Para sair tecle 999): ");
//     int numero = Convert.ToInt32(Console.ReadLine());

//     if(numero == 999)
//     {
//         break;
//     }

//     if(numero%2 == 0){
//         Console.WriteLine($"{numero} é PAR");
//     }
//     else
//     {
//         Console.WriteLine($"{numero} é ÍMPAR");
//     }
// }

int x = 0;
while (x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
