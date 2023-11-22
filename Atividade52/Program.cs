//1154
//Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
//ENTRADA: A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.
//SAIDA: A saída contém um valor correspondente à média de idade dos indivíduos.
//A média deve ser impressa com dois dígitos após o ponto decimal.

using System;
using System.Globalization;

namespace Ativiidade52
{

    class Program
    {

        static void Main(string[] args)
        {

            int cont, idade;
            float media, soma;

            idade = int.Parse(Console.ReadLine());
            soma = 0;
            cont = 0;

            while (idade >= 0)
            {
                soma += idade;
                cont++;
                idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = soma / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}