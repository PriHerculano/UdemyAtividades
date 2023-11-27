using System;

    namespace Atividade55{
        class Program{
            static void Main(string[]args){

                int i, soma;
                int N = int.Parse(Console.ReadLine());

                for(i = 0; i < 11; i++){
                    soma = N * i;
                    Console.WriteLine(i + " X " + N + "=" + soma);
                }
            }

        }
    }
