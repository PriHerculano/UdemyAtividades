
//1003
//Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.
//ENTRADA: O arquivo de entrada contém 2 valores inteiros.
//SAIDA: Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido pelo valor correspondente à soma de A e B.

using System;

namespace Atividade12{

    class Program{

        static void Main (string[] args){

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int soma;

            soma = A + B;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}