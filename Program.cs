using System;

namespace _3108
{
    class Program
    {
    

        static void Main(string[] args)
        {

            string Produto;
            int quantidade,adicionado,resultado,removido,resultado2;
            double valor;

            //RECEBER VALORES
            Console.WriteLine("Digite o produto o preço e a quantidade em estoque :");
            Console.Write("Produto: ");
            Produto = Console.ReadLine();
            Console.Write("Valor: ");
            valor  = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Total:R$" + valor * quantidade);
            Console.WriteLine("  ");
            //SOMA
            Console.WriteLine("Digite o número a ser adicionado ao estoque:");
            adicionado = int.Parse(Console.ReadLine());
            resultado = quantidade + adicionado;
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine("Produto:");
            Console.WriteLine(Produto);
            Console.WriteLine("Valor:");
            Console.WriteLine(valor);
            Console.WriteLine("Quantidade em estoque:");
            Console.WriteLine(resultado);
            Console.WriteLine("Total:R$");
            Console.WriteLine(valor*resultado);
            Console.WriteLine("  ");

            //SUBTRAÇÃO
            Console.WriteLine("Digite o número a ser removido do estoque:");
            removido = int.Parse(Console.ReadLine());
            resultado2 = resultado - removido;
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine("Produto:");
            Console.WriteLine(Produto);
            Console.WriteLine("Valor:");
            Console.WriteLine(valor);
            Console.WriteLine("Quantidade em estoque:");
            Console.WriteLine(resultado2);
            Console.WriteLine("Total:R$");
            Console.WriteLine(valor*resultado2);

            Console.ReadKey();
            }

        }
    }


