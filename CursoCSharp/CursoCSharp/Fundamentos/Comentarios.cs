using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    /// <summary>
    /// Aqui é possível criar um sumario, a partir do XML Comments com algumas tags já definidas
    /// </summary>
    class Comentarios
    {
        public static void Executar()
        {
            // Cuidado com comentarios desnecessarios
            Console.WriteLine("Código claro é sempre melhor!");

            /* Comentario de
             * multiplas linhas
             */
            Console.WriteLine("O C# tem o XML Comments");
        }
    }
}
