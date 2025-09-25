int maiorNumero = 0, posicaoMaior = 0;
for(int i = 1; i <= 3; i++)
{
    Console.Write($"Insira o {i}º número: ");
    int numero = Convert.ToInt32( Console.ReadLine());

    if(i == 1)
    {
        maiorNumero = numero;
        posicaoMaior = i;
    }
    else if(numero > maiorNumero)
    {
        maiorNumero = numero;
        posicaoMaior = i;
    }
}

Console.WriteLine($"O {posicaoMaior}º número: {maiorNumero} é o maior");
Console.ReadKey();
