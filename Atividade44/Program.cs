//1048
//A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
//Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
//ENTRADA: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.
//SAÍDA: Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e o percentual de reajuste ganho.

using System;
using System.Globalization;

namespace Atividade44
{

    class Program
    {

        static void Main(string[] args)
        {

            double salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;

            if (salario <= 400.00)
            {
                percentual = 15.0;
            }

            else if (salario <= 800.00)
            {
                percentual = 12.0;
            }

            else if (salario <= 1200.00)
            {
                percentual = 10.0;
            }

            else if (salario <= 2000.00)
            {
                percentual = 7.0;
            }

            else
            {
                percentual = 4.0;
            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}