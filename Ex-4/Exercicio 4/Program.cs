using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)//Programa Principal
        {
            //Declaração de Variaveis 
            double larg, alt, comp;

            //Entrada de Dados
            Console.Write("Informe a Largura :");
            larg = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura :");
            alt = double.Parse(Console.ReadLine());

            Console.Write("Informe o comprimento :");
            comp = double.Parse(Console.ReadLine());
            //Função
            Volume(larg, alt, comp);

            Console.ReadKey();
        }
        static void Volume( double larg, double alt, double comp)//Função em Execussão
        {
            double v = comp * larg * alt;//"v" de volume

            Console.Write("O volume da caixa é :" + Math.Round(v,3));//Math.Roud controla o número de casas após a virgula.
        }
    }
}
