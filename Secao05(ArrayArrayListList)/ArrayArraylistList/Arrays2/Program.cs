int[] numeros;
//Alocar memoria
numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento de Índice {i}: {numeros[i]}");
}
Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento de Índice {i}: {nomes[i]}");
}
Console.WriteLine();
Console.ReadKey();
