while (true)
{
    Console.Write("\nInsira um número natural (0 para sair): ");
    int numero = int.Parse(Console.ReadLine());

    if (numero == 0)
    {
        Console.WriteLine("Finalizando programa...");
        break;
    }

    if (numero < 0)
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }
    else
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero*i}");
        }
        Console.ReadKey();
        Console.Clear();
    }
}
