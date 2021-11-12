using System;

namespace Laboratorio6
{
    public class ContaPoupanca : Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversarioConta;
        private string tipoConta;

        public ContaPoupanca(decimal j, DateTime d, string n) : base(n)
        {
            taxaJuros = j;
            dataAniversarioConta = d;
            tipoConta = "Conta Poupança";
        }

        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }

        public DateTime DataAniversario
        {
            get { return dataAniversarioConta; }
        }

        public void AdicionarRendimento()
        {
            DateTime hoje = DateTime.Now;
            if (hoje.Day == dataAniversarioConta.Day && hoje.Month == dataAniversarioConta.Month)
            {
                decimal rendimento = this.Saldo * taxaJuros;
                this.Depositar(rendimento);
            }
        }

        public override string Id
        {
            get { return this.Titular + "; " + tipoConta; }
        }

        public override string ToString()
        {
            return this.Id + "\n" + "Saldo: R$ " + string.Format(string.Format("{0:F2}", this.Saldo));
        }
    }
}
