using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespesaCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resp, despesa;
            double total, valor = 0;

            do
            {
                Console.Write("Informe qual a despesa: ");
                despesa = Console.ReadLine();
                Console.Write("Informe o valor dessa despesa: ");
                valor += double.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja adicionar mais uma despesa?(S/N)");
                resp = Console.ReadLine().ToUpper();
            }
            while (resp == "S");

            Console.WriteLine("O valor total das despesas é: " + total.ToString("C"));

            Console.WriteLine("Quantas pessoas moram na casa? ");
            int moradores = int.Parse(Console.ReadLine());

            double media = total / moradores;

            Console.WriteLine("Cada pessoa gasta, em média: " + media);

            Console.ReadKey();

        }
    }
}
