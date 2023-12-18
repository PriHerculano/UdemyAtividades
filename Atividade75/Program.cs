//Ex02
//Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
//- todos os números pares
//- a quantidade de números pares

using System;

namespace Atividade75{

    class Program{

        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int posicao=0;
            int contadora=0;

            string[]s = Console.ReadLine().Split(' ');
            for(int i = 0; i<n; i++){
            num[i] = int.Parse(s[i]);
            }

            for (int i = 0; i<n; i++){
                if(num[i]%2==0){
                    Console.WriteLine(num[i]);

                    contadora++;
                }
            }
                    Console.WriteLine(contadora);
        }
    }
}