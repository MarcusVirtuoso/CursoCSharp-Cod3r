using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é a sua nota? ");
            double nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá {nome}, sua idade é {idade} anos e sua nota é {nota}!");
        }
    }
}
