

using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaDePagamento
{
    class Tercerizado : Funcionário
    {
        public double Adicional { get; set; } //Declaração das variaveis e encapsulamento
        public Tercerizado()
        {
            //Construtor padrão
        }
        public Tercerizado(string nome, int horas, double valor, double adicional) : base(nome, horas, valor) //Construtor com parametros
        {
            Adicional = adicional;
        }
        public override double Pagamento() //Calcular o pagamento do funcionário tercerizado
        {
            return Horas * Valor + Adicional * 1.1;
        }
    }
}
