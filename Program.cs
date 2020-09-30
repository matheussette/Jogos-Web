using System;

namespace _07092
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; 
            double percentual, valor_final,sal,imposto,sall;


            Console.WriteLine("Digite o nome, salário bruto e imposto :");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            sal = double.Parse(Console.ReadLine());
            Console.Write("Imposto ");
            imposto = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Nome:");
            Console.WriteLine(nome);
            Console.WriteLine("Salário Líquido");
            sall = sal - imposto;
            Console.WriteLine(sall);
            Console.WriteLine("Digite uma porcentagem para aumentar o salário:");
            percentual = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine("Nome");
            Console.WriteLine(nome);
            Console.WriteLine("Salário");
            valor_final = (percentual/ 100) * sall;
            Console.WriteLine(valor_final+ sall);



            Console.ReadKey();
        }
    }
}



