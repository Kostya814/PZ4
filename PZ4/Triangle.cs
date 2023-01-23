using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    class Triangle:Triad
    {
        public Triangle(double a, double b , double c)
        {
            base.Read(a,b,c);
            base.Display();
        }
        public void Plosh()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine($"Площадь треугольника равна {Math.Round(S,2)}");
        }
        public void Do()
        {
            double alpha = Math.Acos((Math.Pow(A, 2) - Math.Pow(B, 2) + Math.Pow(C, 2)) / 2 * A * C); 
            double beta = Math.Acos((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) / 2 * A * B); 
            double gamma = Math.Acos((-Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2)) / 2 * C * B);
            Console.WriteLine($"{alpha} {beta} {gamma}");
        }
    }
}
