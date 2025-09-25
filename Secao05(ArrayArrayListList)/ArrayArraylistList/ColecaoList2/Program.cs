
// var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };
// lista.Add("Marta");
// lista.Insert(2, "Bia");
// System.Console.WriteLine(lista.Count + " itens");

// var lista = new List<string>() { "Maria", "Pedro", "Ana" };
// string[] array1 = { "Diná", "Carlos", "Pedro" };
// lista.AddRange(array1);
// lista.InsertRange(1, array1);
// System.Console.WriteLine(lista.Count + " itens");

// var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };
// lista.Remove(7);
// lista.RemoveAt(4);
// lista.RemoveRange(0, 2);
// System.Console.WriteLine(lista.Count + " itens");

// var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };
// //acessar um elemento da lista usando indice
// var primeiro = lista[0];
// var quarto = lista[3];
// System.Console.WriteLine(primeiro);
// System.Console.WriteLine(quarto);
// lista[0] = "Zé";
// lista[0] = "Silvia";
// System.Console.WriteLine(lista[0]);
// System.Console.WriteLine(lista[3]);

// var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };
// for (int i = 0; i < lista.Count; i++)
// {
//     System.Console.WriteLine(lista[i]);
// }

// var lista = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };
// foreach (var item in lista)
// {
//     System.Console.WriteLine(item);
// }

// var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé"};
// var res1 = lista.Contains("Ana");
// var res2 = lista.Contains("Zé");
// var res3 = lista.Contains("Ze");
// var res4 = lista.Contains("Mari");
// System.Console.WriteLine(lista.Contains("Pedro"));

var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé"};
ExibirLista(lista);
lista.Sort();
ExibirLista(lista);
lista.Clear();
System.Console.WriteLine(lista.Count + " itens");

Console.ReadKey();


static void ExibirLista(List<string> lista)
{
    System.Console.WriteLine();
    foreach (var item in lista)
    {
        System.Console.WriteLine(item);
    }
}