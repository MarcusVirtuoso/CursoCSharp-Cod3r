using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        // uma função de extensão é definida pq eu estou associando o THIS com o tipo do meu parametro
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, double outroNumero)
        {
            return num - outroNumero;
        }
    }
    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numReal = 5.5;
            
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numReal.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine((2.9).Subtracao(4));
        }
    }
}
