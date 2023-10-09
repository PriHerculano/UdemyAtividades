//1019
//Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.
//ENTRADA: O arquivo de entrada contém um valor inteiro N.
//SAIDA: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

using System;
using System.Globalization;

namespace Atividade28{

    class Program{

        static void Main (string[] args){

            int seg = int.Parse(Console.ReadLine());

            int hora = seg/3600;
            int resthora = seg%3600;

            int min = resthora/60;
            int restmin = resthora%60;

            Console.WriteLine(hora+":"+min+":"+restmin);
        }
    }
}