using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    class Triad
    {
        private int _a;
        private int _b;
        private int _c;

        public int A {
            get { return _a; }
            set { _a = value; } 
        }
        public int C
        {
            get { return _c; }
            set { _c = value; }
        }
        public int B
        {
            get { return _b; }
            set { _b = value; }
        }
        public Triad()
        { }
        public Triad(int a, int b, int c) 
        {
            _a= a;
            _b= b;  
            _c= c;
        }
        public void Read(int a, int b, int c)
        {
            _a= a;
            _b= b;
            _c= c;
        }
        public void Sum()
        { 
            double sum = _a + _b + _c;
            Console.WriteLine($"Сумма равна{sum}");
        }
        public void Display()
        {
            Console.WriteLine($"А = {_a} , Б = {_b} , В = {_c}");        
        }
        
    }
}
