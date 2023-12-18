﻿//1073
//Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.
//ENTRADA: A entrada contém um valor inteiro N (5 < N < 2000).
//SAÍDA: Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.
//ATENÇÃO: Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o que ocasionará resposta errada. Neste caso, configure a precisão 
//adequadamente para que isso não ocorra.

using System;

namespace Atividade59{

    class Program{

        static void Main(string[] args){

            int i, result;
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + result);
                }
            }
        }
    }
}