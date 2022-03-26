using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            //return base.Equals(obj);
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() {
            //return base.GetHashCode();
            return Nome.Length;
        }
    }


    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada de game of thrones",99.9),
                new Produto("Poster",10),
            };

            // Para adicionar o conteudo de uma lista em outra:
            carrinho.AddRange(combo);

            // Count é usado para contar qts elementos existem na lista
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(2);

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
