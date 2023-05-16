public class ContratoPessoaFisica : Contrato
{
    public string CPF { get; set; }
    public int Idade { get; set; }

    public ContratoPessoaFisica(int numero, decimal valor, string cpf, int idade)
        : base(numero,valor)
    {
        CPF = cpf;
        Idade = idade;
    }
}