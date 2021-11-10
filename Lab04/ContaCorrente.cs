using System;

namespace Laboratorio4
{
    class ContaCorrente
    {
        private decimal saldo;                                              //atributos
        private string nome;
        private DateTime dtInit;
        private DateTime dtMovim;
        private decimal saldoMedio;
        private int contador = 1;

        public ContaCorrente(decimal val, string name)                      //contrutor
        {
            saldo = val;
            nome = name;
            dtInit = DateTime.Now;
        }

        public void Depositar(decimal val)
        {
            saldo += val;
            contador++;
        }

        public void Sacar(decimal val)
        {
            saldo -= val;
            contador++;
        }

        public void RegistraMovim()
        {
            dtMovim = DateTime.Now;     // testando
        }

        public void SaldoMedio()
        {
            saldoMedio = saldo / contador;
        }

        public string Nome
        {
            get { return nome; }
        }

        public DateTime DataInicial
        {
            get { return dtInit; }
        }

        public DateTime DataMoviment
        {
            get { return dtMovim; }
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public decimal AcessSaldoMed
        {
            get { return saldoMedio; }
        }
    }
}
