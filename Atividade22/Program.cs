﻿//1013
//Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
//MaiorAB=(a+b+abs(a-b))/2
//Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
//ENTRADA: O arquivo de entrada contém três valores inteiros.
//SAIDA: Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

using System;
using System.Globalization;

namespace Atividade22{
    
    class Program{

        static void Main(string[] args){

            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int maiorAB = ( a+ b + Math.Abs(a - b))/2;

            int maior = (maiorAB + c + Math.Abs(maiorAB - c))/2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}