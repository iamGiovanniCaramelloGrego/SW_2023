namespace emprestimo;
class Banco
{
   //Funções inicias do banco

    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }
    public void Depositar( double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("você esta sacando mais do que você tem");
        }else{
             this.Saldo -= valor;
        }
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }

    // empréstimo

    public double parcela {get; set;}
    public double valor {get; set;}

    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;
        
        double div = dinheiro/parcelas;
        double mult = dinheiro * 0.06;
        double soma = mult + div;
        double total = soma *parcelas;

        string resultado = "valor da parcela sem juros é: "+ div +". valor da parcela com juros: "+ mult + ". valor do juros com prestações é de: "+ soma +"e o valor total é de: "+total;
        return resultado;
        
     
    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    } 
}
    
