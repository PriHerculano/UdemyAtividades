using System;
using System.Globalization;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            
            Console.WriteLine("TESTANDO " + x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("A paciente " + z + " Tem "+ y + " anos e é do sexo " + w);

            Console.ReadLine();
        }
    }
}