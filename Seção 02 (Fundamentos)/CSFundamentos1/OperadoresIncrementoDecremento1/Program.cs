Console.WriteLine("## Operadores Incremento e Decremento ##\n");

Console.WriteLine("INCREMENTO");

//Pós-incremento -> primeiro resolve depois incrementa
int x = 0;
Console.WriteLine($"x = {x}");

int resultado1 = x++ + 10;

Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

//Pré-incremento -> primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");

int resultado2 = ++y + 10;

Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}\n");


Console.WriteLine("DECREMENTO");

//Pós-dincremento -> primeiro resolve depois decrementa
int z = 0;
Console.WriteLine($"z = {z}");

int resultado3 = z-- + 10;

Console.WriteLine($"pós-incremento ==> {resultado3}");
Console.WriteLine($"valor de z ==> {z}\n");

//Pré-dincremento -> primeiro decrementa depois resolve
int k = 0;
Console.WriteLine($"k = {k}");

int resultado4 = --k + 10;

Console.WriteLine($"pré-incremento ==> {resultado4}");
Console.WriteLine($"valor de k ==> {k}\n");

Console.ReadKey();
