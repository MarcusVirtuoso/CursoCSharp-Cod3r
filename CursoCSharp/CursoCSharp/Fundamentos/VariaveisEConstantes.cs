using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.5;
            double area = PI * raio * raio;
            Console.WriteLine("A área é: " + (area + 1000) );

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Mínimo valor do sbyte: "+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: "+ salario);

            int menorValorInt = int.MinValue; //Mais usado
            Console.WriteLine("Menor valor inteiro: "+ menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: "+ menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao Mundial: "+ populacaoMundial);

            float precoComputador = 1299.99f;
            // Lembrar de colocar o 'F' no final, senão o programa vai entender que é DOUBLE
            Console.WriteLine("Preço do computador: "+ precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado dos reais
            Console.WriteLine("Valor de mercado da apple: "+ valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Maior valor de decimal: "+ distanciaEntreAsEstrelas);

            char letra = 'm';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);
        }
    }
}
