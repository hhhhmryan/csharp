using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    class Circle : Figure
    {
        double radius;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Радиус должен быть больше нуля.");
                }

            }
        }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Info()
        {
            Console.WriteLine("Ваша фигура: Круг. Радиус равен: " + Radius);
        }
    }
}
