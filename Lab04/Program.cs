using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ops;
            Console.Write("Digite o nome do novo correntista: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o saldo inicial: ");
            decimal saldoInit = decimal.Parse(Console.ReadLine());
            ContaCorrente minhaConta = new ContaCorrente(saldoInit, nome);
            do
            {
                Console.WriteLine("Selecione a opção do menu abaixo: ");
                Console.WriteLine("1- Deposito");
                Console.WriteLine("2- Saque");
                Console.WriteLine("3- Sair");
                ops = int.Parse(Console.ReadLine());
                decimal ops2;
                switch (ops)
                {
                    case 1:
                        Console.Write("Digite o valor do deposito: ");
                        ops2 = int.Parse(Console.ReadLine());
                        minhaConta.Depositar(ops2);
                        minhaConta.RegistraMovim();
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        ops2 = int.Parse(Console.ReadLine());
                        minhaConta.Sacar(ops2);
                        minhaConta.RegistraMovim();
                        break;
                    case 3:
                        Console.WriteLine("Ultima movimentação realizada em : " + minhaConta.DataMoviment);
                        minhaConta.SaldoMedio();
                        Console.WriteLine("Saldo medio com base no saldo atual e numero de movimentações: " + minhaConta.AcessSaldoMed);
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida.");
                        break;
                }
            }
            while (ops != 3);
        }
    }
}
