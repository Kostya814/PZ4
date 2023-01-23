using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    class Triangle:Triad
    {
        public Triangle(int a, int b , int c)
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
            int pi = 3;
            double A1 = ((B * B + C * C - A * A) / (2 * B * C));
            int A2 = (int)Math.Acos(A1);
            int A3 = (int)B * (int)Math.Sin(A2) / A;
            int B1 = (int)Math.Asin(A3) * 180 / pi;
            int B2 = A2 * 180 / pi;
            int C1 = 180 - A2 - B1;


            Console.WriteLine($" {A2}, {B1}, {C1}");

            Console.ReadLine();
        }
    }
}
