using System;
using System.Drawing;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 1: ");
            Circulo circ5 = new CirculoColorido(3, 2.6, 2, "azul"); //tipo Circulo com instanciação de CirculoColorido usando construtor do CirculoColorido
            Console.WriteLine(circ5);
            CirculoColorido circ6 = new CirculoColorido(5.5, 3, 1); //usando novo contrutor sem a passagem de parametro de cor
            Console.WriteLine(circ6);
            Console.WriteLine(circ6.CentroX);           //acessando instruções da classe Circulo em objeto de CirculoColorido
            Console.WriteLine(circ6.CentroY);
            Console.WriteLine(circ6.Raio);
            Console.WriteLine(circ6.Cor);

            Console.WriteLine(" ");
            Console.WriteLine("Questão 2: ");
            Console.WriteLine("Objeto utilizado para armazenar a cor do preenchimento: Color do namespace System.Drawing;.");
            CirculoColoridoPreenchido circ7 = new CirculoColoridoPreenchido();
            Console.WriteLine(circ7);
            Console.WriteLine(circ7.Cores);
            CirculoColoridoPreenchido circ8 = new CirculoColoridoPreenchido(7.6, 4.2, 2, "azul", Color.Red);
            Console.WriteLine(circ8);
            Console.WriteLine(circ8.Cor);       //acessando construtor da classe CirculoColorido
            Console.WriteLine(circ8.Cores);
            Console.WriteLine(circ8.CentroX);   //acessando construtor da classe Circulo

            Console.WriteLine(" ");
            Console.WriteLine("Questão 3: ");
            Circulo[] circulos = new Circulo[3];
            circulos[0] = new Circulo();
            circulos[1] = new CirculoColorido();
            circulos[2] = new CirculoColoridoPreenchido();
            foreach (Circulo j in circulos)
            {
                Console.WriteLine(j);
            }
            circulos[0] = new Circulo(5.5, 6.2, 2);
            circulos[1] = new CirculoColorido(3.7, 2.2, 3, "verde");
            circulos[2] = new CirculoColoridoPreenchido(17.4, 22.2, 5.55, "azul", Color.YellowGreen);
            foreach (Circulo j in circulos)
            {
                Console.WriteLine(j);
            }
        }
    }
}
