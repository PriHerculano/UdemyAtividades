﻿//1117
//Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas 
//(uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.
//ENTRADA: A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.
//SAÍDA: Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
//Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

using System;
using System.Globalization;

namespace Atividade50
{

    class Program
    {

        static void Main(string[] args)
        {

            int cont;
            double soma, media, nota;

            cont = 0;
            soma = 0.0;
            nota = 0;

            while (cont < 2)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    soma += nota;
                    cont++;
                }
            }
                media = soma / cont;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}