
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Quantidade de funcionarios: ");//Solicita o numero dos funcionarios registrados
            int N = int.Parse(Console.ReadLine());

            
            List<Funcionario> lista = new List<Funcionario>();//lista

            
            for (int i = 0; i < N; i++)//usando o for pra repetir o pedido dos dados dos funcionarios de acordo com o número de funcionários pra registro
            {
                Console.WriteLine("\nFuncionário #" + (i + 1) + ":"); //Dados do ID

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());//Dados do Nome
               
                Console.Write("Nome: ");
                string nome = Console.ReadLine();//Dados do salário

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Insert(i, new Funcionario(id, nome));
                lista[i].Salario = salario;
            }

          
            Console.Write("\nId do funcionário que receberá aumento: ");  //definindo por ID, o funcionário que receberá aumento
            string idAumento = Console.ReadLine();


            List<Funcionario> lista2 = lista.FindAll(x => x.Id.ToString("000") == idAumento); //condições se existe ou não o número indicado pro aumento no banco de registros

            if (lista2 == null)
            {
                Console.WriteLine("O funcionário de ID " + lista2[0].Id.ToString("000") + " não existe!");

                Console.ReadKey();
            }

            else
            {
                Console.Write("Porcentagem de aumento de salário: ");
                lista2[0].AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("\nLista atualizada de funcionários da Bravo: ");
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();
        }
    }
}
