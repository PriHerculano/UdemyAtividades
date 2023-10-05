//1010
//Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada
//peça 2. Após, calcule e mostre o valor a ser pago.
//ENTRADA: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.
//SAIDA: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$".
//O valor deverá ser apresentado com 2 casas após o ponto.

using System;
using System.Globalization;

namespace Atividade19{

    class Program{

        static void Main(string[] args){

            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();

            string[] vet1 = p1.Split(' ');
            int codPeca1 = int.Parse(vet1[0]);
            int numPeca1 = int.Parse(vet1[1]);
            double valUnit1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = p2.Split(' ');
            int codPeca2 = int.Parse(vet2[0]);
            int numPeca2 = int.Parse(vet2[1]);
            double valUnit2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valFinal = (numPeca1*valUnit1) + (numPeca2*valUnit2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}