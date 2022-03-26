using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAmigo proximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); este atributo foi somente transmitido por herança (Protected)
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia); Somente visivel dentro da mesma classe ou herança(Private Protected)
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); Somente dentro da mesma classe (Private)
        }
    }
}
