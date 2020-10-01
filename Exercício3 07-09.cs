using System;

namespace _07093
{
    class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            int nota1, nota2, nota3,dif;
            int notafinal;


            Console.WriteLine("Digite as informações:");
            Console.Write("Nome: ");
            aluno = Console.ReadLine();
            Console.Write("Digite a nota 1 de 0 a 30:");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota 2 de 0 a 35: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota 3 de 0 a 35: ");
            nota3 = int.Parse(Console.ReadLine());

            notafinal = nota1 + nota2 + nota3;
            Console.WriteLine("Nota final:");
            Console.WriteLine(notafinal);

            if (notafinal >= 60)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Aluno Aprovado");


            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Aluno reprovado");
                dif = 90 - notafinal;
                Console.WriteLine("Pontos faltantes:");
                Console.WriteLine(dif);
                Console.ReadKey();
            }
        }
    }
}



