//1113
//Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma mensagem que indique se estes valores foram digitados em ordem crescente ou 
//decrescente.
//ENTRADA: contém vários casos de teste. Cada caso contém dois valores inteiros X e Y. A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.
//SAÍDA: Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente, caso contrário imprima a mensagem “Decrescente”.

using System;
using System.Globalization;

namespace Atividade46{

    class Program{

        static void Main(string[] args){

            string[] v = Console.ReadLine().Split(' ');
            int x = int.Parse(v[0]);
            int y = int.Parse(v[1]);

            while(x != y){
                if(x > y){
                    Console.WriteLine("Descrescente");
                }

                else{
                    Console.WriteLine("Crescente");
                }

                v = Console.ReadLine().Split(' ');
                x = int.Parse(v[0]);
                y = int.Parse(v[1]);

            }
        }
    }
}

//SOLUÇÃO ESPERADA:
//             string[] valores = Console.ReadLine().Split(' ');
//             int X = int.Parse(valores[0]);
//             int Y = int.Parse(valores[1]);

//             while (X != Y) {
//                 if (X < Y) {
//                     Console.WriteLine("Crescente");
//                 }
//                 else {
//                     Console.WriteLine("Decrescente");
//                 }
//                 valores = Console.ReadLine().Split(' ');
//                 X = int.Parse(valores[0]);
//                 Y = int.Parse(valores[1]);