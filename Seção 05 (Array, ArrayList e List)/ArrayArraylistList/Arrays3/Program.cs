//Declaração do array
int[] numeros;

//Alocação de memória
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = {"Ana", "Maria", "Marta", "Paulo", "Carlos" };

Console.WriteLine();
foreach(int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine();
foreach(string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.ReadKey();
