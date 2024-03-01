using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {

            int votostotal, votosBrancos, votosnulos, votosValidos;


            Console.WriteLine("Total de votos");
            votostotal = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos Brancos");
            votosBrancos  = int.Parse(Console.ReadLine());


            Console.WriteLine("Votos nulos");
             votosnulos = int.Parse(Console.ReadLine());


            Console.WriteLine("Votos VAlidos");
            votosValidos = int.Parse(Console.ReadLine());

            double porcentagemb = (100 * votosBrancos) / votostotal;
            double porcentagmn = (100 * votosnulos) / votostotal;
            double porcentagemv = (100 * votosValidos) / votostotal;


            Console.WriteLine( "Porcentagem votos Brancos:" + porcentagemb);
            Console.WriteLine("Porcentagem votos Nulos:" + porcentagmn);
            Console.WriteLine("Porcentagem votos Validos:" + porcentagemv);
            Console.ReadLine();
             

        }
    }
}
