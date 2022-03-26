using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // todos
        public string InfoPublica = "Tenho um instagram";

        // herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // mesma classe ou herança no mesmo projeto (c# <= 7.2)
        private protected string SegredoFamilia = "Bla bla bla";

        // private é o padrao
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
