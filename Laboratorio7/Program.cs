using System;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstadoBinario[] lista = new IEstadoBinario[3];

            lista[0] = new Lampada(220, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            lista[2] = new Notebook("Windows", true, 532);
            lista[2].Ligar();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
