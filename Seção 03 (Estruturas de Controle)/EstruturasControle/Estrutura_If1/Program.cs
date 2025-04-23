Console.WriteLine("## Instrução if ##");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y){
    Console.WriteLine("x é maior que y");
}
if(x < y){
    Console.WriteLine("x é menor que y");
}
if(x == y){
    Console.WriteLine("x é igual a y");
}

Console.ReadKey();
