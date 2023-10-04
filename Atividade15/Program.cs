//1006
//Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
//ENTRADA: O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
//SAIDA: Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade.

using System;
using System.Globalization;

namespace Atividade15{

    class Program{

        static void Main (String[] args){

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media;

            media = ((n1*2)+(n2*3)+(n3*5))/10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}