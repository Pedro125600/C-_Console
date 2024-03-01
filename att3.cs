using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att3
{
    class Program
    {
        static void Main(string[] args)
        {


            double numerador, demoninador;
            Console.WriteLine("Escreva o numerador");

            numerador = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o demoninador");
            demoninador = double.Parse(Console.ReadLine());

            double resultado = numerador / demoninador;

            Console.WriteLine("O resultado da conta e :" + resultado);

            Console.ReadLine();



        }
    }
}
