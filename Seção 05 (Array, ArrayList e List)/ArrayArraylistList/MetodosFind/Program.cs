List<string> frutas = new()
{
    "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango"
};

//Usando Predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"Predicado => {fruta1}");

//Usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"Expressão lambda => {fruta2}");

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n');
}
