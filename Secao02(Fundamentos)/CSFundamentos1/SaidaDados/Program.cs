Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write("Maria"); //Escreve sem pular linha
Console.WriteLine(idade); //Escreve e pula linha

//Escrever na mesma linha 'Maria tem 25 anos'
Console.WriteLine(nome + " tem " + idade + " anos");

//Usar a interpolação de strings
Console.WriteLine($"{nome} tem {idade} anos");

//Usando place holders : usa {} com numeração com início em 0
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
