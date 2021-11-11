using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class CirculoColoridoPreenchido : CirculoColorido
    {
        private Color cores;

        public CirculoColoridoPreenchido()              //construtor sem passagem de parametros
        {
            cores = Color.Transparent;
        }

        public CirculoColoridoPreenchido(double x, double y, double r, string c, Color cor) : base (x, y, r, c) //construtor com passagem de parametros
        {
            cores = cor;
        }

        public CirculoColoridoPreenchido(double x, double y, double r) : base (x, y, r)     //construtor sem a passagem de parametro de cor
        {
            cores = Color.Aqua;
        }

        public string Cores
        {
            get { return cores.ToString(); }
            set { cores = Color.FromName(value); }
        }

        public override string ToString()
        {
            return base.ToString() + ", cor preenchimento = " + Cores;
        }
    }
}
