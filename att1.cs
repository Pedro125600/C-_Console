using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o lado do quadrado:");
            double lado = double.Parse(Console.ReadLine());

            double perimetro = 4 * lado;
            double area = lado * lado;
            double diagonal = Math.Sqrt(2) * lado;

            Console.WriteLine("Perímetro do quadrado:" + perimetro);
            Console.WriteLine("Área do quadrado:" + area);
            Console.WriteLine("Diagonal do quadrado:" + diagonal);

            Console.ReadLine();
        }
    }
}
