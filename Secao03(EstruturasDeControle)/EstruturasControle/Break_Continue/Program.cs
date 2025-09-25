Console.WriteLine("## Break e Continue");

//for(; ; )
//{
//    Console.Write("Tecle algo (X sai): ");
//    var opcao = Console.ReadLine();
//    Console.WriteLine(opcao.ToUpper());
//    if(opcao == "X" || opcao == "x")
//    {
//        break;
//    }
//}

//for(int i = 1; i <= 10; i++)
//{
//    if(i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

int n = 1;
while (n <= 10)
{
    if (n == 5)
    {
        n++;
        continue;
    }

    if (n > 8)
    {
        break;
    }

    Console.WriteLine(n);
    n++;
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
