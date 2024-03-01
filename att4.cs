using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é:" + celsius);


            Console.ReadLine();
        }
    }


}

