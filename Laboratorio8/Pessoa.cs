using System;
using System.Collections;

namespace Laboratorio8
{
    public class Pessoa : IComparable<Pessoa>
    {
        private string meuNome;
        private int minhaIdade;
        private bool ordenaIdade = false;
        
        public Pessoa(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }

        public void OrdenaIdade(bool o)
        {
            ordenaIdade = o;
        }

        public int CompareTo(Pessoa outro)
        {
            if (ordenaIdade)
                return minhaIdade.CompareTo(outro.minhaIdade);
            else
                return meuNome.CompareTo(outro.meuNome);
        }

        public string Nome
        {
            get { return meuNome; }
            set { meuNome = value; }
        }

        public int Idade
        {
            get { return minhaIdade; }
            set { minhaIdade = value; }
        }
    }
}