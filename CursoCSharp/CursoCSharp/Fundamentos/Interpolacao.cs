using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Concatenação convencional
            Console.WriteLine(" O "+ nome + " da marca "
                + marca + " custa R$" + preco + ".");
            
            //Concatenando as variaveis em ordem
            Console.WriteLine(" O {0} da marca {1} custa {2}!", nome, marca, preco);

            // Concatenando com $
            Console.WriteLine($"A marca {marca} é boa!");
            Console.WriteLine($" 1 + 1 ={1 + 1} ");
        }
    }
}
