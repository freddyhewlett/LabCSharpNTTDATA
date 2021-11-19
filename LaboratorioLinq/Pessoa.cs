using System;

namespace DemoLinq
{
   internal class Pessoa
   {
      public EstadoCivil EstadoCivil { get; set; }

      public String Nome { get; set; }

      public DateTime DataNascimento { get; set; }

      public override string ToString()
      {
         return "[Nome = " + Nome +
                ", Estado Civil = " + EstadoCivil +
                ", DataNascimento = " + DataNascimento.ToShortDateString() + "]";
      }
   }

   internal enum EstadoCivil
   {
      Solteiro = 1,
      Casado,
      Divorciado,
      Viuvo
   }
}