namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("godofredo",18);
        //p1.AlteraNome("GIOVANNI");
        //p1.AlteraSobreNome("CARAMELLO");
        //p1.AlteraIdade(16);
        p1.MostraDados();
    }
}
