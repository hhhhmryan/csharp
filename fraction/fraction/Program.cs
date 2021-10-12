using System;

namespace fraction
{
    class Program
    {

        static void QuickSort<T>(T[] m, int l, int r)
                                       where T : IComparable
        {
            if (l == r)
                return;
            int i = l, j = r;
            // выбирается элемент, делящий массив на две части
            T selected = m[l];
            // осуществляется поиск и перестановка элементов, меньших
            // выбранного, с конца массива и больших выбранного
            // с начала массива.
            while (i != j)
            {
                while (m[j].CompareTo(selected) >= 0 && j > i)
                    j--;
                if (j > i)
                {
                    m[i] = m[j];
                    while (m[i].CompareTo(selected) <= 0 && i < j)
                        i++;
                    m[j] = m[i];
                }
            }
            // выбранный элемент устанавливается на надлежащее место
            m[i] = selected;
            // если существуют элементы слева от выбранного,
            // сортируем эту часть массива
            if (l <= i - 1)
                QuickSort(m, l, i - 1);
            // то же проводится с правой частью массива,
            // если она существует
            if (i + 1 < r)
                QuickSort(m, i + 1, r);
        }
        static void Main(string[] args)
        {
            // создание дроби 2/3
            Fraction fr1 = new Fraction(3, 3, 0, -1);
            Console.WriteLine("fr1 = " + fr1);
            // создание дроби 5/7
            Fraction fr2 = new Fraction(2, 3, 0, 1);
            Console.WriteLine("fr2 = " + fr2);
            Console.WriteLine("-fr2 = " + -fr2);
            Console.WriteLine("fr2 = " + (double)fr2);
            Fraction d;
            if (fr1 == fr2)
                Console.WriteLine("fr1 == fr2");
            else
                Console.WriteLine("fr1 != fr2");
            if (fr1 > fr2)
                Console.WriteLine("fr1 > fr2");
            else
                Console.WriteLine("fr1 <= fr2");
            if (fr1 > fr2)
                Console.WriteLine("fr1 <= fr2");
            else
                Console.WriteLine("fr1 > fr2");
            d = fr1 + fr2;
            Console.WriteLine("fr1 + fr2 = " + d);
            d = fr1 + (-11);
            Console.WriteLine("fr1 + (-11) = " + d);
            d = 5 + fr1;
            Console.WriteLine("5 + fr1 = " + d);
            d = fr1 - fr2;
            Console.WriteLine("fr1 - fr2 = " + d);















            /*Fraction[] a = { new Fraction(4,2,3,1),
                        new Fraction(1,3,7,-1),
                        new Fraction(0,2,7,1),
                        new Fraction(4,1,3,-1)};
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
            QuickSort(a, 0, 9);
            for (int i = 0; i < a.Length; i++)
                Console.Write("" + a[i] + " ");
            Console.WriteLine();
            */
        }
    }
}
