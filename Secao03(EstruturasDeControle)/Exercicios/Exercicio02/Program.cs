Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c) :");

Console.Write("Informe o valor de A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Informe o valor de B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Informe o valor de C: ");
int c = int.Parse(Console.ReadLine());

int delta = (b * b) - (4 * a * c);

if(delta > 0)
{
    int x1 = (int)((- b + Math.Sqrt(delta)) / (2 * a));
    int x2 = (int)((- b - Math.Sqrt(delta)) / (2 * a));
    Console.WriteLine("Ambas as raízes são reais e diferentes");
    Console.WriteLine($"Primeira raiz x1 = {x1}");
    Console.WriteLine($"Segunda raiz x2 = {x2}");
}
else if(delta == 0)
{
    int x = (int)( -b / (2 * a));
    Console.WriteLine("Só há uma raiz.");
    Console.WriteLine($"A raiz é: {x}");
}
else
{
    Console.WriteLine("As raízes são imaginárias;");
    Console.WriteLine("Sem solução para os números reais.");
}
Console.ReadKey();
