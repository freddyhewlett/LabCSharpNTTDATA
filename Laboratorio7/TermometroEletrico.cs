namespace Laboratorio7
{
    public class TermometroEletrico : Termometro, IEstadoBinario
    {
        private bool ligado = false;

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
            return "O termometro está: \t\t" + Estado;
        }
    }
}