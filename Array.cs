using System;
using System.Globalization;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            //Recebe a quantidade do produto
            Console.WriteLine("Informe a quantidade dos produtos: ");
            int a = int.Parse(Console.ReadLine());
            Classe[] vect = new Classe[a];
            for (int i = 0; i < a; i++)
            {
                //Recebe o nome do produto
                Console.WriteLine("Insira o nome: ");
                string b = Console.ReadLine();

                //Recebe o preço do produto
                Console.WriteLine("Insira o valor: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Classe { Name = b, Price = price };
            }

            double c = 0.0;



            for (int i = 0; i < a; i++)
            {
                c += vect[i].Price;
            }

            
            double d = c / a;
            //Cálculo da média

           
            Console.WriteLine("A média é: " + d);
            Console.ReadKey();

        }
    }
}
