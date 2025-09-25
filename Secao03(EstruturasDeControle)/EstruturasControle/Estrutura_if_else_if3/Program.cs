Console.WriteLine("## Instrução if-else-if ##\n");

Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("ALUNO REPROVADO");
}
else if(nota >= 5 && nota < 6)
{
    Console.WriteLine("ALUNO EM RECUPERAÇÃO");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("ALUNO APROVADO");
}
else
{
    Console.WriteLine("ALUNO APROVADO COM DISTINÇÃO");
}

Console.WriteLine("Fim do processamento");

Console.ReadKey();
