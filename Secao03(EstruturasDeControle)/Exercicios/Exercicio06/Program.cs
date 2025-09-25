// Incrementando 2 em cada passo
for(int i = 10; i <= 20; i += 2)
{
    if(i != 16)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();

// Incrementando 1 em cada passo
for (int i = 10; i <= 20; i++)
{
    if(i % 2 == 0)
    {
        if(i != 16)
        {
            Console.Write($"{i} ");
        }
    }
}
Console.WriteLine();

// Com loop infinito (use "break" e "continue")
int j = 10;
while (true)
{
    if(j % 2 == 0)
    {
        if (j != 16)
        {
            Console.Write($"{j} ");
        }
    }
    j++;
    if(j > 20)
    {
        break;
    }
}
Console.WriteLine();
