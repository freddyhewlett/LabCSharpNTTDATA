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
            conta1.CobrancaServico();       //faz a cobrança dos serviços da conta corrente
            conta1.AdicionarRendimento();   //adiciona rendimento mensal
            Console.WriteLine(conta1);      //imprime as informações da conta de acordo com o override do metodo ToString()

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
            conta3.AdicionarRendimento();       //faz a adição do rendimento anual 
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

            List<Conta> contas = new List<Conta> { conta1, conta2, conta3, conta4 };    //esta coleção de objetos simples é do tipo conta 
            foreach (Conta conta in contas)                                             //e lista os objetos dos tipos ContaCorrente e ContaPoupanca.
            {                                                                           //O proprio objeto de lista apenas pode acessar metodos da sua classe Lista,
                Console.WriteLine(conta + "\n");                                        // mas os objetos da coleção podem acessar metodos das suas classes e da classe 
            }                                                                           //abstrata Conta
        }
    }
}
