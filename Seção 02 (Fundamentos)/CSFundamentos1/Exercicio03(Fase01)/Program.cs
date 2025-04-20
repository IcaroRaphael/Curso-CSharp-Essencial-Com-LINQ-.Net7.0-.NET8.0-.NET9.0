// Crie uma variável chamada altura e atribua a ela o valor 3.45.

//float altura = 3.45f;
//Console.WriteLine($"Altura = {altura.ToString("F2")}");

using System.Globalization;

float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"Altura = {altura.ToString("F2")}");
