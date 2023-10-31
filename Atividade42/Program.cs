//1044
//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
//ENTRADA: A entrada contém valores inteiros.
//SAÍDA: A saída deve conter uma das mensagens conforme descrito acima.

using System;
using System.Globalization;

namespace Atividade41{
    
    class Program{

        static void Main(string[] args){

            string[] v = Console.ReadLine().Split(' ');
            int A = int.Parse(v[0]);
            int B = int.Parse(v[1]);

            if (A % B == 0 || B % A == 0){
                Console.WriteLine("Sao Multiplos");
            }

            else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}