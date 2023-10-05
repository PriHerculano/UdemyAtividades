//1012
//Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
//ENTRADA: O arquivo de entrada contém três valores com um dígito após o ponto decimal.
//SAIDA: O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois 
//pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

using System;
using System.Globalization;

namespace Atividade21{

    class Program{

        static void Main(string[] args){

            string n = Console.ReadLine();

            string[] v = n.Split(' ');
            double A = double.Parse(v[0]);
            double B = double.Parse(v[1]);
            double C = double.Parse(v[2]);

            double triangulo = (A*C)/2;
            double circulo = 3.14159*Math.Pow(C,2);
            double trapezio = (A+B)*C/2;
            double quadrado = B*B;
            double retangulo = A*B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}