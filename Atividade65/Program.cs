﻿//1096
//Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
//I=1 J=7
//I=1 J=6
//I=1 J=5
//I=3 J=7
//I=3 J=6
//I=3 J=5
//...
//I=9 J=7
//I=9 J=6
//I=9 J=5

using System;

namespace Atividade65{

    class Program{

        static void Main(string[]args){

            for(int i = 1; i <= 9; i += 2){
                for (int j = 7; j >= 5; j--){
                    Console.WriteLine("I="+ i +" J="+j);
                }
            }

        }
    }
}