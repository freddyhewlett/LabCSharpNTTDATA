namespace Laboratorio7
{
    public class Lampada : IEstadoBinario
    {
        private bool ligado;
        private int voltagem;
        private int potencia;
        
        public Lampada(int v, int p)
        {
            ligado = false;
            voltagem = v;
            potencia = p;
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
            return "A lampada (" + voltagem + "v) está: \t\t" + Estado;
        }
    }
}