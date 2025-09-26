
namespace ExercicioHeranca;

public class ContaPoupanca : Conta
{
    public override double Juros { get; set; } = 0.005;

    public override decimal Sacar(decimal valor)
    {
        if(Saldo >= valor)
        {
            return base.Sacar(valor);
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente...");
            return Saldo;
        }
    }
}
