﻿//1067
//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
//ENTRADA: O arquivo de entrada contém 1 valor inteiro qualquer.
//SAÍDA: Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.

using System;

namespace Atividade57
{

    class Program
    {

        static void Main(string[] args)
        {

            int i;
            int x = int.Parse(Console.ReadLine());

            for (i = 1; i <= x; i++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }

            }
        }
    }
}