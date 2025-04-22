Console.WriteLine("## Operadores Aritméticos ##\n");

Console.WriteLine("Informe o valor de X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y:");
int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"soma de X + Y = {x + y}");
//Console.WriteLine($"subtração de X - Y = {x - y}");
//Console.WriteLine($"multiplicação de X * Y = {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"divisão de X / Y = {divisao}");
//Console.WriteLine($"módulo de X % Y = {x % y}");

Console.WriteLine($"Raiz quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de X elevado a Y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor mínimo entre X e Y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo entre X e Y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de X = {Math.Cos(x)}");
Console.WriteLine($"Seno de X = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de X = {Math.Exp(x)}");

Console.ReadKey();