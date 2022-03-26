using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            // FIFO
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Sicrano");

            // o metodo PEEK simplesmente pega o primeiro elemento da fila, ou seja, o próximo que vai sair
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
