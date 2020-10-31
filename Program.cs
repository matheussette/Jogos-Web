using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System;

namespace _1210
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe a quantidade de pessoas
            Console.WriteLine("Quantidade de pessoas: ");
            int a = int.Parse(Console.ReadLine());

            double[] b = new double[a];


            //Repetição da quantidade de pessoas informada
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Altura da pessoa: " + i);
                b[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
           
            double c = 0.0;


            for (int i = 0; i < a; i++)
            {
                c+= b[i];
            }

            //Calculando a média
            double d = c / a;

            //Exibindo o resultado
            Console.WriteLine("A média de altura é: " + d);
            Console.ReadKey();

        }
    }
}

