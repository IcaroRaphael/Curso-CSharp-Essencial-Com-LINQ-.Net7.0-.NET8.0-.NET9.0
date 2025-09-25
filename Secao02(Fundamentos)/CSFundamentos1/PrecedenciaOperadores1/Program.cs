Console.WriteLine("## Precedência de operadores ##\n");

//int x = (10 - 2) * 3;
//Console.WriteLine(x); //Resultado: 24
//int y = 10 - 2 * 3;
//Console.WriteLine(y); //Resultado: 4

//bool a = !(9 != 8) && 5 >= 7 || 8 >= 6;
//Console.WriteLine(a);
//bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
//Console.WriteLine(b);

int a = 5, b = 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);

Console.ReadKey();
