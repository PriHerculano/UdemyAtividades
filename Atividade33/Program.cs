//1036
//Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
//caso haja uma divisão por 0 ou raiz de numero negativo.
//ENTRADA: Leia três valores de ponto flutuante (double) A, B e C.
//SAIDA: Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma 
//mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

using System;
using System.Globalization;

namespace Atividade33{

    class Program{

        static void Main(string[] args){

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            double delta = Math.Pow(B,2.0) - 4*A*C;

            if (A==0 || delta<0.0){
                Console.WriteLine("Impossivel calcular");
            }

            else{
            double r1 = (-B+Math.Sqrt(delta))/(2.0*A);
            double r2 = (-B-Math.Sqrt(delta))/(2.0*A);
            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
// Δ = b2 – 4ac
// (-b±√(b²-4ac))/(2a)