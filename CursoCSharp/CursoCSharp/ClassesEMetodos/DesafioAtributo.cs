using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            var desafio = new DesafioAtributo(); 

            // Acessar variavel 'a' dentro do método Executar();
            Console.WriteLine("O valor da variavel 'a' é: {0}", desafio.a);
        }
    }
}
