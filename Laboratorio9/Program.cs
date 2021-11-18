using System;
using System.Collections.Generic;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um");
            listaStrings.Add("Hello");
            listaStrings.Add("World!");
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.WriteLine(listaStrings[2]);
            //listaStrings.Add(10);

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".NET Framework / Core");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Inglaterra";
            paises[33] = "França";
            paises[55] = "Brasil";
            paises[598] = "Uruguai";
            paises[385] = "Croacia";
            Console.WriteLine($"O código 598 é {paises[598]}");
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine($"Código {codigo} = {pais}");
            }
            Console.WriteLine("Digite o nome do país: ");
            string nomePais = Console.ReadLine().ToLower();     //le a string toda em letra minuscula
            string busca = PrimeiraMaiuscula(nomePais);     //metodo para colocar o primeiro caractere em maiusculo
            foreach (KeyValuePair<int, string> item in paises)
            {
                if (item.Value.Contains(busca)) //retorna caso a busca seja string ou substring; é case sensitive então para retornar substring apenas pode ser do começo da palavra
                {
                    int codigo = item.Key;
                    string pais = item.Value;
                    Console.WriteLine($"Código {pais}: +{codigo}");
                }
            }

            List<double> listaReal = new List<double>() { 0.34, 12.22, 25.78, 3.56, 5.70, 2.45, 45.45, 8.76 };
            Console.WriteLine("A media da lista é {0}", MediaLista(listaReal));
            Console.WriteLine("O numero de elementos da lista acima da media é: {0}", TotalAcimaMedia(listaReal));
            List<double> listaAcimaMedia = new List<double>(ValorAcimaMedia(listaReal));
            Console.WriteLine("Elementos que estão acima da media: ");
            foreach (double item in listaAcimaMedia)
            {
                Console.WriteLine(item);
            }
        }

        private static List<double> ValorAcimaMedia(List<double> lista) // retorna uma lista com os elementos que estão acima da media
        {
            double mediaLista = MediaLista(lista);
            List<double> temp= new List<double>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > mediaLista)
                {
                    temp.Add(lista[i]);
                }
            }
            return temp;
        }
        private static int TotalAcimaMedia(List<double> lista) // retorna o numero de elementos que estão acima da media
        {
            int contagem = 0;
            double mediaLista = MediaLista(lista);
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > mediaLista)
                    contagem++;
            }
            return contagem;
        }

        private static double MediaLista(List<double> lista) //retorna a media aritmetica da lista
        {
            double total = 0.0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += lista[i];
            }
            double mediaLista = total / lista.Count;
            return mediaLista;
        }

        private static string PrimeiraMaiuscula(string txt) //retorna a string com a primeira letra maiuscula
        {
            char[] temp = txt.ToCharArray();
            temp[0] = Char.ToUpper(temp[0]);
            string res = new string(temp);
            return res;
        }

        
    }
}
