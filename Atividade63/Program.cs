//1080
//Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.
//ENTRADA: O arquivo de entrada contém 100 números inteiros, positivos e distintos.
//SAIDA: Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

using System;

namespace uri1080 {
    class Program {
        static void Main(string[] args) {

            int i;
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (i = 2; i <= 100; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x > maior) {
                    maior = x;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}