using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inserir os valores da matriz:");
            int n = int.Parse(Console.ReadLine());//criando a variavel n e recebendo valor do usuario

            int[,] mat = new int[n, n];//criando matriz de inteiros aberto para que o usuario coloque o valor

            for(int i  = 0; i < n; i++) //atribuindo tamanho pro for estabelecendo limite e fazend ele sair do lugar
            {
                string[] values = Console.ReadLine().Split(" ");//inputando os elementos para dentro da matriz utilizando split para alinhar na matriz
                    for(int j = 0; j < n; j++)//variável da coluna atribuindo 0 e um contador para sair do lugar 
                {
                    mat[i,j] = int.Parse(values[j]); 
                }
            }

            Console.WriteLine("Diagonal Principal:"); //imprimindo os valores na tela
            for(int i = 0; i< n; i++) //passa pela matriz e identifca os itens que tem que aparecer
            {
                Console.WriteLine(mat[i, i] + " ");//percorendo toda linha para imprimir a diagonal

            }

            Console.WriteLine(); // imprimir informação vazia

            int count = 0;// contador para identificar se o valor e menor que 0
            for(int i = 0; i < n; i ++) //percorrer a linha
            {
                for(int j = 0; j < n; j ++) //percorrer a coluna 
                {
                    if (mat [i,j] < 0 )//os numeros da matriz precisam ser menor que 0
                    {
                        count++;
                    }
                }
            }
                   
        }


    }
}
