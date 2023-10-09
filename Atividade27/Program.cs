//1018
//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
//As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
//ENTRADA: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).
//SAÍDA: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.

using System;
using System.Globalization;

namespace Atividade27{

    class Program{

        static void Main(string[] args){

            int valor = int.Parse(Console.ReadLine());

            int qntd = valor/100;
            int n1 = valor%100;

            int qntd1 = n1/50;
            int n2 = n1%50;

            int qntd2 = n2/20;
            int n3 = n2%20;

            int qntd3 = n3/10;
            int n4 = n3%10;

            int qntd4 = n4/5;
            int n5 = n4%5;

            int qntd5 = n5/2;
            int n6 = n5%2;

            int qntd6 = n6/1;
            int n7 = n6%1;

            Console.WriteLine(valor);
            Console.WriteLine(qntd + " nota(s) de R$ 100,00");
            Console.WriteLine(qntd1 + " nota(s) de R$ 50,00");
            Console.WriteLine(qntd2 + " nota(s) de R$ 20,00");
            Console.WriteLine(qntd3 + " nota(s) de R$ 10,00");
            Console.WriteLine(qntd4 + " nota(s) de R$ 5,00");
            Console.WriteLine(qntd5 + " nota(s) de R$ 2,00");
            Console.WriteLine(qntd6 + " nota(s) de R$ 1,00");

        }
    }
    
}