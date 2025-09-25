using System.Net.Http.Headers;

Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");

//Extrair informações da data atual
//Console.writeline(hoje.year);
//Console.writeline(hoje.month);
//Console.writeline(hoje.day);
//Console.writeline(hoje.hour);
//Console.writeline(hoje.minute);
//Console.writeline(hoje.second);
//Console.writeline(hoje.millisecond);

//Adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

//Obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToShortTimeString());
Console.WriteLine(hoje.ToLongTimeString());

Console.ReadKey();
