using System;

namespace Lab6
{
    class Program
    {
        static void arrayin1(int [] a)
        {
           
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(50, 100);
            }
        }
        static void arrayin2(int[] a)
        {

            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1, 50);
            }
        }
        static void arrayout(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void multiplication(int n, int[] b)
        {
            for (int i = 0; i < n; i++)
            {
                b[i] = 2 * b[i];
            }
        }
        static void division(int n, int[] b)
        {
            int m = b[0];
            for (int i = 0; i < n; i++)
            {

                b[i] = b[i] / m;
            }
        }
        static void a(int biga, int n, int[] b)
        {
            for (int i = 0; i < n; i++)
            {
                b[i] = b[i] - biga;
            }
        }

        static void check(int[] b, out bool c)
        {
            int summ = 0;
            for (int i = 0; i < b.Length; i++)
            {
                summ += b[i];
            }

            c = summ == 0;
            
        }

        static void five(int[] b, out bool c)
        {
            double summ = 0;
            for (int i = 0; i < b.Length; i++)
            {
                summ = summ + Math.Pow(b[i], 2);
            }
            c = summ / 10000 >= 1 && summ / 10000 <= 9;
        }

        static void houses(int[] b, out int even, out int odd)
        {
            even = 0;
            odd = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    even = even + b[i];
                }
                else if ((i + 1) % 2 == 1)
                {
                    odd = odd + b[i];
                }
            }
           

        }

        static void sign(int n, int[] b, out int s)
        {
            s = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((b[i] > 0 && b[i - 1] < 0) || (b[i] < 0 && b[i - 1] > 0))
                {
                    s += 1;
                }
            }
        }
        static void Main(string[] args)
        {
            /*//task1
            int[] a = new int[20];
            arrayin1(a);
            arrayout(a);
            */
            /*//task2
            Console.WriteLine("Введите длинну массива:");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            arrayin2(b);
            arrayout(b);
            Console.WriteLine("\n");
            Console.WriteLine("Измененный массив (элементы массива увеличены в 2 раза):");
            multiplication(n, b);
            arrayout(b);
            Console.WriteLine("\n");
            Console.WriteLine("Еще раз измененный массив (все элементы разделены на первый элемент массива):");
            division(n, b);
            arrayout(b);
            Console.WriteLine("\n");
            Console.WriteLine("Введите А:");
            int biga = int.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Еще раз измененный массив (все элементы уменьшены на число А):");
            a(biga, n, b);
            arrayout(b);
            */

            /*//task3 
            bool c;
            Console.WriteLine("Введите длинну массива:");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            Console.WriteLine("Ваш массив:");
            arrayin2(b);
            arrayout(b);
            Console.WriteLine("\n");
            Console.Write("Проверка на четность суммы элементов массива: ");
            check(b, out c);
            Console.WriteLine(c);
            Console.Write("Проверка, является ли сумма квадратов всех элементов массива пятизначным числом: ");
            five(b, out c);
            Console.WriteLine(c);
            */

            //task4
            int even; int odd;
            Console.WriteLine("Введите колличество домов на улице:");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            Console.WriteLine("Число жителей, проживающих в каждом доме:");
            arrayin2(b);
            arrayout(b);
            Console.WriteLine("\n");
            houses(b, out even, out odd);
            if (even > odd)
            {
                Console.WriteLine("На стороне с домами, номера которых четны, людей проживает больше.");
            }
            else if (even < odd)
            {
                Console.WriteLine("На стороне с домами, номера которых нечетны, людей проживает больше.");
            }
            else Console.WriteLine("На обеих сторонах улицы живет одинаковое количество жителей.");


            /*//task5
            Console.WriteLine("Введите длинну массива:");
            int n = int.Parse(Console.ReadLine());
            int[] b = new int[n];
            Random rand = new Random();
            int s;
            for (int i = 0; i < n; i++)
            {
                b[i] = rand.Next(-100, 100);
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("\n");
            sign(n, b, out s);
            Console.WriteLine("При просмотре массива от его начала элементы меняли свой знак " + s + " раз(-а).");
            */
        }
    }
}
