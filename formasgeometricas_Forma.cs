using System;
using System.Collections.Generic;
using System.Text;

namespace formasgeometricas
{
    class Circulo : Forma
    {
        public Circulo(double raio, Cor cor) : base(cor) //Construtor com parametros
        {
            Raio = raio;
        }
        public override double Area() //Calculando a área
        {
            return Math.PI * Raio * Raio;
        }
    }
}
