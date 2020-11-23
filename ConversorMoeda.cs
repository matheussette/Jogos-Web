
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorMoedas
{


    class Program
{
    //Declarando o valor do imposto do dólar
    public static double Imposto = 0.6;

    static void Main(string[] args)
    {

        //pedindo a cotação do dólar
        Console.Write("Qual a cotação do dólar? ");
        float Dolar = float.Parse(Console.ReadLine());

        //pedindo o valor a ser comprado
        Console.Write("Quantos dólares você irá comprar? ");
        float Comprar = float.Parse(Console.ReadLine());

        //Declarando novas variáveis e fazendo os cálculos necessários
        double IOF = Dolar * Imposto;
        float Total = Dolar * Comprar;
        double SomImp = IOF + Total;

        //Mostrando o valor total da conta somando com os 6% de IOF
        Console.Write("Valor a ser pago em reais = " + SomImp);
        Console.ReadKey();


    }


}

}
