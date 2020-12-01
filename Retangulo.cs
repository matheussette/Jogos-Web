using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace formasgeometricas.Entities
{
    class Retangulo : Forma
    {
        publicdoubleLargura{get;set;}
        publicdoubleAltura{get;set;}
{
    publicRetangulo(doublelargura, doublealtura, Colorcor):base(cor){
        Largura = largura;
        Altura = altura;
    }
    publicoverridedoubleArea(){
        returnLargura* Altura;
    }
    }
}
