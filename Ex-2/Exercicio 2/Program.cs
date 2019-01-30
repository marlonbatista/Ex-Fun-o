using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double raio, alt;

            Ra();
            raio = double.Parse(Console.ReadLine());

            A();
            alt = double.Parse(Console.ReadLine());


            Volume( raio, alt);

            Console.ReadKey();
        }
        static void Ra()
        {
            Console.Write("\nInforme o valor do Raio :");
        }
        static void A()
        {
            Console.Write("\nInforme o valor da Altura :");
        }
        static void Volume( double raio, double alt)
        {
            double vol = (Math.PI * (Math.Pow(raio,2)) * alt);

            Console.Write("\n O volume do triângulo é :" + Math.Round(vol,3));
        }
    }
}
