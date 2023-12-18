//1074
//Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par
//(EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN NULL), pois por definição zero é par, 
//seu programa deverá imprimir apenas NULL.
//ENTRADA: A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
//SAIDA: Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo abaixo. Todas as letras deverão ser maiúsculas e sempre deverá haver um espaço entre duas palavras
//impressas na mesma linha.

using System;

namespace Atividade60{

    class Program{

        static void Main(string [] args){

            int i;
            int n = int.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++){
                int x = int.Parse(Console.ReadLine());
                if (x>0 && x%2!=0){
                    Console.WriteLine("ODD POSITIVE");
                }
                if (x<0 && x%2!=0){
                    Console.WriteLine("ODD NEGATIVE");
                }
                if (x>0 && x%2==0){
                    Console.WriteLine("EVEN POSITIVE");
                }
                if (x<0 && x%2==0){
                    Console.WriteLine("EVEN NEGATIVE");
                }
                if(x==0){
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}