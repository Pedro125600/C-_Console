using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att6
{
    class Program
    {
        static void Main(string[] args)
        {

            double varA, varB , varc;

            Console.WriteLine("Valor de A");
            varA = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de B");
            varB = double.Parse(Console.ReadLine());


            varc = varA;
            varA = varB;
            varB = varc;

            Console.WriteLine("Variavel A:" + varA);
            Console.WriteLine("Variavel B:" + varB);
            Console.ReadLine();
        }
    }
}
