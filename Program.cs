using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');// receber a informação do usuário
            int m = int.Parse(line[0]);//indice 0
            int n = int.Parse(line[1]);//indice 1 

            int[,] mat = new int[m, n]; // matriz de inteiros de valor n, m representando linha e coluna
            
            for (int i = 0; i < m; i++)// contador para percorrer a matriz
            {
                string[] values = Console.ReadLine().Split(' ');// percorrendo na linha  
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);//colocando os elementos dentro da matriz percorrendo a coluna

                }
            }

            int x = int.Parse(Console.ReadLine());
            
            for( int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)// percorrer e identificar quais os valores iguais na matriz
                {
                    if(mat[i,j] == x)// toda vez que encontrar um numero igual a x
                    {
                        Console.WriteLine("Posicionamento " + i + "," + j + ":");//imprimir
                        if( j > 0)//identificar o item
                        {
                            Console.WriteLine("Esquerda " + mat[i, j - 1]);//identificar a esquerda do item e imprimir
                        }

                        if(i>0)
                        {
                            Console.WriteLine("Acima:" + mat[i - 1, j]);//identificar acima do item e imprimir

                        }
                        if(j < n -1)//identificar qual o n
                        {
                            Console.WriteLine("Direita:" + mat[i, j + 1]); //identificar a direita do item e imprimir
                        }
                        if (i < m - 1)//identificar qual o m
                        {
                            Console.WriteLine("Abaixo:" + mat[i + 1, j]);//identificar abaixo do item e imprimir
                        }

                    }
                }
            }
        }
    }
}
