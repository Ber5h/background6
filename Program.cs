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
        static public uint Try_Parse(byte option)
        {
            uint x;
            bool a = UInt32.TryParse(Console.ReadLine(), out x);
            if (!a)
            {
                Console.Write("Введено нечисловое значение. Повторите ввод: ");
                return Try_Parse(option);
            }
            if ((option == 0 & x > 3) ^ (option == 1 & x > 7) ^ x == 0) //я конченый
            {
                Console.Write("Введено не то число. Повторите ввод: ");
                return Try_Parse(0);
            }
            return x;
        }
        static public int Try_Parse()
        {
            int x;
            bool a = Int32.TryParse(Console.ReadLine(), out x);
            if (!a)
            {
                Console.Write("Введено нечисловое значение. Повторите ввод: ");
                return Try_Parse();
            }
            return x;
        }
        static public double Try_Parse_Double(byte option)
        {
            double x;
            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Введено нечисловое значение. Повторите ввод: ");
                return Try_Parse_Double(option);
            }
            if (option == 0 & (x <= 0 | x >= 180)) //угол (мб просто еще что-нибудь придется вводить...)
            {
                Console.Write("Введенное число должно быть параметром угла в градусах (от 0 до 180 невключительно). Повторите ввод: ");
                return Try_Parse_Double(0);
            }
            return x;
        }
        static Figura Figura_input()
        {
            Console.WriteLine("Введите 1, если хотите задать точку вставки фигуры вручную, введите что угодно, чтобы задать точку дефолтно");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Введите x: ");
                int x = Try_Parse();
                Console.Write("Введите y: ");
                int y = Try_Parse();
                return new Figura(x, y);
            }
            else return new Figura();
        }
        static Triangle Triangle_input(int x, int y)
        {
            Console.WriteLine("Введите 1, если хотите задать параметры треугольника вручную, введите что угодно, чтобы задать треугольник дефолтно");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Введите первую сторону: ");
                int a = (int)Try_Parse(2);
                Console.Write("Введите вторую сторону: ");
                int b = (int)Try_Parse(2);
                Console.Write("Введите угол между ними: ");
                double beta = Try_Parse_Double(0);
                return new Triangle(a, b, beta, x, y);
            }
            else
            {
                return new Triangle(x, y);
            }
        }
        static Rectangle Rectangle_input(int x, int y)
        {
            Console.WriteLine("Введите 1, если хотите задать параметры прямоугольника вручную, введите что угодно, чтобы задать прямоугольник дефолтно");
            if (Console.ReadLine() == "1")
            {
                Console.Write("Введите ширину: ");
                int width = (int)Try_Parse(2);
                Console.Write("Введите высоту: ");
                int height = (int)Try_Parse(2);
                return new Rectangle(width, height, x, y);
            }
            else return new Rectangle(x, y);
        }
        //static void Interface(Figura[] mas)
        //{
        //    Console.WriteLine("Нажмите 1, чтобы работать с заданной точкой\nНажмите 2, чтобы работать с " +
        //        "заданным треугольником\nНажмите что угодно, чтобы работать с заданным прямоугольником");
        //    string a = Console.ReadLine();
        //    switch (a)
        //    {
        //        case "1":
        //            Interface(mas, 0);
        //            break;
        //        case "2":
        //            Interface(mas, 1);
        //            break;
        //        default:
        //            Interface(mas, 2);
        //            break;
        //    }
        //}
        //static void Interface(Figura[] mas, byte option)
        //{
        //    switch (option)
        //    {
        //        case 0:
        //            Console.WriteLine("Программа может\n1)Вывести x и y точки\n2)Поменять x точки\n3)Поменять y " +
        //                "точки");
        //            Interface_Figura(mas, (byte)Try_Parse(0));
        //            break;
        //        case 1:
        //            Console.WriteLine("Программа может\n1)Вывести параметры треугольника\n2)Вывести третью" +
        //                " сторону треугольника\n3)Проверить, является ли треугольник равнобедренным\n4)" +
        //                "Посчитать площадь треугольника\n5)Поменять x точки вставки" +
        //                "\n5)Поменять y точки вставки\n6)Вывести это сообщение еще раз\n7)Перейти к работе над другим объектом");
        //            Interface_Triangle((Triangle)mas[1], (byte)Try_Parse(1));
        //            break;
        //        case 2:
        //            Console.WriteLine("Программа может\n1)Вывести параметры прямоугольника\n2)Проверить," +
        //                "является ли прямоугольник квадратом\n3)Вывести площадь прямоугольника\n4)Поменять x точки вставки" +
        //                "\n5)Поменять y точки втавки\n6)Вывести это сообщение еще раз\n7)Перейти к работе над другим объектом");
        //            break;
        //    }
        //}
        //static void Interface_Figura(Figura[] mas, byte option)
        //{
        //    //АААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА
        //    //Анна Олеговна, не ставьте 2
        //    switch (option)
        //    {
        //        case 1:
        //            mas[0].Show();
        //            Interface_Figura(mas, (byte)Try_Parse(1));
        //            break;
        //        case 2:
        //            Console.Write("Введите x: ");
        //            mas[0].X = Try_Parse();
        //            break;
        //        case 3:
        //            Console.Write("Введите y: ");
        //            mas[0].Y = Try_Parse();
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //static void Interface_Triangle(Triangle obj1, byte option)
        //{
        //    switch (option)
        //    {
        //        case 1:
        //            obj1.Show();
        //            break;
        //        case 2:
        //            Console.WriteLine("Третья сторона: {0:f2}", obj1.C);
        //            break;
        //    }
        //}
        static void New_Figura(Figura obj1)
        {
            Console.WriteLine("Введите 1, если хотите создать треугольник, введите что угодно, чтобы создать прямоугольник");
            if (Console.ReadLine() == "1")
            {
                obj1 = Triangle_input(obj1.X, obj1.Y);
            }
            else
            {
                obj1 = Rectangle_input(obj1.X, obj1.Y);
            }
        }
        static Figura New_Figura(byte option, Figura obj1)
        {
            if (option == 0) return Triangle_input(obj1.X, obj1.Y);
            else return Rectangle_input(obj1.X, obj1.Y);
        }
        static Figura Create_Figura(byte option)
        {
            Figura obj1 = Figura_input();
            if (option > 0) New_Figura(obj1);
            return obj1;
        }
        static void IsRavnobedr(Triangle obj1)
        {
            if (obj1.isRavnobedr) Console.WriteLine("Треугольник равнобедренный");
            else Console.WriteLine("Треугольник не является равнобедренным");
        }
        static void Area_Triangle(Triangle obj1)
        {
            Console.WriteLine("Площадь треугольника: {0:f2}", obj1.Area());
        }
        static void Area_Rectangle (Rectangle obj1)
        {
            Console.WriteLine("Площадь прямоугольника: {0}", obj1.Area());
        }
        static void IsQuare(Rectangle obj1)
        {
            if (obj1.isQuare) Console.WriteLine("Данный прямоугольник является квадратом");
            else Console.WriteLine("Данный прямоугольник не является квадратом");
        }
        static void Main(string[] args)
        {
            Figura[] mas = new Figura[3];
            mas[0] = Create_Figura(0);
            mas[1] = Figura_input();
            mas[1] = New_Figura(0, mas[1]);
            //да, я извращенец
            mas[2] = Figura_input();
            mas[2] = New_Figura(1, mas[2]);
            //я хотел сделать нормальный вывод, но потом задание прочел
            mas[0].Show();
            mas[1].Show();
            IsRavnobedr((Triangle)mas[1]);
            Area_Triangle((Triangle)mas[1]);
            mas[2].Show();
            IsQuare((Rectangle)mas[2]);
            Area_Rectangle((Rectangle)mas[2]);
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
        public virtual void Show()
        {
            Console.WriteLine("x фигуры: {0}", x);
            Console.WriteLine("y фигуры: {0}", y);
        }
    }
    //amogus sus sussus understood... a m o g u s    i s   sus
    //qwe;
    class Triangle : Figura
    {
        protected int a;
        protected int b;
        protected double beta;
        public Triangle()
            : base()
        {
            a = 5;
            b = 7;
            beta = 50;
            x = 0;
            y = 0;
        }
        public Triangle(int x, int y)
            : base()
        {
            a = 5;
            b = 7;
            beta = 50;
            this.x = x;
            this.y = y;
        }
        public Triangle(int a, int b, double beta, int x, int y)
            : base()
        {
            this.a = a;
            this.b = b;
            this.beta = beta;
            this.x = x;
            this.y = y;
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
                return (a == b ^ Math.Abs(a - C) < 0.01 ^ Math.Abs(b - C) < 0.01);
            }
        }
        public double Area()
        {
            return (a * b * Math.Sin(Rad(beta)) / 2);
        }
        public override void Show()
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
            x = 0;
            y = 0;
        }
        public Rectangle(int x, int y)
            : base()
        {
            width = 4;
            height = 8;
            this.x = x;
            this.y = y;
        }
        public Rectangle(int width, int height, int x, int y)
            : base()
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
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
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Ширина: {0}", width);
            Console.WriteLine("Высота: {0}", height);
        }
    }
}
