//1020
//Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
//Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias,
//como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
//ENTRADA: O arquivo de entrada contém um valor inteiro.
//SAIDA: Imprima a saída conforme exemplo fornecido.

using System;
using System.Globalization;

namespace Atividade29{

    class Program{

        static void Main(string[] args){

            int dias = int.Parse(Console.ReadLine());

            int ano = dias/365;
            int restano = dias%365;

            int mes = restano/30;
            int restmes = restano%30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(restmes + " dia(s)");
        }
    }
}