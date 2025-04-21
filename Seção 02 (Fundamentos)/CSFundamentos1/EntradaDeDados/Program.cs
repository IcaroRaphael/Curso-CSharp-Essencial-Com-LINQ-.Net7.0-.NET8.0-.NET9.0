Console.WriteLine("## Entrada de dados ##\n");

Console.WriteLine("Informe o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe a sua idade:");
int idade = int.Parse(Console.ReadLine());
//int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos.");

Console.ReadKey();
