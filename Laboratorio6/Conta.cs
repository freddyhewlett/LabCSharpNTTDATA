
namespace Laboratorio6
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;
        private string tipoConta;

        public Conta (string nom, string tc)
        {
            titular = nom;
            tipoConta = tc;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public string Titular
        {
            get { return titular; }
        }

        public abstract string Id
        {
            get;
        }

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
