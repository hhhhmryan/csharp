using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Введите номер задания:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение х");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            double y = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
            
            if (Math.Pow(x, 2) + Math.Pow(y, 2) < 81 && x > 0)
            {
                Console.WriteLine("Да");
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) > 81 || x < 0)
            {
                Console.WriteLine("Нет");
            }
            else Console.WriteLine("На границе"); break;


                case 2:
            
            if (Math.Pow(x, 2) + Math.Pow(y, 2) > 25 && Math.Pow(x, 2) + Math.Pow(y, 2) < 100 && y > 0)
            {
                Console.WriteLine("Да");
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) < 25 || Math.Pow(x, 2) + Math.Pow(y, 2) > 100 || y < 0)
            {
                Console.WriteLine("Нет");
            }
            else Console.WriteLine("На границе");
                    break;
                case 3:

            if ((Math.Pow(x, 2) + Math.Pow(y, 2) > 9 && Math.Pow(x, 2) + Math.Pow(y, 2) < 49))
            { Console.WriteLine("Да"); }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) < 9 || Math.Pow(x, 2) + Math.Pow(y, 2) > 49))
            { Console.WriteLine("Нет"); }
            else Console.WriteLine("На границе"); break;

                case 4:
                        if ((Math.Pow(x, 2) + Math.Pow(y, 2) < 225 || Math.Pow(x, 2) + Math.Pow(y, 2) > 625))
            { Console.WriteLine("Да"); }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) > 225 && Math.Pow(x, 2) + Math.Pow(y, 2) < 625))
            { Console.WriteLine("Нет"); }
            else Console.WriteLine("На границе"); break;

                case 5:

            
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) < 225 && y > Math.Abs(x)))
            { Console.WriteLine("Да"); }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) > 225 || y < Math.Abs(x) || y < Math.Abs(x)))
            { Console.WriteLine("Нет"); }
            else Console.WriteLine("На границе"); break;

                }

            // Задание 2
            Console.WriteLine("Введите порядковый номер месяца:");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 1: Console.WriteLine("До конца года осталось 11 месяцев."); break;
                case 2: Console.WriteLine("До конца года осталось 10 месяцев."); break;
                case 3: Console.WriteLine("До конца года осталось 9 месяцев."); break;
                case 4: Console.WriteLine("До конца года осталось 8 месяцев."); break;
                case 5: Console.WriteLine("До конца года осталось 7 месяцев."); break;
                case 6: Console.WriteLine("До конца года осталось 6 месяцев."); break;
                case 7: Console.WriteLine("До конца года осталось 5 месяцев."); break;
                case 8: Console.WriteLine("До конца года осталось 4 месяца."); break;
                case 9: Console.WriteLine("До конца года осталось 3 месяца."); break;
                case 10: Console.WriteLine("До конца года осталось 2 месяца."); break;
                case 11: Console.WriteLine("До конца года остался 1 месяц."); break;
                case 12: Console.WriteLine("До конца года осталось 0 месяцев."); break;

            }

            // Задание 3
            Console.WriteLine("Введите номер масти m (от 1 до 4 включительно)");
            int m = int.Parse(Console.ReadLine());
            if (m == 1 || m == 2 || m == 3 || m == 4)
            {
                switch (m)
                {
                    case 1: Console.WriteLine("Пики"); break;
                    case 2: Console.WriteLine("Трефы"); break;
                    case 3: Console.WriteLine("Бубны"); break;
                    case 4: Console.WriteLine("Червы"); break;
                }
            }
            else Console.WriteLine("Ошибка");

            // Задание 4
            Console.WriteLine("Введите номер масти (от 1 до 4 включительно)");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты (от 6 до 14 включительно)");
            int k = int.Parse(Console.ReadLine());
            if (m1 < 1 || m1 > 4 || k < 6 || k > 14) Console.WriteLine("Ошибка");
            else
            {
                switch (k)
                {
                    case 6: Console.Write("шестерка "); break;
                    case 7: Console.Write("семерка "); break;
                    case 8: Console.Write("восьмерка "); break;
                    case 9: Console.Write("девятка "); break;
                    case 10: Console.Write("десятка "); break;
                    case 11: Console.Write("валет "); break;
                    case 12: Console.Write("дама "); break;
                    case 13: Console.Write("король "); break;
                    case 14: Console.Write("туз "); break;
                }

                switch (m1)
                {
                    case 1: Console.WriteLine("пик"); break;
                    case 2: Console.WriteLine("треф"); break;
                    case 3: Console.WriteLine("бубен"); break;
                    case 4: Console.WriteLine("червей"); break;
                }
            }

            // Задание 5
            Console.WriteLine("Введите порядковый номер для недели, чтобы узнать приемные часы врача в этот день.");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 7) Console.WriteLine("Ошибка.");
            else
            {
                switch(n)
                {
                    case 1: Console.WriteLine("Вы выбрали Понедельник. Часы приема: 9.30-13.00"); break;
                    case 2: Console.WriteLine("Вы выбрали Вторник. Часы приема: 8.00-14.30"); break;
                    case 3: Console.WriteLine("Вы выбрали Среду. Часы приема: 11.00-16.30"); break;
                    case 4: Console.WriteLine("Вы выбрали Четверг. Часы приема: 14.00-17.30"); break;
                    case 5: Console.WriteLine("Вы выбрали Пятницу. Часы приема: 8.00-14.30"); break;
                    case 6: Console.WriteLine("Вы выбрали Субботу. Это выходной день у данного врача"); break;
                    case 7: Console.WriteLine("Вы выбрали Воскресенье. Часы приема: 9.30-12.00"); break;
                }
            }

            // Задание 6
            Console.Write("Введите колличество набранных баллов: ");
            double result = double.Parse(Console.ReadLine());
            double res = Math.Floor(result);
            if (res >= 90 && res <= 100) Console.WriteLine("Ваш результат - Отлично");
            else if (res >= 70 && res <= 89) Console.WriteLine("Ваш результат - Хорошо");
            else if (res >= 50 && res <= 69) Console.WriteLine("Ваш результат - Удовлетворительно");
            else if (res >= 0 && res <= 49) Console.WriteLine("Ваш результат - Неудовлетворительно");
            else Console.WriteLine("Ошибка!");

            // Задание 7
            Console.WriteLine("Задайте признак геометрической фигуры на плоскости (к(1) - круг, п(2) - прямоугольник, т(3) - треугольник)");
            int p = int.Parse(Console.ReadLine());
            if (p>=1 && p<=3)
            {
                switch (p)
                {
                    case 1: 
                        Console.WriteLine("Это Круг. Задайте его радиус:");
                        double r = double.Parse(Console.ReadLine());
                        double p1 = 2 * Math.PI * r;
                        double s1 = Math.PI * r * r;
                        Console.WriteLine("{0} {1:f2}", "Периметр фигуры: ", p1);
                        Console.WriteLine("{0} {1:f2}", "Площадь фигуры: ", s1);
                        break;

                    case 2:
                        Console.WriteLine("Это Прямоугольник. Задайте значения его двух сторон:");
                        double a1 = double.Parse(Console.ReadLine());
                        double b1 = double.Parse(Console.ReadLine());
                        double p2 = 2 * (a1 + b1);
                        double s2 = a1 * b1;
                        Console.WriteLine("{0} {1:f2}", "Периметр фигуры: ", p2);
                        Console.WriteLine("{0} {1:f2}", "Площадь фигуры: ", s2);
                        break;

                    case 3:
                        Console.WriteLine("Это Треугольник. Задайте значения его всех трех сторон:");
                        double a3 = double.Parse(Console.ReadLine());
                        double b3 = double.Parse(Console.ReadLine());
                        double c3 = double.Parse(Console.ReadLine());
                        if (a3 + b3 > c3 && a3 + c3 > b3 && b3 + c3 > a3)
                        {
                            double p3 = a3 + b3 + c3;
                            double h = Math.Sqrt(Math.Pow(a3, 2) - Math.Pow(c3 / 2, 2));
                            double s3 = h * c3 * 0.5;
                            Console.WriteLine("{0} {1:f2}", "Периметр фигуры: ", p3);
                            Console.WriteLine("{0} {1:f2}", "Площадь фигуры: ", s3);
                        }

                        else Console.WriteLine("Такого треугольника не существует.");
                        break;
                        
                        
                        
                }
            else Console.WriteLine("Ошибка");
                
            }

            
        }

        }
 }
