using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Laboratório 3: ");
            Console.WriteLine(" ");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }

            Console.WriteLine(" ");
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            Console.WriteLine(" ");
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToLongDateString()); //alterado para teste
            }

            Console.WriteLine(" ");
            Console.WriteLine("Passo 8: ");
            i = 0;
            foreach (int j in array)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + j);
                i++;
            }
            Console.WriteLine(" ");
            iStr = 0;
            foreach (string j in str)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + j);
                iStr++;
            }
            Console.WriteLine(" ");
            iDate = 0;
            foreach (DateTime j in dt)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + j.ToShortDateString());
                iDate++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Exercicios Laboratório 3: ");
            Console.WriteLine(" ");
            Console.WriteLine("Questão 1: ");
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            Console.WriteLine("Populando primeiro array...");
            for (i = 0; i < 100; i++)
            {
                arr1[i] = i + 1;        // populando o primeiro array
            }
            Console.WriteLine("Primeiro array preenchido com sucesso!");
            Console.WriteLine("Copiando elementos do primeiro array para o segundo...");
            for (i = 0; i < 100; i++)
            {
                arr2[i] = arr1[i];      // copiando do primeiro para o segundo array
            }
            Console.WriteLine("Copia de elementos concluida com sucesso!");
            int ops;
            do
            {
                Console.WriteLine("Deseja exibir os arrays? (digite o numero do menu abaixo)");
                Console.WriteLine("1- Primeiro array");
                Console.WriteLine("2- Segundo array");
                Console.WriteLine("3- Não exibir");
                ops = int.Parse(Console.ReadLine());
                switch (ops)
                {
                    case 1:
                        foreach (int j in arr1)
                        {
                            Console.WriteLine(j);
                        }
                        break;
                    case 2:
                        foreach (int j in arr2)
                        {
                            Console.WriteLine(j);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Proxima questão...");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
            while (ops != 3);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 2: ");
            int[,] mat = new int[5, 5];
            int[] vet = new int[5];
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat[i, j] = j + 1;
                }
            }
            for (i = 0; i < 5; i++)
            {
                int soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    soma += mat[i, j];
                }
                vet[i] = soma;
            }
            foreach (int j in vet)
            {
                Console.WriteLine(j);
            }
            int[][] matJag = new int[5][];
            for (i = 0; i < 5; i++)
            {
                matJag[i] = new int[5];
            }
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matJag[i][j] = j + 1;
                }
            }
            for (i = 0; i < 5; i++)
            {
                int soma = 0;
                for (int j = 0; j < 5; j++)
                {
                    soma += matJag[i][j];
                }
                vet[i] = soma;
            }
            foreach (int j in vet)
            {
                Console.WriteLine(j);
            }
        }
    }
}
