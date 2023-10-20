//ESTRUTURA CONDICIONAL
//Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três lidos. Em caso de empate, mostrar apenas uma vez.

using System;
using System.Globalization;

namespace Atividade34{

    class Program{

        static void Main(string[] args){

            string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);
            int z = int.Parse(v[2]);

            if (x < y && x < z){
            Console.WriteLine("MENOR = " + x);
            }

            else if(y < z){
                Console.WriteLine("MENOR = " + y);
                }

                else{
                    Console.WriteLine("MENOR = " + z);
                }
        }
    }
}