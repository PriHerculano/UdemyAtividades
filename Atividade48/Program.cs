//1114
//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". 
//Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 
//ENTRADA: A entrada é composta por vários casos de testes contendo valores inteiros.
//SAÍDA: Para cada valor lido mostre a mensagem correspondente à descrição do problema.

using System;

namespace Atividade48
{

    class Program
    {

        static void Main(string[] args)
        {

            int senha, cont;

            senha = int.Parse(Console.ReadLine());

            senha = 0;
            cont = 0;


            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                cont++;
                senha = int.Parse(Console.ReadLine());
            }

            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
            }
        }
    }
}