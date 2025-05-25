using System.Collections;

// var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };
// //Verificar se um elemento existe na coleção
// var res1 = lista.Contains(5); //true
// bool res2 = lista.Contains("Mari"); //false
// Console.WriteLine(res1);
// Console.WriteLine(res2);
// Console.WriteLine(lista.Contains(null)); //true

var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };
lista.Sort();
foreach (var item in lista)
{
    System.Console.WriteLine(item);
}

lista.Clear();
System.Console.WriteLine("Número de elementos do Array depois do clear: " + lista.Count);

Console.ReadKey();
