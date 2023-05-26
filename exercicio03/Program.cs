namespace exercicio03;
class Program
{
    static void Main(string[] args)
    {
        

        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Vitu";
        cf.Email = "honestidade123@gmail.com";
        cf.Telefone = "(11)69696-9696";
        cf.Idade = 201;
        cf.Cpf = 458729525-07;
        cj.Nome = "Alessandro";
        cj.Email = "mendigomalicia01@gmail.com";
        cj.Telefone = "(11)75757-5757";
        cj.Cnpj = 00000000000000;
        cj.Inscricao = 888888888888;
        cj.Prazo = 10;
        cf.Prazo = 10;

        Console.WriteLine(cf.MostraDados());
         Console.WriteLine(cf.CalcularPrestacao());
        Console.WriteLine(cj.MostraDados());
         Console.WriteLine(cj.CalcularPrestacao());
       
        
    }
} 

