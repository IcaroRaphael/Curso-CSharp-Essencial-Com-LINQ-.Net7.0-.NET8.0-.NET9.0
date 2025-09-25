int[,] n = 
    {
        {11, 22, 33}, 
        {44, 55, 66}, 
        {77, 88, 99}
    };

Console.WriteLine();
for(int i = 0; i < n.GetLength(0); i++)
{
    for(int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write(n[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
foreach(int num in n)
{
    Console.Write(num + " ");
}

Console.ReadKey();
