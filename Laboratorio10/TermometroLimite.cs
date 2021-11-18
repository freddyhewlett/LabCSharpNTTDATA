namespace Laboratorio10
{
    public class TermometroLimite : Termometro
    {
        private double limiteSuperior;
        private bool disparadoEventoLimiteSuperior;     //atributo controla se o evento foi ativado ou não
        private bool disparadoEventoAbaixoLimite;

        public TermometroLimite(double ls)              //contrutor inicializa o objeto com todos os eventos "desligados"
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
            disparadoEventoAbaixoLimite = false;
        }

        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        public override void Aumentar()
        {
            base.Aumentar();
            if ((this.Temperatura > limiteSuperior) && (disparadoEventoAbaixoLimite))       //esta condicional garante que o evento AbaixoLimiteEvent estará falso caso ja tenha sido ativado
            {
                disparadoEventoAbaixoLimite = false;
            }
            OnLimiteSuperiorEvent();                                                        //ativa o evento LimiteSuperiorEvento caso este atinja os requisitos
        }

        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            if ((this.Temperatura > limiteSuperior) && (disparadoEventoAbaixoLimite))       
            {
                disparadoEventoAbaixoLimite = false;
            }
            OnLimiteSuperiorEvent();
        }

        public override void Diminuir()
        {
            base.Diminuir();
            if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))        //é o inverso da condicional do metodo Aumentar()
            {
                disparadoEventoLimiteSuperior = false;
            }
            OnAbaixoLimiteEvent();                              //ativa evento AbaixoLimiteEvent caso atinja os requisitos
        }

        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
            OnAbaixoLimiteEvent();
        }

        public delegate void DelegateLimite(string msg, double temp);   //o mesmo delegate serve para diferentes eventos
        public event DelegateLimite LimiteSuperiorEvent;
        public event DelegateLimite AbaixoLimiteEvent;

        private void OnLimiteSuperiorEvent()
        {
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
            {
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent("***Atenção***: Temperatura acima do limite!!!\nTemperatura atual: ", Temperatura);
                    disparadoEventoLimiteSuperior = true;
                }
            }
        }

        private void OnAbaixoLimiteEvent()
        {
            if ((this.Temperatura <= limiteSuperior) && (!disparadoEventoAbaixoLimite))
            {
                if (AbaixoLimiteEvent != null)
                {
                    AbaixoLimiteEvent("Normalizando temperatura...\nTemperatura atual: ", Temperatura);
                    disparadoEventoAbaixoLimite = true;
                }
            }
        }
    }
}