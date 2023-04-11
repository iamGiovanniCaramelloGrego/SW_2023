namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("!AGREGAÇÃO!");
        
        //instanciando os objetos de cada classe
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //add nome ao cliente
        cli.Nome = "Robertinho Ponta Esquerda";

        //Add número e validade ao Cartão de Credito!
        cdc.Numero = "7071";
        cdc.DataValidade = "15/2026";

        //associar o cliente ao atributo de agregação na Cartão de Credito
        cdc.Cliente = cli;

        //informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);

    }
}