namespace ex_aviao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("AVIÃO POO");
        Aviao aviao1 = new Aviao();
        
        aviao1.modelo = "malaysia 3030";
        aviao1.marca = "branco";
        
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
        aviao1.acelerar();
        aviao1.exibir();
    }
}
