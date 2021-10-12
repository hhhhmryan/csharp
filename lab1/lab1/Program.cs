using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите значение периметра равностороннего треугольника.");
            double p = double.Parse(Console.ReadLine());
            double s = 0.5 * Math.Pow(p / 3, 2) * Math.Sin(Math.PI / 3);
            Console.WriteLine("{0}={1:f2}", "Площадь равностороннего треугольника равно", s);*/

            /*Console.WriteLine("Введите два числа.");
            double p = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double a = 0.5 * (Math.Pow(p, 3) + Math.Pow(k, 3));
            Console.WriteLine("{0}={1:f1}", "Среднее арифметическое кубов двух данных чисел", a);*/

            /* Console.WriteLine("Введите значение катета a прямоугольного треугольника.");
             double a = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите значение катета b прямоугольного треугольника.");
             double b = double.Parse(Console.ReadLine());
             double c = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
             Console.WriteLine("{0}={1:f2}", "Гипотенуза прямоугольного треугольника, построенного на катетах a и b", c);*/

            /*Console.WriteLine("Введите значения катетов a и b прямоугольного треугольника.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double p = a + b + c;
            Console.WriteLine("{0}={1:f2}", "Периметр прямоугольного треугольника с данными катетами", p);*/

            /*Console.WriteLine("Введите значение объёма куба.");
            double v = double.Parse(Console.ReadLine());
            double a = Math.Pow(v, 1.0 / 3.0);
            Console.WriteLine("{0}={1:f2}", "Ребро куба с данным объемом", a);*/

            /*Console.WriteLine("Введите координаты x1 и y1 вершины треугольника.");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x2 и y2 вершины треугольника.");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x3 и y3 вершины треугольника.");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double p = a + b + c;
            Console.WriteLine("{0} {1:f2}", "Периметр треугольника с данными координатами вершин равен", p);*/

            /*Console.WriteLine("Введите значение длинны окружности l.");
            double l = double.Parse(Console.ReadLine());
            double r = l / (Math.PI * 2);
            Console.WriteLine("{0}={1:f3}", "Радиус окружности с длинной l", r);*/

            /*Console.WriteLine("Введите значения оснований a и b равнобедренной трапеции.");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение угла при большем основании данной трапеции.");
            double angle = double.Parse(Console.ReadLine());
            double c = Math.Abs(b - a) / 2;
            double h = Math.Tan(angle) * c;
            double s = (a + b) / 2 * h;
            Console.WriteLine("{0}={1:f2}", "Площадь равнодедренной трапеции с заданными основаниями a и b и углом при большем из них", s);*/

            /*Console.WriteLine("Введите значение стороны a равностороннего треугольника.");
            double a = double.Parse(Console.ReadLine());
            double s = 0.5 * Math.Pow(a, 2) * Math.Sin(Math.PI / 3);
            double r = s / (a * 3 / 2);
            Console.WriteLine("{0}={1:f2}", "Радиус окружности, вписанной в равносторонний тругольник со стороной a", r);*/

            Console.WriteLine("Введите значение первого члена арифметической прогрессии.");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение разности арифметической прогрессии.");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число членов данной арифметической прогрессии.");
            double n = double.Parse(Console.ReadLine());
            double s = 0.5 * ((2 * a1) + d * (n - 1)) * n;
            Console.WriteLine("{0}={1:f2}", "Сумма членов данной арифметической прогрессии", s);





        }
    }
}