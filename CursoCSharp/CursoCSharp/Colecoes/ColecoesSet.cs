using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesSet{
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            // o SET não é uma estrutura indexada
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada de game of thrones",99.9),
                new Produto("Poster",10),
                new Produto("Poster",10),
            };

            // Para adicionar o conteudo de uma lista em outra:
            //carrinho.AddRange(combo); 
            carrinho.UnionWith(combo); 

            // Count é usado para contar qts elementos existem na lista
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(2);

            foreach(var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
            Console.WriteLine(carrinho.Count);
        }
    }
}
