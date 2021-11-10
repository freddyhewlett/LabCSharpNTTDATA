using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Laboratório 01";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Beep();
            if (Console.CapsLock)
            {
                Console.WriteLine("CAPSLOCK ativado");
            }
            else
            {
                Console.WriteLine("CAPSLOCK desativado");
            }
            Console.Write("Alô Mundo! ");
            Console.WriteLine("Tudo bom?");
            Console.Write("\nÉ nozes!\n");
            Console.ResetColor();
        }
    }
}