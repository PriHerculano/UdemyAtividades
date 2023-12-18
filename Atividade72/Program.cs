//Fazer um programa para ler um número N, depois nome (apenas uma palavra), idade e altura de N pessoas, conforme exemplo. Depois mostrar na tela a altura média das pessoas,
//e mostrar também a porcentagem de pessoas com menos de 16 anos.

using System;
using System.Globalization;

namespace Atividade72
{

    class Program
    {

        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            //leitura dos dados
            for (int i = 0; i < N; i++){
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            //calculo de média das alturas
            double soma = 0.0;
            for (int i = 0; i < N; i++){
                soma = soma + altura[i];
            }

            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //porcentagem de pessoas com menos de 16 anos
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
            }

            double porcentagem = (double)cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}