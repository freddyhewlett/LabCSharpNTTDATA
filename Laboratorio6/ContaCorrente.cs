using System;

namespace Laboratorio6
{
    class ContaCorrente : Conta
    {
        private decimal taxaServico;
        private decimal rendimento;
        private DateTime rendMensal;
        private string tipoConta;

        public ContaCorrente(decimal taxs, decimal rend, DateTime d, string n) : base(n)
        {
            taxaServico = taxs;
            rendimento = rend;
            rendMensal = d;
            tipoConta = "Conta Corrente";
        }

        public decimal Rendimento
        {
            get { return rendimento; }
            set { rendimento = value; }
        }

        public DateTime RendMensal
        {
            get { return rendMensal; }
        }

        public void AdicionarRendimento()
        {
            DateTime hoje = DateTime.Now;
            if ((hoje.Day == rendMensal.Day && hoje.Month != rendMensal.Month) || (hoje.Day == rendMensal.Day && hoje.Month == rendMensal.Month))
            {
                decimal taxaRend = this.Saldo * rendimento;
                this.Depositar(taxaRend);
            }
        }

        public void CobrancaServico()
        {
            DateTime hoje = DateTime.Now;
            if ((hoje.Day == rendMensal.Day && hoje.Month != rendMensal.Month) || (hoje.Day == rendMensal.Day && hoje.Month == rendMensal.Month))
            {
                this.Sacar(taxaServico);
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
