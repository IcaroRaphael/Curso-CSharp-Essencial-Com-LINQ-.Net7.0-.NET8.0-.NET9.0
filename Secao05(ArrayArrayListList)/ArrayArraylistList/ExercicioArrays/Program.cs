string[] nomes = new string[5];
double[] notas = new double[5];

double somaTotal = 0;
for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o nome do {i + 1}º aluno: ");
    nomes[i] = Console.ReadLine();
    Console.Write($"Digite a nota do {i + 1}º aluno: ");
    notas[i] = double.Parse(Console.ReadLine());
    Console.WriteLine();
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{nomes[i]}: {notas[i]:F2}");
    somaTotal += notas[i];
}

Console.WriteLine($"\nMédia: {(somaTotal/notas.Length):F2}");
Console.ReadKey();
