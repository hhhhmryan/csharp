using System;

namespace Lab4
{
    class Program
    {
        static double min(double a, double b)
        {
            if (a < b) { return a; }
            else { return b; }
        }
        static double f(double x)
        {
            double function = Math.Pow(x, 3) - Math.Sin(x * Math.PI / 180);
            return function;

        }
        static int func(int x)
        {
            if (x >= 10)
            {
                int f = (x % 100) / 10;
                return f;
            }
            else return 0;
        }
        static double sum(double n)
        {
            double n1 = Math.Sqrt(n) + n;
            return n1;
        }
        static int numb(int n)
        {
            if (n % 2 == 1)
            {
                n = 0;

            }
            else n = n / 2;
            return n;
        }
        static int five(int f)
        {
            if (f % 5 == 0)
            {
                f = f / 5;

            }
            else f = f + 1;
            return f;
        }
        static double f1(double x)
        {
            double y;
            if (x>=0.9)
            {
                 y = 1 / Math.Pow(0.1 + x, 2);
            }
            else if (x<0.9 && x >=0)
            {
                y = 0.2 * x + 0.1;
            }
            else
            {
                y = Math.Pow(x, 2) + 0.2;
            }
            return y;
        }
        static double f2(double x)
        {
            double y;
            if (Math.Abs(x) <3)
            {
                y = Math.Sin(x * Math.PI / 180);
            }
            else if (Math.Abs(x)>=3 && Math.Abs(x)<9)
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 1) / Math.Sqrt(Math.Pow(x, 2) + 5);
            }
            else 
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 1) - Math.Sqrt(Math.Pow(x, 2) + 5);
            }
            return y;
        }
        static double f3(double x, double a)
        {
            double y;
            if (x<a)
            {
                y = 0;
            }
            else if (x>a)
            {
                y = (x - a) / (x + a);
            }
            else
            {
                y = 1;
            }
            return y;
        }
        static double f4(double x)
        {
            double y;
            if (Math.Abs(x) <= 0.1)
            {
                y = Math.Pow(x, 3) - 0.1;
            }
            else if (Math.Abs(x) > 0.1 && Math.Abs(x) <= 0.2)
            {
                y = 0.2 * x - 0.1;
            }
            else
            {
                y = Math.Pow(x, 3) + 0.1;
            }
            return y;
        }
        static void func1(double x, out double y)
        {
            
            if (x >= 0.9)
            {
                y = 1 / Math.Pow(0.1 + x, 2);
            }
            else if (x < 0.9 && x >= 0)
            {
                y = 0.2 * x + 0.1;
            }
            else
            {
                y = Math.Pow(x, 2) + 0.2;
            }
        }
        static void func2(double x, out double y)
        {
            if (Math.Abs(x) < 3)
            {
                y = Math.Sin(x * Math.PI / 180);
            }
            else if (Math.Abs(x) >= 3 && Math.Abs(x) < 9)
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 1) / Math.Sqrt(Math.Pow(x, 2) + 5);
            }
            else
            {
                y = Math.Sqrt(Math.Pow(x, 2) + 1) - Math.Sqrt(Math.Pow(x, 2) + 5);
            }
        }
        static void func3(double x, double a, out double y)
        {
            
            if (x < a)
            {
                y = 0;
            }
            else if (x > a)
            {
                y = (x - a) / (x + a);
            }
            else
            {
                y = 1;
            }
           
        }

        static void func4(double x, out double y)
        {
            if (Math.Abs(x) <= 0.1)
            {
                y = Math.Pow(x, 3) - 0.1;
            }
            else if (Math.Abs(x) > 0.1 && Math.Abs(x) <= 0.2)
            {
                y = 0.2 * x - 0.1;
            }
            else
            {
                y = Math.Pow(x, 3) + 0.1;
            }
           
        }
        static void Main(string[] args)
        {
            /*//Task1 
            Console.WriteLine("Введите два числа:");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            double z = min(3 * x, 2 * y) + min(x - y, x + y); ;
            Console.WriteLine(z);*/

            /*//Task2
            Console.WriteLine("Введите два числа:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            if (f(a) > f(b))
            {

                Console.WriteLine("Функция принимает наибольшее значение в точке a");
            }
            else if (f(b) > f(a))
            {
                Console.WriteLine("Функция принимает наибольшее значение в точке b");
            }
            else
            {
                Console.WriteLine("Значения фунций равны");
            }*/

            /* //Task3
             Console.WriteLine("Введите три числа:");
             Console.Write("a=");
             int a1 = int.Parse(Console.ReadLine());
             Console.Write("b=");
             int b1 = int.Parse(Console.ReadLine());
             Console.Write("с=");
             int c1 = int.Parse(Console.ReadLine());
             Console.Write("z=");
             int z1 = func(a1) + func(b1) + func(c1);
             Console.WriteLine(z1);*/

            /*//Task4

            double s = sum(6) / 2 + sum(13) / 2 + sum(21) / 2;
            Console.Write("Результат: ");
            Console.WriteLine(s);*/

            /*//Task5
            Console.WriteLine("Введите 5 чисел:");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Нечетные числа будут заменены на 0, четные числа будут уменьшены в два раза:");
            Console.WriteLine(numb(a1));
            Console.WriteLine(numb(a2));
            Console.WriteLine(numb(a3));
            Console.WriteLine(numb(a4));
            Console.WriteLine(numb(a5));*/

            //Task6
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Введите число:");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Если число кратно 5, оно будет уменьшено в 5 раз, в ином случае увеличены на 1:");
                Console.WriteLine(five(c));
            }

            //Part2

            /*//Task1
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a<=b)
            {
                Console.WriteLine(f1(a));
                a = a + h;
            }*/
            /*//Task2
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                Console.WriteLine(f2(a));
                a = a + h;
            }*/

            /*//Task3
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение a1, необходимое для выполнения условий функции:");
            Console.Write("a1=");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                Console.WriteLine(f3(a,a1));
                a = a + h;
            }*/

            /*//Task4
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                Console.WriteLine(f2(a));
                a = a + h;
            }*/

            //Part3

            /*//Task1
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                double y;
                double x = a;
                func1(x, out y); 
                Console.WriteLine(y);
                a = a + h;
            }*/

            /*//Task2
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                double y;
                double x = a;
                func2(x, out y);
                Console.WriteLine(y);
                a = a + h;
            }*/

            /*//Task3
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение a1, необходимое для выполнения условий функции:");
            Console.Write("a1=");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                double y;
                double x = a;
                func3(a, a1, out y);
                Console.WriteLine(y);
                a = a + h;
            }*/

            /*//Task4
            Console.WriteLine("Введите границы диапазона:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значение шага:");
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Для х из заданного диапазона значения y=f(x) равны:");
            while (a <= b)
            {
                double y;
                double x = a;
                func4(x, out y);
                Console.WriteLine(y);
                a = a + h;
            }*/


        }
    }
}
