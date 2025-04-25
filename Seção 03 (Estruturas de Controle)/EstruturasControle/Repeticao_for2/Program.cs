Console.WriteLine("## Loop For\n");

// for (int i = 0, j = 0; i+j <= 20; i++, j++)
// {
//     Console.WriteLine($"i = {i} e j = {j}");
// }

// int i = 1;
// for( ; i <= 10; )
// {
//     Console.WriteLine($"i = {i}");
//     i++;
// }

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.Write($"({i}, {j}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
