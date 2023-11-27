//Estrutura repetitiva "para"
//Fazer um programa que lê um valor inteiro N e depois N números inteiros. Ao final, mostra a soma dos números lidos.

using System;

namespace Atividade54{

    class Program{

        static void Main(string [] args){

            int N, x, soma;

            N = int.Parse(Console.ReadLine());
            
            soma = 0;
            for (int i=10; i>=N; i--){
                Console.WriteLine("valor: " + i);
                // x = int.Parse(Console.ReadLine());
                // soma = soma + x; 
            }
            // Console.WriteLine(soma);
        }
    }
}