Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores inválidos
//int 5idade;
//int $valor;
//int valor#total;
//String nome completo;

//Para nome de variáveis : Camel Case
string descontoTotal;
string desconto_Total;

//Constantes : Maiúsculas
double PI = 3.14;
String PREFIXO = "11";
string PREFIXO_SP = "11";

Console.ReadLine();

//Para nome de classes e métodos : Pascal Case
class ImprimirTexto
{
    public void ImprimirNome()
    {
        Console.WriteLine("Macoratti");
    }
}
