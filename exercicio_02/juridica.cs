public class ContratoPessoaJuridica : Contrato
{
    public string CNPJ { get; set; }
    public string InscricaoEstadual { get; set; }

    public ContratoPessoaJuridica(int numero, decimal valor, string cnpj, string inscricaoEstadual)
        : base(numero, valor)
    {
        CNPJ = cnpj;
        InscricaoEstadual = inscricaoEstadual;
    }
}
