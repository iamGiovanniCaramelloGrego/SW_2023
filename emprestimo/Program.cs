namespace emprestimo;
class Program
{
        static void Main(string[] args)
        {
            var loanAmount = 1000;
            var interest = 6;
            var numberOfYears = 1;

            
            var rateOfInterest = interest / 1200;
            var numberOfPayments = numberOfYears * 12;

            // loan amount = (interest rate * loan amount) / (1 - (1 + interest rate)^(number of payments * -1))
            var paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

            Console.WriteLine(paymentAmount);
        }
    }
