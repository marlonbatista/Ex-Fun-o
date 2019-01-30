using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            Console.Write("Informe a senha :");
            senha = Console.ReadLine();

            Password(senha);//Chamando a senha de parametro para Password

            Console.ReadKey();
        }
        static void Password(string s)//"s" Passa a ser a a variavel dentro de Password
        {
           

            if(s == "123")
            {
                Console.Write("ACESSO PERMITIDO!");
            }
            else
            {
                Console.Write("ACESSO NEGADO!");
            }
                
        }
    }
}
