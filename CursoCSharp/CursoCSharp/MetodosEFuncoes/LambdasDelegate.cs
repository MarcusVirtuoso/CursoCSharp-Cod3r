using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;
            Operacao subtrai = (x, y) => x - y;
            Operacao multiplica = (x, y) => x * y;

            Console.WriteLine(soma(3, 3));
            Console.WriteLine(subtrai(5, 2));
            Console.WriteLine(multiplica(12, 8));
        }
    }
}
