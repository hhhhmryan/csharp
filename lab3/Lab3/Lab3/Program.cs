using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Задание 1
             int i = 60;
             while (i >= 10)
             {
                 Console.Write(i + " ");
                 i = i - 2;
             }
             Console.Write("\n");
             i = 60;
             do
             {
                 Console.Write(i + " ");
                 i = i - 2;
             }
             while (i >= 10);
             Console.Write("\n");
             for (i = 60; i >= 10; i -= 2)
             { Console.Write(i + " "); } */

            /*// Задание 2
            Console.WriteLine("Введите границы диапазона (А - начало, В - конец, A<B)");
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());
            if (a <= b)
            {
                double i = Math.Floor(b);
                while (a <= i)
                {
                    Console.Write(Math.Pow(i, 3) + " ");
                    i -= 1;
                }

            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {
                double i = Math.Floor(b);
                do
                {
                    Console.Write(Math.Pow(i, 3) + " ");
                    i -= 1;
                }
                while (a <= i);
            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {

                for (double i = Math.Floor(b); i >= a; i -= 1)
                {
                    Console.Write(Math.Pow(i, 3) + " ");
                }

            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");*/

            /*// Задание 3
            Console.WriteLine("Введите границы диапазона (А - начало, В - конец, A<B)");
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение N:");
            Console.Write("N=");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (a <= b)
            {
                double i = Math.Ceiling(a);
                while (i <= b)
                {
                    if (i % 10 == n)
                    {
                        Console.WriteLine(i);
                    }
                    i += 1;
                }
            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {
                double i = Math.Ceiling(a);
                do
                {
                    if (i % 10 == n)
                    {
                        Console.WriteLine(i);
                    }
                    i += 1;
                }
                while (i <= b);
            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {
                for (double i = Math.Ceiling(a); i <= b; i += 1)
                {
                    if (i % 10 == n)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else Console.WriteLine("Ошибка");*/

            /*// Задание 4
            Console.WriteLine("Введите границы диапазона (А - начало, В - конец, A<B)");
            Console.Write("A=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if (a <= b)
            {
                double i = Math.Ceiling(a);
                while (i <= b)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                    i += 1;
                }
            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {
                double i = Math.Ceiling(a);
                do
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                    i += 1;
                }
                while (i <= b);
            }
            else Console.WriteLine("Ошибка");
            Console.WriteLine("\n");

            if (a <= b)
            {
                for (double i = Math.Ceiling(a); i <= b; i += 1)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                
            }
            else Console.WriteLine("Ошибка");*/

            /*// Задание 5
            for (double a = 10; a < 100; a++)
            {
                double a1 = a % 10;
                double a2 = (a - a1) / 10;

                if (a1 != a2)
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine("\n");

            double b = 10;
            while (b < 100)
            {
                double b1 = b % 10;
                double b2 = (b - b1) / 10;

                if (b1 != b2)
                {
                    Console.Write(b + " ");
                }
                b++;
            }

            Console.WriteLine("\n");

            double c = 10;
            do
            {
                double c1 = c % 10;
                double c2 = (c - c1) / 10;

                if (c1 != c2)
                {
                    Console.Write(c + " ");
                }
                c++;
            }
            while (c < 100);*/

            /*// Задание 6

            for (int a = 100; a < 1000; a++)
            {
                int a1 = a / 100;
                int b = a % 100;
                int a2 = b / 10;
                int a3 = (b % 10) / 1;

                if ((a1 == a2 || a1 == a3 || a2 == a3))
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine("\n");

            int c = 100;
            while (c < 1000)
            {
                int c1 = c / 100;
                int d = c % 100;
                int c2 = d / 10;
                int c3 = (d % 10) / 1;

                if ((c1 == c2 || c1 == c3 || c2 == c3))
                {
                    Console.Write(c + " ");
                }
                c++;

            }

            Console.WriteLine("\n");

            int k = 100;
            do
            {
                int k1 = k / 100;
                int m = k % 100;
                int k2 = m / 10;
                int k3 = (m % 10) / 1;

                if ((k1 == k2 || k1 == k3 || k2 == k3))
                {
                    Console.Write(k + " ");
                }
                k++;
            }
            while (k < 1000);*/

            // Часть 2

            // Задание 1
            for (double j = 1; j < 5; j++)
            {

                for (double i = 1; i < 11; i++)
                {
                    Console.Write(i + " ");

                }
                Console.Write("\n");

            }

            Console.WriteLine("\n");
            // Задание 2
            for (double i = 1; i < 6; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    Console.Write(5 + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n");
            // Задание 3
            for (double i = 1; i < 6; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n");
            // Задание 4
            for (double i = 1; i < 6; i++)
            {
                for (double j = 1; j <= 6 - i; j++)
                {
                    Console.Write((9 - i) + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n");
            // Задание 5
            for (double i = 1; i < 6; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");


                }
                Console.Write("\n");
                for (double j = 1; j <= i; j++)
                {

                    Console.Write(0 + " ");

                }
                Console.Write("\n");
            }

        }
    }
}
