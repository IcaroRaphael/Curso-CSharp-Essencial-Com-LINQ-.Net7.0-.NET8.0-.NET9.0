Console.Write("Insira um número: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write($"{num}! = ");
int fatorial = 1;
for(int i = num; i > 0; i--)
{
    fatorial *= i;
    if(i == 1)
    {
        Console.Write($"{i}");
    }
    else
    {
        Console.Write($"{i}*");
    }
}
Console.Write($" = {fatorial}\n");
Console.ReadKey();
