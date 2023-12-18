//1116
//Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os 
//valores em questão.
//ENTRADA: A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.
//SAÍDA: Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

using System;
using System.Globalization;

namespace Atividade67{

    class Program{

        static void Main(string[]args){

            float result;
            int i;
            int n = int.Parse(Console.ReadLine());

            for(i=1; i<=n; i++){
            string[]v = Console.ReadLine().Split(' ');
            float X = int.Parse(v[0]);
            float Y = int.Parse(v[1]);

            result = X/Y;

            if(Y==0){
                Console.WriteLine("divisao impossivel");
            }

            else{
                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }
            }
        }
    }
}