//1079
//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
//Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
//ENTRADA: O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.
//SAÍDA: Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.

using System;
using System.Globalization;

namespace Atividade62{

    class Program{

        static void Main(string[] args){

            int n, i;
            double resp;
            n = int.Parse(Console.ReadLine());

            for(i = 1; i <= n; i++){
            string[]v=Console.ReadLine().Split(' ');
            double A = double.Parse(v[0], CultureInfo.InvariantCulture);
            double B = double.Parse(v[1], CultureInfo.InvariantCulture);
            double C = double.Parse(v[2], CultureInfo.InvariantCulture);
            resp = (A*2.0 + B*3.0 + C*5.0)/10.0;
            Console.WriteLine(resp.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}