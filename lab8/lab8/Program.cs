using System;
using System.Text;

namespace lab8
{
    class Program
    {
        static StringBuilder task1(StringBuilder line)
        {
            for (int i = 0; i < line.Length - 1; i += 2)
            {
                char a = line[i];
                line[i] = line[i + 1];
                line[i + 1] = a;
            }
            return line;
        }
        static int task2(string letters, out int n)
        {
            n = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter(letters[i]))
                {
                    n++;
                }
            }
            return n;
        }

        static void task3(string mystring, out bool res)
        {
            res = false;
            for (int i = 0; i < mystring.Length - 1; i++)
            {
                if (mystring[i] == mystring[i + 1])
                {
                    res = true;
                }
            }
        }
        static StringBuilder task4(StringBuilder middle)
        {
            if (middle.Length % 2 == 1)
            {
                middle.Remove(middle.Length / 2, 1);
            }
            else if (middle.Length % 2 == 0)
            {
                middle.Remove(middle.Length / 2 - 1, 2);
            }
            return middle;
        }
        static String task5(string sub)
        {
            Console.WriteLine("Введите подстроку, которую нужно заменить:");
            string substring1 = Console.ReadLine();
            Console.WriteLine("Введите подстроку, на которую нужно заменить исходную подстроку:");
            string substring2 = Console.ReadLine();
            sub = sub.Replace(substring1, substring2);
            Console.WriteLine(sub);
            return sub;
        }
        static int task6(string number, out int sum)
        {
            sum = 0;
            for (int i = 0; i < number.Length; i++)
                if (Char.IsDigit(number[i]))
                {
                    sum += Convert.ToInt32(Char.GetNumericValue(number[i]));
                }
            return sum;
        }
        static string task7(string cut)
        {
            int a = cut.IndexOf(':');
            cut = cut.Substring(0, a);
            Console.WriteLine(cut);
            return cut;
        }
        static string task8(string cut)
        {
            int a = cut.LastIndexOf(':');
            cut = cut.Substring(a + 1);
            Console.WriteLine(cut);
            return cut;
        }
        static string task9(string anotherone)
        {
            string[] cuts = anotherone.Split(',');
            Console.WriteLine("Result: " + cuts[0] + cuts[cuts.Length - 1]);
            return anotherone;
        }

        static string task10(string thestring, out int count)
        {
            count = 0;
            for (int i=0; i< thestring.Length; i++)
            {
                int inner = 1;
                for (int j = 0; j<i; j++)
                {
                    if (thestring[j]==thestring[i])
                    {
                        Console.WriteLine(thestring[j]+ " " + thestring[i]);
                        inner = 0; ;
                    }
                }
                if (inner!=0)
                {
                    count += inner;
                }
                Console.WriteLine("c=" + count);
            }
            return thestring;
        }
        static void Main(string[] args)
        {   /*
            //task1
            StringBuilder line = new StringBuilder("Собака");
            Console.WriteLine(line);
            task1(line);
            Console.WriteLine(line);

            //task2
            int n = 0;
            Console.WriteLine("Введите строку:");
            string letters = Console.ReadLine();
            task2(letters, out n);
            Console.WriteLine("Количество букв в строке: " + n);

            //task3 
            bool res;
            Console.WriteLine("Введите строку:");
            string mystring = Console.ReadLine();
            task3(mystring, out res);
            Console.WriteLine("Есть ли в строке два соседствующих одинаковых символа: " + res);

            //task4
            Console.WriteLine("Введите строку:");
            StringBuilder middle = new StringBuilder(Console.ReadLine());
            task4(middle);
            Console.WriteLine(middle);

            //task5
            Console.WriteLine("Введите строку:");
            string sub = Console.ReadLine();
            task5(sub);

            //task6
            int sum;
            Console.WriteLine("Введите строку:");
            string number = Console.ReadLine();
            task6(number, out sum);
            Console.WriteLine("Сумма цифр в строке: " + sum);

            //task7
            Console.WriteLine("Введите строку:");
            string cut = Console.ReadLine();
            task7(cut);

            //task8
            Console.WriteLine("Введите строку:");
            string cut1 = Console.ReadLine();
            task8(cut1);

            //task9
            Console.WriteLine("Введите строку:");
            string anotherone = Console.ReadLine();
            task9(anotherone);
            */
            //task10
            int count;
            Console.WriteLine("Введите строку:");
            string thestring = Console.ReadLine();
            task10(thestring, out count);
            Console.WriteLine("Различных символов: " + count);
        }
    }
}
