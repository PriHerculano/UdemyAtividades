//Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro
//quadrado do terreno com duas casas decimais. Em seguida o programa deve mostrar o valor da área do terreno, bem commo o valor do preço do
//terreno, ambos com duas casas deicmais, conforme exemplo.

using System;
using System.Globalization;

namespace Atividade01{

    class program{

        static void Main(string[] args){

            double largura, comprimeto, precoQuadrado, area, precoTotal;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimeto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            area = largura*comprimeto;
            precoTotal = area*precoQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}