namespace exercicio_02;
class Program
{
    static void Main(string[] args)
    {
       ContratoPessoaFisica contratoPF = new ContratoPessoaFisica(1, 1000.0m, "123.456.789-00", 30);
        ContratoPessoaJuridica contratoPJ = new ContratoPessoaJuridica(2, 5000.0m, "12.345.678/0001-90", "123456789");

        Console.WriteLine("Contrato Pessoa Física: Giovanni");
        Console.WriteLine("Número: " + contratoPF.Numero);
        Console.WriteLine("CPF: " + contratoPF.CPF);
        Console.WriteLine("Idade: " + contratoPF.Idade);

        Console.WriteLine();
        Console.WriteLine("Contrato Pessoa Jurídica: Giovanni");
        Console.WriteLine("Número: " + contratoPJ.Numero);
        Console.WriteLine("CNPJ: " + contratoPJ.CNPJ);
        Console.WriteLine("Inscrição: " + contratoPJ.InscricaoEstadual);
    }
}
