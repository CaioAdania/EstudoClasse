using EstudoClasse.Entities;
using System;
using System.Globalization;

namespace EstudoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();


            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }

            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            if(p1.Salario > p2.Salario)
            {
                Console.WriteLine(p1.Nome + " tem um Salário maior que " + p2.Nome + " e a média de salário entre os dois é de " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(p2.Nome + " tem um Salário maior que " + p1.Nome + " e a média de salário entre os dois é de " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
