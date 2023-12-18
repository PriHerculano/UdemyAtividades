//1072
//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.
//ENTRADA: A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
//Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
//SAIDA: Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.

using System;

namespace Atividade58
{

    class Program
    {

        static void Main(string[] args)
        {

            int i, contIn, contOut;
            int n = int.Parse(Console.ReadLine());

            contIn = 0;
            contOut = 0;

            for (i = 0; i < n; i++){
                int x = int.Parse(Console.ReadLine());
                    if (x <= 20 && x >= 10){
                        contIn++;
                    }

                else{
                    contOut++;
                    }
            }
             Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}