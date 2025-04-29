int i = 1, j = 1;
do
{
    j = 1;
    do
    {
        Console.Write($"{i} x {j} = {i*j}\n");
        j++;
    } while (j <= 10);
    Console.WriteLine();
    i++;
} while (i <= 6); ;
Console.ReadKey();
