namespace emprestimo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Daora");
        Banco b = new Banco();
        //c.Saldo = 1000;
        b.Depositar(1000);
        b.Sacar(1600);
        b.AjustarLimite(500);

        double valortotal = b.MostrarSaldo();

        

        Console.WriteLine("seu saldo total é de " + valortotal);

        b.imprimi(b.emprestimo(12,1000));
    }
}

