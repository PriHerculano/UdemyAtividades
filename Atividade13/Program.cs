//1004
//Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   
//ENTRADA: O arquivo de entrada contém 2 valores inteiros.
//SAIDA: Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

using System;

namespace Atividade13{

    class Program{

        static void Main (string[] args){

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int prod;

            prod = n1*n2;

            Console.WriteLine("PROD = " + prod);
        }
    }
}