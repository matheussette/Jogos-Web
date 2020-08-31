using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programação
{
    

    class Program
    {


        static void Main(string[] args)
        {

            string Nome1, Nome2;
            int Sala1, Sala2, Idade1, Idade2;
            int MediaSal;

            Console.WriteLine("=======================================");
            Console.WriteLine("Digite o nome, idade e salário da pessoa 1:");
            Console.Write("Nome: ");
            Nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            Idade1 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sala1 = int.Parse(Console.ReadLine());
            Console.ReadLine();
            

            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("Digite o nome, idade e salário da pessoa 2:");
            Console.Write("Nome: ");
            Nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            Idade2 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            Sala2 = int.Parse(Console.ReadLine());
            Console.WriteLine("=======================================");
            Console.Clear();

            MediaSal = (Sala1 + Sala2) / 2;

            if (Idade1 > Idade2)
            {
                Console.WriteLine("O nome da pessoa mais velha é " + Nome1);
                Console.WriteLine("A média salarial é: " + MediaSal);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O nome da pessoa mais velha é " + Nome2);
                Console.WriteLine("A média salarial é: " + MediaSal);
                Console.ReadKey();
            }

            

        }
    }
}
