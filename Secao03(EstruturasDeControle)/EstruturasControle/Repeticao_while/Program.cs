Console.WriteLine("## Instrução While ##\n");

// var i = 1;
// while(i <= 10)
// {
//     Console.WriteLine($"i = {i}");
//     i++;
// }


// var i = 10;
// while(i > 0)
// {
//     Console.WriteLine($"i = {i}");
//     i--;
// }

int numero;
int contador = 1;

Console.Write("Digite um numero maior que zero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"## Tabuada do {numero}\n");
    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("Número deve ser maior que zero!!");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
