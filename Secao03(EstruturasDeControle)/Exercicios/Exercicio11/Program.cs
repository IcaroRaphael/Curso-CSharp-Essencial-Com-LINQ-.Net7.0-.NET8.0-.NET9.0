Console.Write("Informe o primeiro número: ");
double num1 = int.Parse(Console.ReadLine());

Console.Write("Informe o operador (+,-,/,*): ");
string operador = Console.ReadLine();

switch (operador)
{
    case "+":
        Console.Write("Informe o segundo número: ");
        double num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {num1 + num2}");
        break;
    case "-":
        Console.Write("Informe o segundo número: ");
        double num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {num1 - num3}");
        break;
    case "*":
        Console.Write("Informe o segundo número: ");
        double num4 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {num1 * num4}");
        break;
    case "/":
        Console.Write("Informe o segundo número: ");
        double num5 = int.Parse(Console.ReadLine());
        if (num5 != 0)
        {
            Console.WriteLine($"Resultado: {num1 / num5}");
        }
        else
        {
            Console.WriteLine("Divisão por zero não é permitida.");
        }
        break;
    default:
        Console.WriteLine("Operador inválido.");
        break;
}