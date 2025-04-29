class Program
{
    static void Main(string[] args)
    {
        //Declaração do Array
        int[] numeros;
        //Alocar memoria
        numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
        string[] nomes = {"Ana", "Maria", "Marta", "Paulo", "Carlos"};
        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);
        Console.WriteLine(nomes[3]);
        Console.WriteLine(nomes[4]);


        //Declarando um array
        int[] numeros1;
        //Alocar memoria
        numeros1 = new int[3];

        numeros1[0] = 1;
        numeros1[1] = 2;
        numeros1[2] = 3;

        Console.ReadKey();
    }
}