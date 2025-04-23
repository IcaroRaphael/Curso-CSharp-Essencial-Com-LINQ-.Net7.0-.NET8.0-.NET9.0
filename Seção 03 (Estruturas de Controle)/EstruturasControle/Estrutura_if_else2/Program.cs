Console.WriteLine("## Instrução if-else ##\n");

// Console.Write("Informe a nota do aluno: ");
// var nota = Convert.ToInt32(Console.ReadLine());
// if(nota > 5){
//     Console.WriteLine("Aluno Aprovado");
// }
// else{
//     Console.WriteLine("Aluno Reprovado");
// }

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y){
    Console.WriteLine("x é maior que y");
}
else{
    if(x < y){
        Console.WriteLine("x é menor que y");
    }
    else{
        Console.WriteLine("x é igual a y");
    }
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();
