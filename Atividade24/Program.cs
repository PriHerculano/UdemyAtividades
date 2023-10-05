//1015
//Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais
//após a vírgula, segundo a fórmula:
//Distancia = √(x2 - x1)² + (y2 - y1)²
//ENTRADA: O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto
//flutuante x2 y2.
//SAIDA: Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal.

using System;
using System.Globalization;

namespace Atividade24{

    class Program{

        static void Main(string[] args){

            string[] vet1 = Console.ReadLine().Split(' ');
            float x1 = float.Parse(vet1[0]);
            float y1 = float.Parse(vet1[1]);

            string[] vet2 = Console.ReadLine().Split(' ');
            float x2 = float.Parse(vet2[0]);
            float y2 = float.Parse(vet2[1]);

            double distancia = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}