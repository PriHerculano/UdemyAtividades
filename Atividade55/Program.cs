//1078
//Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
//1 x N = N      2 x N = 2N        ...       10 x N = 10N
//ENTRADA: A entrada contém um valor inteiro N (2 < N < 1000).
//SAÍDA: Imprima a tabuada de N, conforme o exemplo fornecido.

using System;

    namespace Atividade55{
        class Program{
            static void Main(string[]args){

                int i, soma;
                int N = int.Parse(Console.ReadLine());

                for(i = 0; i < 11; i++){
                    soma = N * i;
                    Console.WriteLine(i + " X " + N + " = " + soma);
                }
            }

        }
    }
