//Ex04
//Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos. Depois mostrar todos os elementos do
//vetor que estejam abaixo da média.

using System;
using System.Globalization;

namespace Atividade77{

    class Program{

        static void Main(string[]args){

            int n = int.Parse(Console.ReadLine());
            double[]num = new double[n];

            string[]s = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++){
                num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for(int i = 0; i < n; i++){
                soma = soma + num[i];
            }

            double media = soma/n;
            Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));

            for(int i = 0; i < n; i++){
                if(num[i]<media){
                    Console.WriteLine(num[i].ToString(("F1"), CultureInfo.InvariantCulture));
                }
            }
        }
    }
}