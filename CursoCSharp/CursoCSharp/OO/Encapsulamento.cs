using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFilho Nao reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); (Internal) Somente dentro do mesmo projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); Somente visivel dentro da mesma classe ou herança(Private Protected)
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); Somente dentro da mesma classe (Private)
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAmigo distante...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho); este atributo foi somente transmitido por herança (Protected)
            //Console.WriteLine(amiga.NumeroCelular); // (Internal) somente dentro do projeyo
            //Console.WriteLine(amiga.JeitoDeFalar); (Internal Protected) somente dentro do projeto ou herança
            //Console.WriteLine(amiga.SegredoFamilia); Somente visivel dentro da mesma classe ou herança(Private Protected)
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); Somente dentro da mesma classe (Private)
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
