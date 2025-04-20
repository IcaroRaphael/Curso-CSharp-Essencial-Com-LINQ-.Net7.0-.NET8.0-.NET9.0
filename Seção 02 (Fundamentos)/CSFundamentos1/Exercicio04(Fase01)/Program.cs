// Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.

//DateTime hoje = new DateTime(1999, 9, 4);
//Console.WriteLine(hoje);


Console.Write("Insira a data no formato dd/mm/yyyy: ");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.WriteLine(data);
