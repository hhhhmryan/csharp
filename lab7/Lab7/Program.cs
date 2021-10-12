using System;

namespace Lab7
{
    class Program
    {
        static void arrayin(int[,] a)
        {
            Random ran = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ran.Next(10, 20);
                }
            }
        }
        static void arrayin2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = i + 1;
                }
            }
        }
        static void arrayin3(int[,] a)
        {
            Random ran = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ran.Next(0, 2);
                }
            }
        }
        static void arrayin6(int[,] a)
        {
            Random ran = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = ran.Next(-20, 20);
                }
            }
        }

        static void arrayout(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void arr1(int[,] a)
        {
            Console.WriteLine("Введите номер строки n:");
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[(n - 1), j] + " ");
            }
            Console.WriteLine("\n");
        }
        static void arr2(int[,] a)
        {
            Console.WriteLine("Введите номер столбца m:");
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("{0}\t", a[i, (m - 1)]);
            }
            Console.WriteLine("\n");
        }
        static void summ3(int[,] a, out int summ)
        {

            summ = 0;
            for (int j = 0; j < 5; j++)
            {
                summ = summ + a[2, j];
            }

        }
        static void places(int n, int m, int[,] b)
        {
            int x;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x = b[i, j];
                    b[i, j] = b[b.GetUpperBound(0) - i, j];
                    b[b.GetUpperBound(0) - i, j] = x;
                }
            }
        }
        static void tickets(int[,] a, out int summ)
        {
            summ = 0;
            Console.WriteLine("Введите номер вагона");
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < 36; j++)
            {
                summ = summ + a[(n - 1), j];
            }

        }
        static void min1(int[,] a, int n, int m, out int min)
        {
            int summ = 0;
            for (int j = 0; j < m; j++)
            {
                summ += a[0, j];
            }
            min = summ;
            summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    summ = summ + a[i, j];
                }
                if (summ < min)
                {
                    min = summ;
                }
                summ = 0;
            }

        }
        static void min2(int[,] a, int n, int m, out int min)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                summ += a[i, 0];
            }
            min = summ;
            summ = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    summ += a[i, j];
                }
                if (summ < min)
                {
                    min = summ;
                }
                summ = 0;
            }
        }
        static void diag1(int[,] a, out int summ)
        {
            summ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        summ += a[i, j];
                    }
                }
            }
        }

        static void diag2(int[,] a, out int summ)
        {
            summ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == a.GetLength(1) - i - 1)
                    {
                        if (a[i, j] % 2 == 0)
                        {
                            summ += 1;
                        }
                    }
                }
            }
        }
        static void oneone(int[,] a, int[] b)
        {
            int summ = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (a[i, j] % 2 == 0 && a[i, j] > 0)
                    {
                        summ = summ + a[i, j];
                    }
                }

                b[j] = summ;
                summ = 0;
            }
        }
        static void onetwo(int[,] a, int[] c)
        {
            int max = 0; int maxnum;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                max = Math.Abs(a[i, 0]); maxnum = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (Math.Abs(a[i, j]) > max)
                    {
                        max = Math.Abs(a[i, j]);
                        maxnum = a[i, j];
                    }
                }

                c[i] = maxnum;
            }
        }
        static void Main(string[] args)
        {
            /*//task1 
            int summ;
            Console.WriteLine("Введите число строк и столбцов массива");
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m=");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            arrayin(a);
            arrayout(a);
            arr1(a);
            arr2(a);
            summ3(a, out summ);
            Console.WriteLine("Сумма элементов третьей строки: ");
            Console.Write(summ);
            */
            /*//task2
            Console.WriteLine("Введите число строк и столбцов массива");
            Console.WriteLine("n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m:");
            int m = int.Parse(Console.ReadLine());
            int[,] b = new int[n, m];
            arrayin2(b);
            arrayout(b);
            Console.WriteLine("\n");
            places(n, m, b);
            arrayout(b);
            */
            /*//task3
            int summ = 0;
            int[,] a = new int[18, 36];
            arrayin3(a);
            arrayout(a);
            tickets(a, out summ);
            Console.WriteLine("Колличество свободных мест в данном вагоне: ");
            Console.Write(36 - summ);
            */
            /*//task4
            int min;
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            arrayin(a);
            arrayout(a);
            min1(a, n, m, out min);
            Console.WriteLine("Минимальная сумма элементов строки массива " + min);
            min2(a, n, m, out min);
            Console.WriteLine("Минимальная сумма элементов столбца массива " + min);
            */
            /*//task5
            int summ = 0;
            Console.WriteLine("Введите количество строк и столбцов : ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            arrayin(a);
            arrayout(a);
            diag1(a, out summ);
            Console.WriteLine("Сумма элементов главной диагонали: " + summ);
            diag2(a, out summ);
            Console.WriteLine("Количество четных элементов на побочной диагонали: " + summ);
            */
            //task6
            Console.WriteLine("Введите количество строк: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[] b = new int[m];
            int[] c = new int[n];
            arrayin6(a);
            arrayout(a);
            Console.WriteLine();
            oneone(a, b);
            Console.Write("Новый массив: ");
            for (int j = 0; j < m; j++)
            {
                Console.Write(b[j] + " ");
            }
            Console.WriteLine();
            Console.Write("Новый массив: ");
            onetwo(a, c);
            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
