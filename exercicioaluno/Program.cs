namespace exercicioalunos;
class Program
{
    static void Main(string[] args)
    {
        exercicioaluno.Alunos aluno1 = new exercicioaluno.Alunos();
        //nome
        Console.WriteLine("digite seu nome: ");
        aluno1.nome = Console.ReadLine();

        //nota1 
        Console.WriteLine("digite sua primeira nota: ");
        aluno1.nota1 = double.Parse(Console.ReadLine());

         //nota2
        Console.WriteLine("digite sua segunda nota: ");
        aluno1.nota2 = double.Parse(Console.ReadLine());


        //mensagem
        aluno1.mensagem();

    }
}