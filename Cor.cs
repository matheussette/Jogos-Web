using System;
using System.Collections.Generic;
using System.Text;

enum Cor //Cores 
{
    Preto,
    Azul,
    Vermelho
}
namespace formasgeometricas
{
    abstract class Forma
    {

        public Cor Color { get; set; }
        public double Raio { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Forma(Cor color) //Construtor com parametros
        {
            Color = color;
        }
        public abstract double Area(); //Método abstrato
    }
}
