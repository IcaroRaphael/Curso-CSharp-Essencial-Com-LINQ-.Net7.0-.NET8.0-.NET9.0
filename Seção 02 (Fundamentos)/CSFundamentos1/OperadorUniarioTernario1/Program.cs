Console.WriteLine("## Operador Uniário e Ternário ##\n");

//Console.Write("Informe o número: ");
//var n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"O negativo de {n} é {-n}");

//Console.Write("Informe a temperatura: ");
//var temp = Convert.ToDouble(Console.ReadLine());
//var resultado = temp > 27 ? "quente" : "normal";
//Console.WriteLine($"O tempo está {resultado}");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem Resultado";

Console.WriteLine(resultado);

Console.ReadKey();