
namespace Laboratorio5
{
    class CirculoColorido : Circulo
    {
        private string minhaCor;

        public CirculoColorido()
        {
            minhaCor = "preto";
        }

        public CirculoColorido(double x, double y, double r, string c) : base (x, y, r)
        {
            minhaCor = c;
        }

        public CirculoColorido(double x, double y, double r) : base (x, y, r) //construtor de CirculoColorido sem a passagem de parametro de cor
        {
            minhaCor = "branco";
        }

        public string Cor
        {
            get { return minhaCor; }
            set { minhaCor = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", cor do perimetro = " + Cor;
        }
    }
}
