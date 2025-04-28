using System.Runtime.InteropServices;

Console.WriteLine("Os 10 primeiros números naturais são: ");
int soma = 0;
for (int j = 1; j <= 10; j++)
{
    Console.Write($"{j} ");
    soma += j;
}
Console.WriteLine($"\nA soma dos números é: {soma}");
Console.WriteLine();


Console.WriteLine("Os 10 primeiros números naturais são:");
soma = 0;
int i = 1;
do
{
    Console.Write($"{i} ");
    soma += i;
    i++;
}
while (i <= 10);
Console.WriteLine($"\nA soma dos números é: {soma}");
Console.WriteLine();


Console.WriteLine("Os 10 primeiros números naturais são:");
soma = 0;
i = 1;
while(i <= 10)
{
    Console.Write($"{i} ");
    soma += i;
    i++;
}
Console.WriteLine($"\nA soma dos números é: {soma}");
Console.WriteLine();


Console.ReadKey();
