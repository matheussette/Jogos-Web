using System;
using System.Collections.Generic;
using System.Globalization;


namespace formasgeometricas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lista das formas e quantidade das mesmas
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) { 
                Console.WriteLine($"Forma #{i}:");
            Console.Write("Retângulo ou Circulo(R / C) ? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Cor: (Preto / Azul / Vermelho): ");
            Cor cor = Enum.Parse<Color>(Console.ReadLine);
            if (ch == 'R') {
                Console.Write("Largura: ");//adiciona altura e largura a lista
                double largura = double.Parse(Console.ReadLine(), CultureInlfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInlfo.InvariantCulture);
                list.Add(new Retangulo(largura, altura, cor));
            }
            else
            {
                Console.WriteLine("Raio: ");//Adiciona raio a lista
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Circulo(raios, cor));
            }
            Console.WriteLine();//Escrever a área
            Console.WriteLine("Área de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
                Console.ReadKey();
        }
    }        
}
