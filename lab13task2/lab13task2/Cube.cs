using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task2
{
    class Cube : Function
    {
        double a;
        double b;
        double c;

        public Cube(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Func(double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        public override void Info()
        {
            Console.WriteLine("Ваша функция: Куб.");
            Console.WriteLine($"Коэфициенты функции. a = {a}, b = {b}, c = {c}");
        }
    }
}
