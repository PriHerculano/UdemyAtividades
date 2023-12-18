//Faça um programa que leia N número reais e armazene-os em um vetor. Em seguida:
//-Imprimir todos os elementos do vetor
//-Mostrar na tela a soma de a média dos elementos do vetor

using System;
using System.Globalization;

namespace Atividade71{

    class Program{

        static void Main(string[] args){

            int N = int.Parse(Console.ReadLine());
            double[] A = new double[N];

            string[]s = Console.ReadLine().Split(' ');
            for (int i = 0; i<N; i++){
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i =0; i<N; i++){
                Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture)+" ");
            }

            Console.WriteLine();

            double soma = 0.0;
            for(int i = 0; i<N; i++){
                soma = soma + A[i];
            }

            double media=soma/N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}