using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    class Triangle : Figure
    {
        double a;
        public double A
        {
            get
            {
                return a;
            }

            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("Длина стороны должна быть больше нуля.");
                }
            }
        }

        double b;
        public double B
        {
            get
            {
                return b;
            }

            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("Длина стороны должна быть больше нуля.");
                }
            }
        }

        double c;
        public double C
        {
            get
            {
                return c;
            }

            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new Exception("Длина стороны должна быть больше нуля.");
                }
            }
        }

        public bool Check()
        {
            bool x = (A + B > C) && (B + C > A) && (A + C > B);
            return x;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Perimeter()
        {
            double p = 0;
            if (Check() == true)
            {
                p = A + B + C;
            }
            return p;
        }

        public override double Square()
        {
            double s = 0;
            if (Check() == true) s = Math.Sqrt((Perimeter() / 2) * ((Perimeter() / 2) - A) * ((Perimeter() / 2) - B) * ((Perimeter() / 2) - C));
            return s;
        }

        public override void Info()
        {
            Console.WriteLine("Ваша фигура: Треугольник.");
            if (Check() == true)
            {
                Console.WriteLine("Длина первой стороны: " + A + ". Длина второй стороны: " + B + ". Длина третьей стороны: " + C + ".");
            }
            else Console.WriteLine("Такого треугольника не существует.");
        }

    }
}
