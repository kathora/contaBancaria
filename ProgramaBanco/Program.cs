using System;
using System.Globalization;

namespace ProgramaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = (Console.ReadLine());
            Console.Write("Haverá depósito inicial S/N: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's'|| resp == 'S')
            {
                Console.WriteLine("Escreva o valor inicial");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor de depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor de despesa: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);
        }
    }
}
