//Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final que o aluno obteve no ano
//juntamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos os valores devem ter uma casa decimal.

using System;
using System.Globalization;

namespace Atividade32{

    class Program{

        static void Main(string[] args){

            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = n1+n2;

                Console.WriteLine("NOTA FINAL = " + soma.ToString("F1",CultureInfo.InvariantCulture));
                
            if (soma<60.00){
                Console.WriteLine("REPROVADO");
            }
        }
    }
}