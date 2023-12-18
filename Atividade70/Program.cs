//Faça um programa que leia N número inteiros e armazene-os em um vetor. Em seguida, mostrar na tela todos os números negativos lidos.

using System;

namespace Atividade70{

    class Program{

        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i=0; i<N; i++){
                vet[i] = int.Parse(s[i]);
            }

            for(int i = 0; i<N; i++){
                if(vet[i] < 0){
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}