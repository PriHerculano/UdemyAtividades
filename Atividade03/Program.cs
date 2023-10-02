using System;

namespace Atividade03
{
    class Program
    {
        static void Main(String[] args)
        {

            double b, B, h, area1;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area1 = (b + B) / 2.0 * h;

            Console.WriteLine(area1);

            Console.WriteLine("Outra maneira de executar a mesma conta, porém ao invés de usar o Double seria utilizando o Float, é:");

            float e, E, a, area2;

            e = 6f;
            E = 8f;
            a = 5f;

            area2 = (e + E) / 2f * a;

            Console.WriteLine(area2);

            Console.WriteLine("Quando executarmos uma conta com número inteiro, mas queremos que o resultado seja quebrado,devemos fazer dessa maneira (serve para vice-versa também): ");

            int x, y;
            double resultado;

            x=5;
            y=2;

            resultado = (double) x/y;
            
            Console.WriteLine(resultado);

            Console.WriteLine("E quando for ao contrário? É só fazer dessa forma: ");

            double w;
            int z;

            w = 5.0;
            z = (int) w;

            Console.WriteLine(z);

            Console.ReadLine();

        }
    }
}