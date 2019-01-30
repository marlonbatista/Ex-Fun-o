using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, bm;


            Console.Write("Informe o valor da base :");
            b = double.Parse(Console.ReadLine());

            Console.Write("\nInforme a Altura do Altura :");
            a = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor da base menor :");
            bm = double.Parse(Console.ReadLine());

            Volume(b,a,bm);

            Console.ReadKey();
        }
      
        static void Volume( double b, double a, double bm)
        {
            double area = ((b + bm) * a) / 2;

            Console.Write("\n O valor do trapêzio é : " + Math.Round(area, 2));
        }

    }
}
