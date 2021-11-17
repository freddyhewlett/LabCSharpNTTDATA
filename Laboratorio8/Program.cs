using System;
using System.Collections;

namespace Laboratorio8
{
    class Program
    {
        public class OrdenaIdade : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                Pessoa a = (Pessoa) x;
                Pessoa b = (Pessoa) y;
                return ((new CaseInsensitiveComparer()).Compare(a.Idade, b.Idade));
            }
        }
        static void Main(string[] args)
        {
            string[] lista = { "Gustavo", "Daniel", "Raphael", "Matheus", "Odin Megazord", "Leandro", "Jose"};
            Console.WriteLine("Array antes da ordenação:");
            string opcao = new string("nome");

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();

            Array.Sort(lista);

            Console.WriteLine("Array depois da ordenação: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();

            Pessoa[] lista2 = { new Pessoa("Jose", 25),
                                new Pessoa("Ana", 28),
                                new Pessoa("Paulo", 20),
                                new Pessoa("Camila", 18) };
                        
            Console.WriteLine("Preenchendo novo array...\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\nDeseja ordenar o novo array por idade? [S/N]");
            char ops = char.Parse(Console.ReadLine().ToUpper());
            if(ops == 'S')
            {
                for (int i = 0; i < lista2.Length; i++)
                {
                    lista2[i].OrdenaIdade(true);
                }
                opcao = "idade";
            }
            
            Array.Sort(lista2);

            Console.WriteLine("Array ordenado por {0}: ", opcao);
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.WriteLine("{0}, {1} anos", lista2[i].Nome, lista2[i].Idade);
            }

            for (int i = 0; i < lista2.Length; i++)
                {
                    lista2[i].OrdenaIdade(false);
                }
            
            Array.Sort(lista2);
            opcao = "nome";
            Console.WriteLine("\nResetando ordenação...\nMudando para IComparer...");
            Console.Write("\nDeseja ordenar array por idade? [S/N]");
            ops = char.Parse(Console.ReadLine().ToUpper());
            if(ops == 'S')
            {
                Array.Sort(lista2, new OrdenaIdade());
                opcao = "idade";
            }

            Console.WriteLine("Array ordenado por {0}: ", opcao);
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.WriteLine("{0}, {1} anos", lista2[i].Nome, lista2[i].Idade);
            }

            
        }
    }
}
