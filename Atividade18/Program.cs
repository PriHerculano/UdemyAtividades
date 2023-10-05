//1009
//Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão
//sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.
//ENTRADA: O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário fixo do vendedor
//e montante total das vendas efetuadas por este vendedor, respectivamente.
//SAIDA: Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

using System;
using System.Globalization;

namespace Atividade18{

    class Program{

        static void Main (string[] args){

            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double porcentagem = (totalVendas*15)/100;
            double salFinal = salario + porcentagem;

            Console.WriteLine("TOTAL = R$ " + salFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}