using System;

namespace _2408
{

    class Program
    {


        static void Main(string[] args)
        {

            string Nome1, Nome2;
            int Sala1, Sala2, Idade1, Idade2;
            int mediasal;

          
            Console.WriteLine("Digite Nome idade e salário da primeira pessoa :");
            Console.Write("Nome: ");
            Nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            Idade1 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sala1 = int.Parse(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Digite Nome idade e salário da segunda pessoa: ");
            Console.Write("Nome: ");
            Nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            Idade2 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sala2 = int.Parse(Console.ReadLine());
           
            mediasal = (Sala1 + Sala2) / 2;

            if (Idade1 > Idade2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("O nome da pessoa mais velha é " + Nome1);
                Console.WriteLine("A média salarial é: " + mediasal);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("O nome da pessoa mais velha é " + Nome2);
                Console.WriteLine("A média salarial é: " + mediasal);
                Console.ReadKey();
            }

        }
    }
}

