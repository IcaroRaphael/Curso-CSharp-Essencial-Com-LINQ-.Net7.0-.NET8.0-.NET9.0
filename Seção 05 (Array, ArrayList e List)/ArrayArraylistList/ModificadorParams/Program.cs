﻿Console.WriteLine("Soma de números inteiros\n");

var resultado = Calcular.Soma(1, 2, 3, 4, 5);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(10, 20, 30, 40, 50);
Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}
