﻿namespace Atividade04
{
    class Program{
        static void Main(String[] args){
            
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

// OUTRA MANEIRA: APAGAR (string s = Console.ReadLine();) 
// E transformar a linha debaixo em (string[] vet = Console.ReadLine().Split(' ');      
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}