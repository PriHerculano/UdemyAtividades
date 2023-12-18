//1075
//Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.
//ENTRADA: A entrada contém um valor inteiro N (N < 10000).
//SAIDA: Imprima todos valores que quando divididos por N dão resto = 2, um por linha.

using System;

namespace Atividade61{

    class Program{

        static void Main(string [] args){

            int i, result;
            int n = int.Parse(Console.ReadLine());

            for(i=1; i<=10000; i++){
                if(i%n==2)
                Console.WriteLine(i);
            }
        }
    }
}