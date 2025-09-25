string[,] nomes = new string[2, 5];

Console.WriteLine("INSIRA OS NOMES");
for(int i = 0; i < nomes.GetLength(0); i++)
{
    for(int j = 0; j < nomes.GetLength(1); j++)
    {
        Console.Write($"Insira o nome [{i}, {j}]: ");
        nomes[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nMOSTRANDO OS NOMES");
for(int i = 0; i < nomes.GetLength(0); i++)
{
    for(int j = 0; j < nomes.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}] = {nomes[i, j]}\t");
    }
    Console.WriteLine();
}

Console.ReadKey();
