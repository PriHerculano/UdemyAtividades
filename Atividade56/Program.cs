//1071
//Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.
//ENTRADA: O arquivo de entrada contém dois valores inteiros.
//SAÍDA: O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre os valores fornecidos na entrada que deverá caber em um inteiro.

using System;

namespace Atividade56{

    class Program{

        static void Main(string[]args){

            int min, max, i, soma;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X<Y){
                min = X;
                max = Y;
            }

            else{
                min = Y;
                max = X;
            }

            soma = 0;
            for(i= min +1; i<max; i++){
                if(i%2 !=0){
                    soma = soma+i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}