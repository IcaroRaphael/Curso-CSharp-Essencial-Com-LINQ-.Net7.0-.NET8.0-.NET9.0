Console.Write("Insira o tamanho di triângulo:");
int altura = int.Parse(Console.ReadLine());

Console.WriteLine();
for (int i = 1; i <= altura; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();
