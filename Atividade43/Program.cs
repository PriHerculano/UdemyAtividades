//1046
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de
//1 hora e máxima de 24 horas.
//ENTRADA: A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
//SAÍDA: Apresente a duração do jogo.

using System;
using System.Globalization;

namespace Atividade43
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] v = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(v[0]);
            int horaFim = int.Parse(v[1]);

            int duracao;
            
            if (horaFim > horaInicio)
            {
                duracao = horaFim - horaInicio;
            }

            else
            {
                duracao = 24 - horaInicio + horaFim;
            }
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}