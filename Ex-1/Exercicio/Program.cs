using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h;

            Entrada();//Primeira Função
            b = double.Parse(Console.ReadLine());

            Altura();//Segunda Função
            h = double.Parse(Console.ReadLine());

            Resu(b, h);
            Console.ReadKey();

           
        }
        static void Entrada()
        {
            Console.Write("\nInforme a Base : ");

        }
        static void Altura()
        {
            Console.Write("\nInforme a Altura : ");
        }
        static void Resu(double b, double h)
        {
             double Resu  = b * h;

            Console.Write("\nA área do triângulo é :" + Resu);
        }

        
    }
}
