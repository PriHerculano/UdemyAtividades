using System.Globalization;
//1094
//Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável.
//Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada.
//Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados,
//o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento.
//ENTRADA: A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um inteiro Quantia 
//(1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).
//SAIDA: Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o 
//percentual deve ser apresentado com dois dígitos após o ponto.

using System;

namespace Atividade64{

    class Program{

        static void Main(string[] args){

            int i, total, sapo, rato, coelho;
            int n = int.Parse(Console.ReadLine());

            sapo=0;
            rato=0;
            coelho=0;

            for (i=0; i<n; i++){
                string[]v=Console.ReadLine().Split(' ');
                int quantia = int.Parse(v[0]);
                char tipo = char.Parse(v[1]);

                if (tipo == 'S'){
                    sapo = sapo + quantia;
                }
                else if (tipo == 'R'){
                    rato = rato + quantia;
                }
                else{
                    coelho = coelho + quantia;
                }
            }
                total = sapo + rato + coelho;
                double porcSapo = (double)sapo/total * 100;
                double porcRato = (double)rato/total * 100;
                double porcCoelho = (double)coelho/total * 100;

                Console.WriteLine("Total: " + total + " cobaias");
                Console.WriteLine("Total de coelhos: " + coelho);
                Console.WriteLine("Total de ratos: " + rato);
                Console.WriteLine("Total de sapos: " + sapo);
                Console.WriteLine("Percentual de coelhos: " + porcCoelho.ToString("F2") + " %");
                Console.WriteLine("Percentual de ratos: " + porcRato.ToString("F2") + " %");
                Console.WriteLine("Percentual de sapos: " + porcSapo.ToString("F2") + " %");

        }
    }
}