namespace exercicio_01;
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        homem homem= new homem();
        cao cao= new cao();
        gato gato= new gato();


        Console.WriteLine(" O homem fala: " + homem.Fala());
        Console.WriteLine("o cão latiu: " + cao.Fala());
        Console.WriteLine("o gato miou: " + gato.Fala());

    }
}
