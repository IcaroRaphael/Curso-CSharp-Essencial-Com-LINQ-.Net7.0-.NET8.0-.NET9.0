Console.WriteLine("## Inferência Tipos ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} e ganha {salario:F2}");


////Var limitações
//var salario = null;
//var titulo;
//var salario, imposto, total;

////Não posso mudar o tipo após inicializar
//var num = 10;
//num = num + 20;
//num = "Teste"; //Não pode mudar o tipo

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}