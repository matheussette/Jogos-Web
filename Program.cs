using System;

namespace VetoresHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            Aluguel[] quartos = new Aluguel[10];
            Console.Write("Quantos hóspedes serão registrados? ");// quantidade de hospedes a serem registrados
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("Dados do " + i + "° hóspede: ");
                Console.Write("Nome: ");//recebe os nomes
                string nome = Console.ReadLine();
                Console.Write("Email: ");//recebe os emails
                string email = Console.ReadLine();
                Console.Write("Quarto: ");//recebe os quartos
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Aluguel(nome, email);
            }
            Console.WriteLine("Quartos ocupados:  ");
            for (int i = 0; i < 10; i++) //enquanto i for igual a 0 e menor q 10 repete
            {
                if (quartos[i] != null) // se a condição for falsa executa a exibição das informações
                {
                    Console.WriteLine(i + ": " + quartos[i]); //exibe as informações dos quartos ocupados
                }
            }

            Console.ReadLine();
        }
    }
}


