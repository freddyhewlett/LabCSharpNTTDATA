namespace Laboratorio7
{
    public class Notebook : IEstadoBinario
    {
        private bool ligado;
        private string sistemaOp;
        private bool placaVideo;
        private int armazenamento;

        public Notebook(string s, bool p, int a)
        {
            sistemaOp = s;
            placaVideo = p;
            armazenamento = a;
            ligado = false;
        }

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }

        public EstadoBinario Estado
        {
            get
            {
                if (ligado)
                    return EstadoBinario.Ligado;
                else
                    return EstadoBinario.Desligado;
            }
        }

        public override string ToString()
        {
            return "O notebook com SO " + sistemaOp + "(" + armazenamento + "Gb) está: \t" + Estado;
        }
    }
}