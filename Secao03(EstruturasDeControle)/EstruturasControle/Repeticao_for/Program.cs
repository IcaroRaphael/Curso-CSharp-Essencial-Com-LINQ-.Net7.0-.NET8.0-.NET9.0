Console.WriteLine("## Instrução for ##\n");

int resultado, numero;

Console.Write("Informe um numero inteiro maior que 0: ");
numero = Convert.ToInt32(Console.ReadLine());

if(numero > 0  )
{
    for(int i = 1; i <= 10; i++){
    resultado = numero * i;
    // Console.WriteLine(numero + " X " + i + " = " + resultado);
    Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
