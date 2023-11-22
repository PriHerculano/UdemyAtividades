//Estrutura repetitiva "enquanto"
//Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade
//negativa. Calcular e imprimir a idade média deste grupo de indivíduos. Se for entrado um valor negativo e na primeira vez, mostrar a mensagem "impossível calcular".

using System;
using System.Globalization;

namespace Atividade47
{

    class Program
    {

        static void Main(string[] args)
        {

            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cont = 0;
            soma = 0.0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }

            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}