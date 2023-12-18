//1099
//Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma de todos os
//ímpares existentes entre X e Y.
//ENTRADA: A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.
//SAIDA: Imprima a soma de todos valores ímpares entre X e Y.
using System;

namespace Atividade68{

    class Program{

        static void Main(string[] args){

            int aux, soma;
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                string[]v = Console.ReadLine().Split(' ');
                int X = int.Parse(v[0]);
                int Y = int.Parse(v[1]);

                if(X>Y){
                    aux = X;
                    X = Y;
                    Y = aux;
                }

                soma = 0;
                for(int Z = X + 1; Z < Y; Z++){
                    if(Z % 2 != 0){
                        soma = soma + Z;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}