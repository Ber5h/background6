using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Figura
    {
        private int x;
        private int y;
        public  Figura ()
        {
            x = 0;
            y = 0;
        }
        public Figura (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public class Triangle:Figura
        {
            public int GetX()
            {
                return x;
            }
            public int GetY()
            {
                return y;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("x фигуры: {0}", x);
            Console.WriteLine("y фигуры: {0}", y);
        }
    }
    class Triangle:Figura
    {
        private int a;
        private int b;
        private double beta;
        public Triangle(int a, int b,double beta)
            : base()
        {
            this.a = a;
            this.b = b;
            this.beta = beta;
        }
        public int A
        {
            get
            {
                return a;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
        }
        public double Beta
        {
            get
            {
                return beta;
            }
        }
        public double C
        {
            get
            {
                return (double)a + (double)b - 2 * Math.Cos(Rad(beta)) * a * b;
            }
        }
        private static double Rad(double beta)
        {
            return (Math.PI / 180 * beta);
        }
        public bool isRavnobedr
        {
            get
            {
                return (a == b ^ (double)a == C ^ (double)b == C);
            }
        }
        public double Area()
        {
            return (a * b * Math.Sin(Rad(beta))/2);
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Сторона a: {0}", a);
            Console.WriteLine("Сторона b: {0}", b);
            Console.WriteLine("Угол между сторонами: {0}", beta);
        }
    }
}
