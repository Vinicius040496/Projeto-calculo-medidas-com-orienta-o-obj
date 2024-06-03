using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo Medidas = new Retangulo();


          
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Medidas.Altura = double.Parse(Console.ReadLine());
            Medidas.Largura = double.Parse(Console.ReadLine());
            Medidas.Area();
            Medidas.Perimetro();
            Medidas.Diagonal();
            Medidas.Perimetro();
            Console.WriteLine(Medidas);
            Console.ReadLine();


        }
    }
}
