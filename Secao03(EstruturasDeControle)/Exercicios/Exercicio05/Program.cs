while (true)
{
    Console.Clear();
    Console.WriteLine("Qual a instrução para sair de um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");
    Console.Write("Qual a opção correta (Tecle X para sair)? R:");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "a":
            Console.WriteLine("ERRADO: Instrução 'quit' não existe.");
            Console.ReadKey();
            break;
        case "b":
            Console.WriteLine("ERRADO: Instrução 'continue' não sai do loop.");
            Console.ReadKey();
            break;
        case "c":
            Console.WriteLine("CORRETO: Instrução 'break' sai do loop.");
            Console.ReadKey();
            break;
        case "d":
            Console.WriteLine("ERRADO: Instrução 'exit' não existe.");
            Console.ReadKey();
            break;
        case "X":
        case "x":
            Console.WriteLine("Saindo do programa...");
            Console.ReadKey();
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }
}
