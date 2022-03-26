using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    class ExcecoesPersonalizadas
    {
        public class NegativoException : Exception
        {
            public NegativoException() { } // construtor padrão

            public NegativoException(string message) : base(message) { } // sobrescrevendo o contrutor padrão

            public NegativoException(string message, Exception inner) : base(message, inner) { } // sobrescrevendo o contrutor padrão
        }

        public class ImparException : Exception
        {
            public ImparException(string message) : base(message) { }
        }

        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 31);

            if (valor < 0)
            {
                throw new NegativoException($"Numero negativo: {valor}");
            }

            if (valor % 2 == 1)
            {
                throw new ImparException($"Numero ímpar: {valor}");
            }

            return valor;

        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
