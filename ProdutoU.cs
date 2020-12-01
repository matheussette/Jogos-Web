
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Polimorfismo
{
    class ProdutoU :ProdutoC
    {
        public DateTime fabricacao; //variavel do tipo data
        public ProdutoU(string Nome, double Preco, DateTime Fabricacao) : base(Nome, Preco) //parametros que a classe vai receber
        {
            fabricacao = Fabricacao;
        }
        public override string etiqueta() //Etiqueta do produto usado
        {
            return nome + " (usado) - R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + "(fabricado: " + fabricacao.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")";
        }
    }
}