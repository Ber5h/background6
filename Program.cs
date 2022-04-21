using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //у меня был смачный Try_Parse в одной из фоновой, я его найду, переделаю и сюда закину
        static Figura Figura_input()
        {
            Console.WriteLine("Введите 1, если хотите задать точку вставки фигуры вручную, введите что угодно, чтобы задать точку дефолтно");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());
                return new Figura(x, y);
            }
            else return new Figura();
        }
        static Triangle Triangle_input()
        {
            Console.WriteLine("Введите 1, если хотите задать параметры треугольника вручную, введите что угодно, чтобы задать треугольник дефолтно");
            if (Console.ReadLine()=="1")
            {
                Console.Write("Введите первую сторону: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите вторую сторону: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите угол между ними: ");
                double beta = double.Parse(Console.ReadLine());
                return new Triangle(a, b, beta);
            }
            else
            {
                return new Triangle();
            }
        }
        static Rectangle Rectangle_input()
        {
            Console.WriteLine("Введите 1, если хотите задать параметры прямоугольника вручную, введите что угодно, чтобы задать прямоугольник дефолтно");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Введите ширину: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Введите высоту: ");
                int height = int.Parse(Console.ReadLine());
                return new Rectangle(width, height);
            }
            else return new Rectangle();
        }
        static void Interface()
        {
            //здесь будут case
        }
        static void New_Figura(Figura obj1) 
        {
            Console.WriteLine("Введите 1, если хотите создать треугольник, введите что угодно, чтобы создать прямоугольник");
            if (Console.ReadLine()=="1")
            {
                obj1 = Triangle_input();
            }
            else
            {
                obj1 = Rectangle_input();
            }
        }
        static void Main(string[] args)
        {
            Figura obj1 = Figura_input();
            New_Figura(obj1);
            Console.WriteLine("{0}", obj1.X);
            Console.ReadKey();
        }
    }
    class Figura
    {
        protected int x;
        protected int y;
        public Figura()
        {
            x = 0;
            y = 0;
        }
        public Figura(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public class Triangle : Figura
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
    class Triangle : Figura
    {
        private int a;
        private int b;
        private double beta;
        public Triangle ()
            : base()
        {
            a = 5;
            b = 7;
            beta = 50;
        }
        public Triangle(int a, int b, double beta)
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
            return (a * b * Math.Sin(Rad(beta)) / 2);
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Сторона a: {0}", a);
            Console.WriteLine("Сторона b: {0}", b);
            Console.WriteLine("Угол между сторонами: {0}", beta);
        }
    }
    class Rectangle : Figura
    {
        private int width;
        private int height;
        public Rectangle()
            : base()
        {
            width = 4;
            height = 8;
        }
        public Rectangle(int width,int height)
            : base()
        {
            this.width = width;
            this.height = height;
        }
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public bool isQuare
        {
            get
            {
                return (width == height);
            }
        }
        public int Area()
        {
            return (width * height);
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Ширина: {0}", width);
            Console.WriteLine("Высота: {0}", height);
        }
    }
}
