//Ex03
//Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos elementos 
//correspondentes de A e B. Imprima o vetor C gerado.

using System;

namespace Atividade76{

    class Program{
        
        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];

            string[]num1 = Console.ReadLine().Split(' ');
            for(int i = 0; i<n; i++){
                A[i] = int.Parse(num1[i]);
            }

            string[]num2 = Console.ReadLine().Split(' ');
            for(int i = 0; i<n; i++){
                B[i] = int.Parse(num2[i]);
            }

            for(int i = 0; i<n; i++){
            Console.WriteLine(A[i]+B[i]);
            }
        }
    }
}