﻿//1017
//Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você
//o auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h).
//Assim, pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.
//ENTRADA: O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo é a velocidade média durante a mesma (em km/h).
//SAIDA: Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal

using System;
using System.Globalization;

namespace Atividade26{

    class Program{

        static void Main(string[] args){

            double tempoGasto = double.Parse(Console.ReadLine());
            double velocMed = double.Parse(Console.ReadLine());

            double qntdLitros = (tempoGasto*velocMed)/12;

            Console.WriteLine(qntdLitros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

//carro faz 12 km/L
//tempo viagem em horas
//velocidade media durante a mesma (km/h)