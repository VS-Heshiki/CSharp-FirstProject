using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Cliente conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Havera deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp =='S') {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new Cliente(numero, nome, depositoInicial);
            } else {
                conta = new Cliente(numero, nome);
            }
            
            Console.WriteLine();
            Console.WriteLine($"Dados da conta: {conta}");
            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine($"Dados atulizados: {conta}");

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine($"Dados atulizados: {conta}");


        }
    }
}