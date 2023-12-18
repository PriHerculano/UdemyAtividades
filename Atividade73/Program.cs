//Utilizando o foreach
//Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes lidos.

using System;

namespace Atividade73{

    class Program{

        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];

            for(int i = 0; i<n; i++){
                nome[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            //for(int i = 0; i<n; i++){
                //Console.WriteLine(vet[i])
            foreach (string elemento in nome){
                Console.WriteLine(elemento);
            }
        }
    }
}