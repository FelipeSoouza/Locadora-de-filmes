using System;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do filme: ");
            string nomeFilme = Console.ReadLine();

            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            DateTime dataRetirada = DateTime.Now;
            DateTime dataEntregue = dataRetirada.AddDays(7);

            Console.WriteLine("O filme" + nomeFilme + " foi retirado por " + nomeCliente + " em" + dataRetirada.ToString() + " e deve ser entregue até " + dataEntregue.ToString() + ".");
        }
    }
}
