using System;

namespace Lab5
{
    class Program
    {
        static void input_product(out string name, out double price, out int count, out int sale)
        {
            Console.WriteLine("Введите наименование товара:");
            name = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество товара:");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скидку на товар:");
            sale = int.Parse(Console.ReadLine());
        }

        static void output_product(string name, double price, int count, int sale)
        {
            Console.WriteLine("Наименование товара: " + name);
            Console.WriteLine("Цена товара: " + price);
            Console.WriteLine("Количество товара: " + count);
            Console.WriteLine("Скидка на товар: " + sale);
        }

        static double price_on_sale(double price, int count, int sale, out double newprice)
        {
            Console.Write("Цена товара со скидкой: ");
            double a = price * count;
            double salingprice = a * sale / 100;
            newprice = a - salingprice;
            return newprice;
        }

        static void summ(double newprice1, double newprice2, double newprice3)
        {
            Console.WriteLine("Общая стоимость всех товаров:");
            double summ = newprice1 + newprice2 + newprice3;
            Console.WriteLine(summ);
        }

        static void minimal(out double min, params double[] prices)
        {

            Console.WriteLine("Наименьшая стоимость из всех товаров:");
            min = double.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }
            }

            Console.WriteLine(min);
        }

        static void average(out double a, params double [] numbers)
        {
            a = 0;
            for (var i = 0; i <numbers.Length; i++)
            {
                a += numbers[i];
            }
            a = a / numbers.Length;
        }

        static void math (out double res, double a, double b)
        {
            res = (a + b) / 2;
            
        }

        static void math(out double res, double a, double b, double c)
        {
            res = (a + b + c) / 3;
        }

        static void math(out double res, double a, double b, double c, double d)
        {
            res = (a + b + c + d) / 4;
        }

        static void lucky(int a)
        {
            if (a / 100000 >= 1 && a / 100000 <= 9)
            {
                int a1 = a / 100000;
                int a2 = (a % 100000) / 10000;
                int a3 = (a % 10000) / 1000;
                int a4 = (a % 1000) / 100;
                int a5 = (a % 100) / 10;
                int a6 = a % 10;

                if (a1 + a2 + a3 == a4 + a5 + a6)
                {
                    Console.WriteLine("Ваш билет Счастливый.");
                }
                else Console.WriteLine("К сожалению,  Ваш билет не Счастливый.");
            }
            else Console.WriteLine("Ошибка!");
        }

        static void lucky(int a1, int a2, int a3, int a4, int a5, int a6)
        {
            if (a1 + a2 + a3 == a4 + a5 + a6)
            {
                Console.WriteLine("Ваш билет Счастливый.");
            }
            else Console.WriteLine("К сожалению,  Ваш билет не Счастливый.");
        }

        static void lucky(int a, int b)
        {
            if (a/100>=1 && a/100<=9 && b/100>=1 && b/100 <=9)
            {
                int a1 = a / 100;
                int a2 = (a % 100) / 10;
                int a3 = a % 10;
                int b1 = a / 100;
                int b2 = (a % 100) / 10;
                int b3 = a % 10;

                if (a1 + a2 + a3 == b1 + b2 + b3)
                {
                    Console.WriteLine("Ваш билет Счастливый.");
                }
                else Console.WriteLine("К сожалению,  Ваш билет не Счастливый.");
            }
            else Console.WriteLine("Ошибка!");
        }
        
        static void Main(string[] args)
        {   /*
            string name1, name2, name3 = "Boeing 777";
            double price1, price2, price3 = 2;
            int count1, count2, count3 = 1000000;
            int sale1, sale2, sale3 = 0;
            double newprice1, newprice2, newprice3;

            input_product(out name1, out price1, out count1, out sale1);
            Console.WriteLine("\n");
            input_product(out name2, out price2, out count2, out sale2);
            Console.WriteLine("\n");

            Console.WriteLine("Ваши товары:");
            output_product(name1, price1, count1, sale1);
            price_on_sale(price1, count1, sale1, out newprice1);
            Console.WriteLine(newprice1);
            Console.WriteLine("\n");
            output_product(name2, price2, count2, sale2);
            price_on_sale(price2, count2, sale2, out newprice2);
            Console.WriteLine(newprice2);
            Console.WriteLine("\n");
            output_product(name3, price3, count3, sale3);
            price_on_sale(price3, count3, sale3, out newprice3);
            Console.WriteLine(newprice3);
            Console.WriteLine("\n");
            summ(newprice1, newprice2, newprice3);
            Console.WriteLine("\n");
            minimal(out double min, new[] { newprice1, newprice2, newprice3 });
            */

            //Task2
            double res;
            Console.WriteLine("Введите значения переменных:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d=");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            
            math(out res, a,b);
            Console.Write("Среднее арифметическое для a и b: " + res);
            Console.WriteLine("\n");
            math(out res, a, b, c);
            Console.Write("Среднее арифметическое для a, b и c: " + res);
            Console.WriteLine("\n");
            math(out res, a, b, c, d);
            Console.Write("Среднее арифметическое для a, b, c и d: " + res);
            Console.WriteLine("\n");

            Console.Write("Среднее арифметическое для заданного кол-ва: ");
            average(out double a1, new[] { a, b, c, d });
            Console.WriteLine(a);


            /*//task3 
            Console.Write("Введите шестизначное число: ");
            int a = int.Parse(Console.ReadLine());
            lucky(a);
            Console.WriteLine("\n");
            Console.WriteLine("Введите шестизначное число (каждая цифра отдельно) : ");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            int a5 = int.Parse(Console.ReadLine());
            int a6 = int.Parse(Console.ReadLine());
            lucky(a1, a2, a3, a4, a5, a6);
            Console.WriteLine("\n");
            Console.WriteLine("Введите шестизначное число двумя трехзначными числами (первая и вторая половина номера) : ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            lucky(m, n);
            */
        }
    }
}
