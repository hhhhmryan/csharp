using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    class Rectangle : Figure
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

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Perimeter()
        {
            return 2 * (A + B);
        }

        public override double Square()
        {
            return A * B;
        }

        public override void Info()
        {
            Console.WriteLine("Ваша фигура: Прямоугольник. Длина одной стороны: " + A + ". Длина второй стороны: " + B + ".");
        }
    }
}
