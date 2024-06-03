using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp125
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        double Soma;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return Altura + Altura + Largura + Largura;
        }

        public double Diagonal()
        {
         Soma = Area() * 2 + Largura * 2;
            return Math.Sqrt(Soma);
        }
        public override string ToString()
        {
            return 
                   "Area = "
                   + Area().ToString("f2") + " Perimetro = "
                   + Perimetro().ToString("f2") + " Diagonal = "
                   + Diagonal().ToString("f2");

        }
    }
    
    
}
