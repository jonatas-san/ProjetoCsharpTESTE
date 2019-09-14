using System;

namespace ExercicioPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;

            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Nome:");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
            }
            else if(p2.Idade > p1.Idade)
            {
                Console.WriteLine("\nPessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("\n" + p1.Nome + " e " + p2.Nome + " tem a mesma idade, " + p1.Idade + " anos de idade.");
            }
        }
    }
}
