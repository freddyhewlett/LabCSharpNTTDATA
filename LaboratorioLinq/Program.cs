using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
   internal class Program
   {
      static void Main(string[] args)
      {
         List<Pessoa> pessoas = new List<Pessoa>()
         {
            new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), EstadoCivil=EstadoCivil.Casado},
            new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,23), EstadoCivil=EstadoCivil.Viuvo},
            new Pessoa{Nome="Ana Maria", DataNascimento=new DateTime(1980,3,14), EstadoCivil=EstadoCivil.Solteiro},
            new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), EstadoCivil=EstadoCivil.Casado},
            new Pessoa{Nome="Pedro", DataNascimento=new DateTime(1970,5,27), EstadoCivil=EstadoCivil.Solteiro},
            new Pessoa{Nome="Huginho", DataNascimento=new DateTime(1970,5,27), EstadoCivil=EstadoCivil.Divorciado},
            new Pessoa{Nome="Zezinho", DataNascimento=new DateTime(1980,3,17), EstadoCivil=EstadoCivil.Divorciado},
            new Pessoa{Nome="Luizinho", DataNascimento=new DateTime(1990,7,7), EstadoCivil=EstadoCivil.Viuvo}
         };

         //Consulta tradiconal
         List<Pessoa> resultado1 = new List<Pessoa>();
         foreach (Pessoa p in pessoas)
         {
            if (p.EstadoCivil == EstadoCivil.Casado)
               resultado1.Add(p);
         }
         Console.WriteLine("Pessoas casadas, consulta tradiconal:");

         foreach (Pessoa p in resultado1)
         {
            Console.WriteLine(p.Nome);
         }

         //Consulta LINQ
         var resultado2 = from p in pessoas
                          where p.EstadoCivil == EstadoCivil.Casado
                          select p;
         Console.WriteLine("\nPessoas casadas, consulta linq:");

         foreach (Pessoa p in resultado2)
         {
            Console.WriteLine(p.Nome);
         }

         Console.WriteLine("\nPessoas casadas, consulta linq (method syntax):");
         var resultado3 = pessoas.Where(p => p.EstadoCivil == EstadoCivil.Casado);

         foreach (Pessoa p in resultado3)
         {
            Console.WriteLine(p.Nome);
         }

         // para obter uma "lista" a partir da consulta linq
         var resultado4 = (from p in pessoas
                           where p.EstadoCivil == EstadoCivil.Casado
                           select p).ToList();


         Console.WriteLine("\nPessoas casadas que nasceram após 01/01/1980");
         var resultado5 = (from p in pessoas
                           where p.EstadoCivil == EstadoCivil.Casado && p.DataNascimento >= new DateTime(1980, 1, 1)
                           select p).ToList();

         // ups! forçando um pouco a barra...
         resultado5.ForEach(p => Console.WriteLine(p));

         Console.WriteLine("\nProjeção sobre o nome das pessoas casadas");
         var resultado6 = from p in pessoas
                          where p.EstadoCivil == EstadoCivil.Casado
                          select p.Nome;

         foreach (String s in resultado6)
         {
            Console.WriteLine(s);
         }

         Console.WriteLine("\nSolteiros em uma lista de objetos anonimos..");
         var resultado7 = (from p in pessoas
                           where p.EstadoCivil == EstadoCivil.Solteiro
                           select new { p.Nome, p.DataNascimento }).ToList();

         foreach (var elem in resultado7)
         {
            Console.WriteLine(elem.Nome + " " + elem.DataNascimento);
         }

         Console.WriteLine("\nPessoas agrupadas pelo estado civil");
         var resultado8 = from p in pessoas
                          group p by p.EstadoCivil == EstadoCivil.Casado;

         foreach (var g in resultado8)
         {
            Console.WriteLine($"casado:{g.Key}");
            foreach (var p in g)
            {
               Console.WriteLine(p);
            }
         }

         Console.WriteLine("\nPessoa mais nova");
         var resultado9 = pessoas.Max(p => p.DataNascimento); //alterado de Min para Max pois estava apresentando a pessoa mais velha

         var resultado10 = (from p in pessoas
                            where p.DataNascimento == resultado9
                            select p.Nome).ToList();

         resultado10.ForEach(x => Console.WriteLine(x));

         Console.WriteLine("\nGrupo de pessoas por mes de nascimento");
         var resultado11 = (from p in pessoas
                           orderby p.DataNascimento.Day ascending
                           orderby p.DataNascimento.Month ascending
                           group p by p.DataNascimento.Month);

         foreach (var m in resultado11)
         {
            Console.WriteLine($"Mes:{m.Key}");
            foreach (var d in m)
            {
               Console.WriteLine(d);
            }
         }

         Console.WriteLine("\nPessoa(s) mais velha(s)");
         var resultado12 = pessoas.Min(p => p.DataNascimento); //utilizado mesmo codigo que a consulta da pessoa mais nova

         var resultado13 = (from p in pessoas
                            where p.DataNascimento == resultado12
                            select p.Nome).ToList();

         resultado13.ForEach(x => Console.WriteLine(x));

         Console.WriteLine("\nPessoa mais nova solteira");
         // var resultado14 = (from p in pessoas                  
         //                   orderby p.DataNascimento ascending
         //                   group p by p.Casada).ToList();

         var resultado14 = pessoas.OrderByDescending(p => p.DataNascimento).Where(s => s.EstadoCivil == EstadoCivil.Solteiro).FirstOrDefault();

         //var resultado15 = pessoas.Where(s => s.EstadoCivil == EstadoCivil.Solteiro).OrderByDescending(p => p.DataNascimento).FirstOrDefault();

         //Console.WriteLine(resultado15);

         // var resultado15 = resultado14.FirstOrDefault();
         // var resultado16 = resultado15.Max(p => p.DataNascimento);
         // var resultado17 = (from p in pessoas
         //                   where p.DataNascimento == resultado16 && !p.Casada
         //                   select p.Nome).ToList();

         // resultado17.ForEach(x => Console.WriteLine(x));

         Console.WriteLine(resultado14.Nome);

         Console.WriteLine("\nMedia de idade das pessoas");
         var resultado18 = (from p in pessoas
                           select p.DataNascimento.Year).ToList();
         for (int i = 0; i < resultado18.Count; i++)
         {
            resultado18[i] = 2021 - resultado18[i];
         }
         //resultado18.ForEach(x => Console.WriteLine(x));
         double media = 0.0;
         foreach (int ano in resultado18)
         {
             media += ano;
         }
         media /= resultado18.Count;
         
         Console.WriteLine(media);
      }
   }
}
