//OPERADORES DE ATRIBUIÇÃO CUMULATIVA
//Uma operadora de telefonia cobra R$50.00 por um plano básico que dá direito a 100 minutos de telefone. Cada minuto que exceder a franquia de 100 minutos custa R$2.00.
//Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o calor a ser pago.

using System;
using System.Globalization;

namespace Atividade35{

    class Program{

        static void Main(string[] args){

            int minutos = int.Parse(Console.ReadLine());

            double conta = 50.0;

            if(minutos>100){
                conta = conta + (minutos-100) * 2.0;
            }
            
            Console.WriteLine("Valor a pagar:R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
