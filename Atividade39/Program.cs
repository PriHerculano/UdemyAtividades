//1038
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
//ENTRADA: O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
//SAIDA: CO arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

using System;
using System.Globalization;

namespace Atividade39{

    class Program{

        static void Main(string[] args){

            string[] v = Console.ReadLine().Split(' ');
            int codigo = int.Parse(v[0]);
            float quantidade = int.Parse(v[1]);

            double total = 0.0;

        switch (codigo)
        {
            case 1:
                total = quantidade * 4.00;
                break;
            case 2:
                total = quantidade * 4.50;
                break;
            case 3:
                total = quantidade * 5.00;
                break;
            case 4:
                total = quantidade * 2.00;
                break;
            case 5:
                total = quantidade * 1.50;
                break;
            default:
                Console.WriteLine("Código de item inválido.");
                return;
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}