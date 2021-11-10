using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor máximo de byte: " + b);
            b = byte.MinValue;
            Console.WriteLine("Valor minimo de byte: " + b);
            int i;
            i = int.MaxValue;
            Console.WriteLine("Valor máximo de int: " + i);
            i = int.MinValue;
            Console.WriteLine("Valor minimo de int: " + i);
            long l;
            l = long.MaxValue;
            Console.WriteLine("Valor máximo de long: " + l);
            l = long.MinValue;
            Console.WriteLine("Valor minimo de long: " + l);

            Console.WriteLine(" ");
            string strPrimeira = "Alô ";
            string strSegunda = "Mundo!";
            string strTerceira = strPrimeira + strSegunda;
            Console.WriteLine(strTerceira);
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine("Substring da posição 0 contando 5 posições: " + strTerceira.Substring(0, 5));

            Console.WriteLine(" ");
            DateTime dt = new DateTime(2021, 11, 08); // Parametros: Ano, mes, dia
            string strQuinta = dt.ToString();
            Console.WriteLine(strQuinta); // Alternativa: Console.WriteLine(dt.ToString());

            Console.WriteLine(" ");
            Console.WriteLine("Questão 1: ");
            float f;
            f = float.MaxValue;
            Console.WriteLine("Valor máximo de float: " + f);
            f = float.MinValue;
            Console.WriteLine("Valor minimo de float: " + f);
            double d;
            d = double.MaxValue;
            Console.WriteLine("Valor máximo de double: " + d);
            d = double.MinValue;
            Console.WriteLine("Valor minimo de double: " + d);
            decimal dec;
            dec = decimal.MaxValue;
            Console.WriteLine("Valor máximo de decimal: " + dec);
            dec = decimal.MinValue;
            Console.WriteLine("Valor minimo de decimal: " + dec);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 2: ");
            strTerceira = strSegunda.Insert(0, strPrimeira.Insert(0, "Mais um "));  // insert
            Console.WriteLine(strTerceira);
            string strMaiuscula = strTerceira.ToUpper();                            //ToUpper
            string strMinuscula = strTerceira.ToLower();                            //ToLower
            Console.WriteLine(strMaiuscula);
            Console.WriteLine(strMinuscula);
            string strRemove = strTerceira.Remove(0, 8);                            //Remove com 2 parametros
            Console.WriteLine(strRemove);
            strTerceira = strTerceira.Remove(8);                                    //Remove com um parametro
            Console.WriteLine(strTerceira);
            strTerceira = string.Concat("Mais um ", strRemove);                     //Concat
            Console.WriteLine(strTerceira);
            Console.WriteLine(string.Concat(strMaiuscula, "\n", strMinuscula));

            Console.WriteLine(" ");
            Console.WriteLine("Questão 3: ");
            string diaSemana = dt.DayOfWeek.ToString();                             //DayOfWeek
            Console.WriteLine(diaSemana);
            DateTime dt2 = DateTime.Now;                                            //Now
            Console.WriteLine(dt2);
            Console.WriteLine(DateTime.Now);
            int dias = DateTime.DaysInMonth(1992, 2);                               //DaysInMonth - Utilizado fevereiro de ano bissexto
            Console.WriteLine(dias);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 4: ");
            i = 10;
            f = 0;
            f = i; //conversão implícita, sem perda de dados.
            Console.WriteLine(f);
            f = 0.5F;
            i = (int)f; //conversão explícita, com perda de dados.
            Console.WriteLine(i);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 5: ");
            string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);                //de string para inteiro
            Console.WriteLine(valorStringInteiro);
            long valorInt64 = 123456789;                                            //int64 = long
            int valorInt = Convert.ToInt32(valorInt64);                             //de long para inteiro
            Console.WriteLine(valorInt);

            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande); ---------> conversão fracassada devido ao tamanho suportado pelo int

            Console.WriteLine(" ");
            Console.WriteLine("Questão 6: ");
            stringInteiro = "123456789";
            //int valorStringInteiro; --------> variavel já criada
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro); //parametros: entrada string, saida int. Retorno: verdadeiro/falso
            Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);
            stringInteiroGrande = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
            Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande);
            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras); //conversão fracassada devido ao valor do parametro de entrada
            Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);
            // teste tryparse
            string strInteiroTeste = "254";
            byte testeByte;
            conversao1 = byte.TryParse(strInteiroTeste, out testeByte);
            if (conversao1 == true)
            {
                Console.WriteLine("Teste sucedido: {0}", testeByte);
            }
            else
            {
                Console.WriteLine("Não deu!");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Questão 7: ");
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;                               // conversão explicita ignora a parte fracionaria e recebe apenas o valor do inteiro
            int valorInteiro2 = Convert.ToInt32(valorFracionado);                   // conversão metodo Convert arredonda o numero.
            Console.WriteLine("Conversao explicita = " + valorInteiro1);            // Por padrão: de n,1 ate n,5 o arredondamento é para o menor numero (n).
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);       // De n,6 a n,9 o arredondamento é para o maior numero (n).

            Console.WriteLine(" ");
            Console.WriteLine("Questão 8: ");
            int x = 10;
            double y = 3.4;
            Console.WriteLine("{0} {1}", x, y);
            Console.WriteLine(x + " " + y);
            Console.WriteLine($"{x} {y}");

        }
    }
}
