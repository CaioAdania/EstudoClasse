using EstudoClasse.Entities;

namespace EstudoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teams clube = new Teams();
            Console.Write("Qual seu time de coração? ");
            clube.Time = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Quantos titulos tem seu time? ");
            clube.Titulos = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Qual o Ano de criação do seu time? ");
            clube.Criacao = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Qual o número de torcedores do seu time? ");
            clube.Torcedores = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Qual o rival do seu time? ");
            clube.Rival = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(clube);
        }
    }
}
