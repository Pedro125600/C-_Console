using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a base do retângulo:");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            double perimetro = 2 * (baseRetangulo + alturaRetangulo);
            double area = baseRetangulo * alturaRetangulo;
            double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

            Console.WriteLine("Perímetro do retângulo: " + perimetro);
            Console.WriteLine("Área do retângulo: " + area);
            Console.WriteLine("Diagonal do retângulo: " + diagonal);

            Console.ReadLine();
        }
    }
}
