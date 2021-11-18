using System;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int ops = new int();

            Console.Write("Novo termometro: \nDigite o valor do limite de temperatura: ");
            double limite = double.Parse(Console.ReadLine());
            TermometroLimite term = new TermometroLimite(limite);
            term.LimiteSuperiorEvent += new TermometroLimite.DelegateLimite(TrataLimite);
            term.AbaixoLimiteEvent += new TermometroLimite.DelegateLimite(TrataLimite);

            while (ops != 3)
            {
                Console.Write("\nDeseja aumentar ou diminuir a temperatura?\n1- Aumentar\n2- Diminuir\n3- Sair\n");
                ops = int.Parse(Console.ReadLine());
                switch (ops)
                {
                    case 1:
                        if (term.Temperatura > limite)
                        {
                            Console.WriteLine("Temperatura acima do limite. Não é possivel aumentar mais.");
                        }
                        else
                        {
                            Console.Write("\nDigite o valor para aumentar a temperatura: ");                        
                            term.Aumentar(double.Parse(Console.ReadLine()));
                        }
                        break;
                    case 2:
                        Console.Write("\nDigite o valor para diminuir a temperatura: ");                        
                        term.Diminuir(double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Obrigado por participar!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida...");
                        break;
                }
            }
                        
        }

        private static void TrataLimite(string msg, double temp)
        {
            Console.WriteLine(msg + temp);
        }
    }
}
