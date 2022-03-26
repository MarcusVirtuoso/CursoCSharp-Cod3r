using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de classe ou método estático;
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        // Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("O resultado da multiplicação é: " + resultado);

            // Métodos não estáticos não podem ser acessados a menos que exista uma instância da Classe
            // Ou seja, é necessário instanciar uma classe para poder acessar os métodos não estáticos
            // Membros estáticos, pertencem a classe e não a instância
            //Console.WriteLine("A soma é: " + CalculadoraEstatica.Somar(2, 2));
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
