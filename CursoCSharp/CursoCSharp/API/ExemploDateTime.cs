using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2021, month: 10, day: 08);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: "+ diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);
            Console.WriteLine("Segundos: " + diaAtual.Second);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine("");
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
