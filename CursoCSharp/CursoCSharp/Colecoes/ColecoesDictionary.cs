using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem aranha");
            filmes.Add(2004, "Os incríveis");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: {0}", filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine("Filme: " + filme2006);

            // buscando por chave
            foreach(var item in filmes.Keys) {
                Console.WriteLine(item);
            }

            // buscando por valor
            foreach(var item in filmes.Values) {
                Console.WriteLine(item);
            }

            // buscando por chave e valor
            foreach(KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            Console.WriteLine("---------------------------------------");
            // deixando o compilador inferir qual é o tipo da variável
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }

    }
}
