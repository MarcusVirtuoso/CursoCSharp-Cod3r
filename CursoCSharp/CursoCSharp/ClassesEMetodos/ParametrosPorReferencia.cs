using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            // Com o ref eu recebo a referencia de uma variavel e consigo manipular ela
            // é necessário inicializar a variavel antes de usar
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)
        {
            // o out é unidirecional, eu não posso receber um valor para alterar
            // não é necessário inicializar a variavel antes de usar
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
