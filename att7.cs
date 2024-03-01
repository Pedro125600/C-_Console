using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att7
{
    class Program
    {
        static void Main(string[] args)
        {
           double total, gorjeta ,despesas;

            Console.WriteLine("Valor despesas");
            despesas = double.Parse(Console.ReadLine());


            Console.WriteLine("Porcentagem gorgeta");
            gorjeta = double.Parse(Console.ReadLine());

            gorjeta = (despesas / 100) * gorjeta;

            Console.WriteLine("Valor gorgeta:" + gorjeta);


            total = gorjeta + despesas;
            Console.WriteLine("Valor total:" + total);


            Console.ReadLine();

        }
    }
}
