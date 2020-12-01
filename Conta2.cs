using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta2 : Conta
    {
        public double TaxaJuros { get; set; } //Declaração das variáveis e encapsulamento
        public Conta2()
        {
            //Construtor padrão
        }
        public Conta2(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo) //Construtor com parâmetros
        {
            TaxaJuros = taxaJuros;
        }
        public sealed override void Saque(double saldoTotal) //Realiza saque
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
        public void atualizacaoSaldo() //Atualiza o Saldo
        {
            Saldo += Saldo * TaxaJuros;

        }
    }
}