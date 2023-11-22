﻿//1115
//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. 
//O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
//ENTRADA: A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.
//SAÍDA: Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.

using System;

namespace Atividade49
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] v = Console.ReadLine().Split(' ');
            int X = int.Parse(v[0]);
            int Y = int.Parse(v[1]);

            while (X != 0 && Y != 0)
            {

                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }

                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }

                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }

                else
                {
                    Console.WriteLine("quarto");
                }
                v = Console.ReadLine().Split(' ');
                X = int.Parse(v[0]);
                Y = int.Parse(v[1]);
            }
        }

    }
}