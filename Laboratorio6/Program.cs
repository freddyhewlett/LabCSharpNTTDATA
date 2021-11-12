using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("************************* Frederas Bank *************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Seja bem-vindo!");

            Console.WriteLine(" ");
            Console.WriteLine("Questão 1: ");
            Console.WriteLine("Primeira conta corrente: ");
            ContaCorrente conta1 = new ContaCorrente((decimal)2.60, (decimal)0.67, DateTime.Now, "Steve Jobs");
            conta1.Depositar(50000);
            conta1.Sacar(25000);
            conta1.CobrancaServico();
            conta1.AdicionarRendimento();
            Console.WriteLine(conta1);

            Console.WriteLine(" ");
            Console.WriteLine("Segunda conta corrente: ");
            ContaCorrente conta2 = new ContaCorrente((decimal)2.60, (decimal)0.67, DateTime.Now, "Johnny Cash");
            conta2.Depositar(100000);
            conta2.Sacar(60000);
            conta2.CobrancaServico();
            conta2.AdicionarRendimento();
            Console.WriteLine(conta2);
            Console.WriteLine(" ");

            Console.WriteLine("Primeira conta poupança: ");
            ContaPoupanca conta3 = new ContaPoupanca((decimal)4.38, DateTime.Now, "Jimmy Hendrix");
            conta3.Depositar(200000);
            conta3.Sacar(10000);
            conta3.AdicionarRendimento();
            Console.WriteLine(conta3);
            Console.WriteLine(" ");

            Console.WriteLine("Segunda conta poupança: ");
            ContaPoupanca conta4 = new ContaPoupanca((decimal)4.38, DateTime.Now, "Phil Lynott");
            conta4.Depositar(500000);
            conta4.Sacar(200000);
            conta4.AdicionarRendimento();
            Console.WriteLine(conta4);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 2: ");

            List<Conta> contas = new List<Conta> { conta1, conta2, conta3, conta4 };
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta + "\n");
            }
        }
    }
}
