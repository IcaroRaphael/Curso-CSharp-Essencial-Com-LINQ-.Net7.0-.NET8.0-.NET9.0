bool stop = true;
while (stop)
{
    Console.Clear();
    Console.Write("Insira uma nota (-1 para sair): ");
    int nota = int.Parse(Console.ReadLine());

    switch (nota)
    {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("F");
            break;
        case -1:
            Console.WriteLine("Saindo...");
            stop = false;
            break;
        default:
            Console.WriteLine("Nota inválida");
            break;

    }
    Console.ReadKey();
}
