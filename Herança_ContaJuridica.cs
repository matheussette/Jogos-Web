using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
  
        class ContaJuridica : Conta
        {
            public double EmprestimoLimite { get; set; } // Declaração das variáveis e uso do encapsulamento
            public ContaJuridica()
            {
                // Criação do construtor com parâmetros utilizando o da Classe Conta
            }
            public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo) // Criação do construtor com parâmetros utilizando o da Classe Conta
            {
                EmprestimoLimite = emprestimoLimite;
            }
            public void Emprestimo(double saldoTotal) // Realiza o Empréstimo
            {
                if (saldoTotal <= EmprestimoLimite)
                {
                    _saldo += saldoTotal;
                }
            }

        }
    }
