//Ex01
//) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número do vetor (supor não haver empates).
//Mostrar também a posição do maior elemento

using System;
using System.Globalization;

namespace Atividade74
{

    class Program
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int posicao = 0;
            double[] num = new double[n];
            double maior = 0.0;


            string[] s = Console.ReadLine().Split(' ');
            
            for(int i =0;i<n;i++){
                 num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for(int i=0;i<n;i++){
                if(num[i]>maior){
                    maior = num[i];
                    posicao = i;
                }
                
        
            }
            System.Console.WriteLine(maior);
            System.Console.WriteLine(posicao);
            

          

        }
    }
}
