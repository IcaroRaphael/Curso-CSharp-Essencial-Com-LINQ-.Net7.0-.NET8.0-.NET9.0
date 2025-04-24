Console.WriteLine("## Estrutura Switch-Case ##\n");

// double compra = 600.00;
// Console.WriteLine($"Valor da compra R${compra:f2}");
// Console.Write("Informe o numero de parcelas (1 a 3): ");
// var numeroParcelas = Convert.ToInt32(Console.ReadLine());
// switch(numeroParcelas)
// {
//     case 1:
//         Console.WriteLine($"Prestação R${compra/numeroParcelas}");
//         break;
//     case 2:
//         Console.WriteLine($"Prestação R${compra/numeroParcelas}");
//         break;
//     case 3:
//         Console.WriteLine($"Prestação R${compra/numeroParcelas}");
//         break;
//     default:
//         Console.WriteLine("Valor inválido. Informe 1, 2 ou 3.");
//         break;
// }
// Console.WriteLine("Fim de processamento...");

Console.Write("Informe o numero inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine($"O número é {numero} PAR");
        break;
    case 1:
        Console.WriteLine($"O número {numero} é IMPAR");
        break;
}
Console.WriteLine("Fim do processamento...");

Console.ReadKey();