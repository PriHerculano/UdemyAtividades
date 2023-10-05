//1008
//Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir,
//mostre o número e o salário do funcionário, com duas casas decimais.
//ENTRADA: O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que
//o funcionário recebe por hora trabalhada, respectivamente.
//SAIDA: Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário,
//também deve haver um espaço em branco após o $.

using System;
using System.Globalization;

namespace Atividade17{

    class Program{

        static void Main(string[] args){

            int nFuncionario = int.Parse(Console.ReadLine());
            int hTrab = int.Parse(Console.ReadLine());
            double valorHorasTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = hTrab*valorHorasTrab;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}