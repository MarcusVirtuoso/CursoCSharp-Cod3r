using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            // conversão implícita
            double quebrado = inteiro;
            Console.WriteLine("Valor quebrado: "+ quebrado);

            double nota = 9.7;
            // conversão explícita
            // (CAST)
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            // Converter string para numero
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Idade usando o convert: "+ idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado usando TryParse: {0}", numero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado usando TryParse (Caso otimizado): {0}", numero2);
        }
    }
}
